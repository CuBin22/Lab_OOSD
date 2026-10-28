using System;
using System.Data;
using QuanLyCuaHangNuoc.Data;

namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Theo dõi phiếu hẹn giao hàng và lập phiếu ghi nợ cho khách quen.</summary>
    public class HenNoService
    {
        public const string ChuaGiao = "Chưa giao";
        public const string DaGiao = "Đã giao";

        // ------------------ Phiếu hẹn ------------------
        public DataTable LayPhieuHen(string trangThai)
        {
            return Db.Query(@"SELECT p.SoPhieuHen,p.SoHD,k.HoTen,p.NgayHen,p.TrangThai,
                                     CASE WHEN EXISTS(SELECT 1 FROM PhieuHen q WHERE q.SoHD=p.SoHD AND q.TrangThai=N'Chưa giao')
                                          THEN N'Còn hàng chưa giao' ELSE N'Đã giao đủ' END AS TinhTrangHD
                              FROM PhieuHen p JOIN HoaDon h ON h.SoHD=p.SoHD JOIN KhachHang k ON k.MaKH=h.MaKH
                              WHERE (@tt=N'' OR p.TrangThai=@tt) ORDER BY p.NgayHen, p.SoPhieuHen", Db.P("@tt", trangThai ?? ""));
        }

        public DataTable LayChiTietHen(string soPhieu)
        {
            return Db.Query(@"SELECT c.MaNGK,n.TenNGK,n.DonViTinh,c.SoLuongHen,n.SoLuongTon FROM ChiTietPhieuHen c
                              JOIN NuocGiaiKhat n ON n.MaNGK=c.MaNGK WHERE c.SoPhieuHen=@p ORDER BY c.MaNGK", Db.P("@p", soPhieu));
        }

        static void CanChuaGiao(System.Data.SqlClient.SqlTransaction tx, string soPhieu)
        {
            DataTable t = Db.Query(tx, "SELECT TrangThai FROM PhieuHen WITH (UPDLOCK) WHERE SoPhieuHen=@p", Db.P("@p", soPhieu));
            if (t.Rows.Count == 0) throw new NghiepVuException("Không tìm thấy phiếu hẹn " + soPhieu + ".");
            if (Convert.ToString(t.Rows[0][0]) != ChuaGiao) throw new NghiepVuException("Phiếu hẹn " + soPhieu + " đã giao, không thể thay đổi.");
        }

        public KetQuaXuLy DoiNgayHen(string soPhieu, DateTime ngayMoi)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(soPhieu)) throw new NghiepVuException("Chưa chọn phiếu hẹn.");
                if (ngayMoi.Date < DateTime.Today) throw new NghiepVuException("Ngày hẹn mới không được trước ngày hôm nay.");
                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    CanChuaGiao(tx, soPhieu);
                    Db.Execute(tx, "UPDATE PhieuHen SET NgayHen=@n WHERE SoPhieuHen=@p", Db.P("@n", ngayMoi.Date), Db.P("@p", soPhieu));
                    tx.Commit();
                }
                return "Đã đổi ngày hẹn của phiếu " + soPhieu + " sang " + ngayMoi.ToString("dd/MM/yyyy") + ".";
            });
        }

        public KetQuaXuLy XacNhanGiao(string soPhieu)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(soPhieu)) throw new NghiepVuException("Chưa chọn phiếu hẹn.");
                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    CanChuaGiao(tx, soPhieu);
                    DataTable ct = Db.Query(tx, @"SELECT c.MaNGK,n.TenNGK,c.SoLuongHen,n.SoLuongTon FROM ChiTietPhieuHen c
                                                  JOIN NuocGiaiKhat n WITH (UPDLOCK) ON n.MaNGK=c.MaNGK WHERE c.SoPhieuHen=@p", Db.P("@p", soPhieu));
                    foreach (DataRow r in ct.Rows)
                        if (Convert.ToInt32(r["SoLuongHen"]) > Convert.ToInt32(r["SoLuongTon"]))
                            throw new NghiepVuException("Chưa đủ hàng để giao: " + r["TenNGK"] + " cần " + r["SoLuongHen"] + ", tồn " + r["SoLuongTon"] + ".");
                    foreach (DataRow r in ct.Rows)
                        Db.Execute(tx, "UPDATE NuocGiaiKhat SET SoLuongTon=SoLuongTon-@q WHERE MaNGK=@m",
                            Db.P("@q", Convert.ToInt32(r["SoLuongHen"])), Db.P("@m", Convert.ToString(r["MaNGK"])));
                    Db.Execute(tx, "UPDATE PhieuHen SET TrangThai=N'Đã giao' WHERE SoPhieuHen=@p", Db.P("@p", soPhieu));
                    tx.Commit();
                }
                return "Đã giao hàng theo phiếu hẹn " + soPhieu + " và trừ tồn kho.";
            });
        }

        /// <summary>Tách một phần số lượng của một mặt hàng sang phiếu hẹn mới (đợt giao khác ngày).</summary>
        public KetQuaXuLy TachDot(string soPhieu, string maNGK, int soLuong, DateTime ngayMoi)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(soPhieu) || string.IsNullOrWhiteSpace(maNGK))
                    throw new NghiepVuException("Chọn phiếu hẹn và mặt hàng cần tách đợt.");
                if (soLuong <= 0) throw new NghiepVuException("Số lượng tách phải lớn hơn 0.");
                if (ngayMoi.Date <= DateTime.Today) throw new NghiepVuException("Ngày đợt giao mới phải sau ngày hôm nay.");
                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    CanChuaGiao(tx, soPhieu);
                    DataTable t = Db.Query(tx, "SELECT SoLuongHen FROM ChiTietPhieuHen WHERE SoPhieuHen=@p AND MaNGK=@m", Db.P("@p", soPhieu), Db.P("@m", maNGK));
                    if (t.Rows.Count == 0) throw new NghiepVuException("Mặt hàng không thuộc phiếu hẹn.");
                    int hien = Convert.ToInt32(t.Rows[0][0]);
                    if (soLuong >= hien) throw new NghiepVuException("Số lượng tách phải nhỏ hơn số lượng hẹn hiện có (" + hien + ").");
                    string soHD = Convert.ToString(Db.Scalar(tx, "SELECT SoHD FROM PhieuHen WHERE SoPhieuHen=@p", Db.P("@p", soPhieu)));
                    string moi = MaService.Tiep("PhieuHen", "SoPhieuHen", "PH", 3, tx);
                    Db.Execute(tx, "INSERT INTO PhieuHen(SoPhieuHen,SoHD,NgayHen,TrangThai) VALUES(@p,@h,@n,N'Chưa giao')",
                        Db.P("@p", moi), Db.P("@h", soHD), Db.P("@n", ngayMoi.Date));
                    Db.Execute(tx, "INSERT INTO ChiTietPhieuHen(SoPhieuHen,MaNGK,SoLuongHen) VALUES(@p,@m,@q)", Db.P("@p", moi), Db.P("@m", maNGK), Db.P("@q", soLuong));
                    Db.Execute(tx, "UPDATE ChiTietPhieuHen SET SoLuongHen=SoLuongHen-@q WHERE SoPhieuHen=@p AND MaNGK=@m", Db.P("@q", soLuong), Db.P("@p", soPhieu), Db.P("@m", maNGK));
                    tx.Commit();
                    return "Đã tách " + soLuong + " thành đợt giao mới " + moi + " ngày " + ngayMoi.ToString("dd/MM/yyyy") + ".";
                }
            });
        }

        // ------------------ Phiếu ghi nợ ------------------
        public string MaNoMoi() { return MaService.Tiep("PhieuGhiNo", "SoPhieuNo", "PGN", 3); }

        public DataTable LayHoaDonKhachQuen()
        {
            return Db.Query(@"SELECT h.SoHD, h.SoHD + N' - ' + k.HoTen + N' - ' + FORMAT(h.TongTien,'N0') + N' đ' AS HienThi
                              FROM HoaDon h JOIN KhachHang k ON k.MaKH=h.MaKH WHERE k.LoaiKhach=N'Khách quen' ORDER BY h.SoHD DESC");
        }

        /// <summary>Trả về HoTen, TongTien, DaGhiNo, ConLai cho một hóa đơn.</summary>
        public DataTable LayThongTinHD(string soHD)
        {
            return Db.Query(@"SELECT k.HoTen,h.TongTien,
                                     ISNULL((SELECT SUM(SoTienNo) FROM PhieuGhiNo n WHERE n.SoHD=h.SoHD),0) AS DaGhiNo,
                                     h.TongTien - ISNULL((SELECT SUM(SoTienNo) FROM PhieuGhiNo n WHERE n.SoHD=h.SoHD),0) AS ConLai
                              FROM HoaDon h JOIN KhachHang k ON k.MaKH=h.MaKH WHERE h.SoHD=@h", Db.P("@h", soHD));
        }

        public KetQuaXuLy LapGhiNo(string soNo, string soHD, string maNV, DateTime ngayLap, decimal tien, DateTime ngayDuKien, string lyDo)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(soNo) || string.IsNullOrWhiteSpace(soHD) || string.IsNullOrWhiteSpace(maNV))
                    throw new NghiepVuException("Số phiếu, hóa đơn và nhân viên lập không được để trống.");
                if (string.IsNullOrWhiteSpace(lyDo)) throw new NghiepVuException("Phải nhập lý do nợ.");
                if (tien <= 0) throw new NghiepVuException("Số tiền nợ phải lớn hơn 0.");
                if (ngayDuKien.Date < ngayLap.Date) throw new NghiepVuException("Ngày dự kiến trả không được trước ngày lập phiếu.");
                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    DataTable t = Db.Query(tx, @"SELECT h.MaKH,k.LoaiKhach,h.TongTien,
                                                        ISNULL((SELECT SUM(SoTienNo) FROM PhieuGhiNo n WHERE n.SoHD=h.SoHD),0) AS DaNo
                                                 FROM HoaDon h JOIN KhachHang k ON k.MaKH=h.MaKH WHERE h.SoHD=@h", Db.P("@h", soHD));
                    if (t.Rows.Count == 0) throw new NghiepVuException("Không tìm thấy hóa đơn " + soHD + ".");
                    if (Convert.ToString(t.Rows[0]["LoaiKhach"]) != "Khách quen") throw new NghiepVuException("Chỉ khách quen mới được lập phiếu ghi nợ.");
                    decimal conLai = Convert.ToDecimal(t.Rows[0]["TongTien"]) - Convert.ToDecimal(t.Rows[0]["DaNo"]);
                    if (tien > conLai) throw new NghiepVuException("Số tiền nợ vượt số tiền còn phải trả của hóa đơn (" + conLai.ToString("N0") + " đ).");
                    Db.Execute(tx, @"INSERT INTO PhieuGhiNo(SoPhieuNo,SoHD,MaKH,MaNV,NgayLap,SoTienNo,NgayDuKienTra,LyDo)
                                     VALUES(@p,@h,@k,@nv,@n,@t,@d,@l)",
                        Db.P("@p", soNo.Trim()), Db.P("@h", soHD), Db.P("@k", Convert.ToString(t.Rows[0]["MaKH"])), Db.P("@nv", maNV),
                        Db.P("@n", ngayLap.Date), Db.P("@t", tien), Db.P("@d", ngayDuKien.Date), Db.P("@l", lyDo.Trim()));
                    tx.Commit();
                }
                return "Đã lập phiếu ghi nợ " + soNo.Trim() + " - " + tien.ToString("N0") + " đ.";
            });
        }

        public DataTable LayGhiNo(string kw)
        {
            return Db.Query(@"SELECT p.SoPhieuNo,p.SoHD,k.HoTen,n.HoTen AS NhanVien,p.NgayLap,p.SoTienNo,p.NgayDuKienTra,p.LyDo
                              FROM PhieuGhiNo p JOIN KhachHang k ON k.MaKH=p.MaKH JOIN NhanVien n ON n.MaNV=p.MaNV
                              WHERE k.HoTen LIKE @k OR p.SoHD LIKE @k OR p.SoPhieuNo LIKE @k ORDER BY p.NgayLap DESC, p.SoPhieuNo DESC",
                Db.P("@k", "%" + (kw ?? "").Trim() + "%"));
        }
    }
}
