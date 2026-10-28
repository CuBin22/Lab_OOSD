using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QuanLyCuaHangNuoc.Data;

namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Bán hàng: kiểm tra tồn kho, giao ngay + hóa đơn; thiếu hàng thì hẹn giao (khách quen); có thể ghi nợ.</summary>
    public class BanHangService
    {
        public const string KhachQuen = "Khách quen";
        public const string KhachVangLai = "Khách vãng lai";

        public DataTable LayKhach()
        {
            return Db.Query("SELECT MaKH, MaKH + N' - ' + HoTen + N' (' + LoaiKhach + N')' AS HienThi, LoaiKhach FROM KhachHang ORDER BY MaKH");
        }

        public DataTable LayHang(string kw)
        {
            return Db.Query(@"SELECT MaNGK,TenNGK,DonViTinh,DonGia,SoLuongTon FROM NuocGiaiKhat
                              WHERE MaNGK LIKE @k OR TenNGK LIKE @k ORDER BY MaNGK", Db.P("@k", "%" + (kw ?? "").Trim() + "%"));
        }

        public DataTable LayHoaDonGanDay()
        {
            return Db.Query(@"SELECT TOP 50 h.SoHD,k.HoTen,k.LoaiKhach,n.HoTen AS NhanVien,h.NgayLap,h.TongTien,
                                     CASE WHEN EXISTS(SELECT 1 FROM PhieuHen p WHERE p.SoHD=h.SoHD AND p.TrangThai=N'Chưa giao')
                                          THEN N'Còn hàng hẹn chưa giao' ELSE N'Đã giao đủ' END AS TinhTrangGiao
                              FROM HoaDon h JOIN KhachHang k ON k.MaKH=h.MaKH JOIN NhanVien n ON n.MaNV=h.MaNV
                              ORDER BY h.NgayLap DESC, h.SoHD DESC");
        }

        /// <summary>Kiểm tra tồn kho từng dòng; trả về danh sách mô tả các mặt hàng thiếu (rỗng nếu đủ).</summary>
        public List<string> KiemTraTon(List<DongBan> ds)
        {
            List<string> thieu = new List<string>();
            foreach (DongBan x in ds)
            {
                object o = Db.Scalar("SELECT SoLuongTon FROM NuocGiaiKhat WHERE MaNGK=@m", Db.P("@m", x.MaNGK));
                int ton = o == null ? 0 : Convert.ToInt32(o);
                x.SoLuongTon = ton;
                if (x.SoLuong > ton) thieu.Add(x.TenNGK + ": cần " + x.SoLuong + ", tồn " + ton + " (thiếu " + (x.SoLuong - ton) + ")");
            }
            return thieu;
        }

        public KetQuaXuLy LapHoaDon(string maKH, string maNV, List<DongBan> ds, DateTime? ngayHen,
                                    bool ghiNo, decimal tienNo, DateTime ngayDuKienTra, string lyDo)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(maNV))
                    throw new NghiepVuException("Phải chọn khách hàng và nhân viên lập hóa đơn.");
                if (ds == null || ds.Count == 0) throw new NghiepVuException("Giỏ hàng đang trống.");
                foreach (DongBan x in ds)
                    if (x.SoLuong <= 0) throw new NghiepVuException("Số lượng của " + x.TenNGK + " phải lớn hơn 0.");

                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    DataTable kh = Db.Query(tx, "SELECT LoaiKhach FROM KhachHang WHERE MaKH=@k", Db.P("@k", maKH));
                    if (kh.Rows.Count == 0) throw new NghiepVuException("Không tìm thấy khách hàng.");
                    bool quen = Convert.ToString(kh.Rows[0][0]) == KhachQuen;

                    // 1. Đọc giá + tồn hiện tại (khóa dòng để tránh bán trùng)
                    decimal tong = 0;
                    List<DongBan> thieu = new List<DongBan>();
                    foreach (DongBan x in ds)
                    {
                        DataTable h = Db.Query(tx, "SELECT DonGia,SoLuongTon FROM NuocGiaiKhat WITH (UPDLOCK,ROWLOCK) WHERE MaNGK=@m", Db.P("@m", x.MaNGK));
                        if (h.Rows.Count == 0) throw new NghiepVuException("Không tìm thấy mặt hàng " + x.MaNGK + ".");
                        x.DonGia = Convert.ToDecimal(h.Rows[0]["DonGia"]);
                        x.SoLuongTon = Convert.ToInt32(h.Rows[0]["SoLuongTon"]);
                        tong += x.DonGia * x.SoLuong;
                        if (x.SoLuong > x.SoLuongTon) thieu.Add(x);
                    }

                    // 2. Thiếu hàng: chỉ khách quen được hẹn giao
                    if (thieu.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (DongBan x in thieu) sb.AppendLine("- " + x.TenNGK + ": cần " + x.SoLuong + ", tồn " + x.SoLuongTon);
                        if (!quen)
                            throw new NghiepVuException("Không đủ hàng. Khách vãng lai phải nhận hàng ngay nên không thể hẹn giao:\n" + sb);
                        if (ngayHen == null || ngayHen.Value.Date <= DateTime.Today)
                            throw new NghiepVuException("Thiếu hàng - phải chọn ngày hẹn giao sau ngày hôm nay cho phần còn thiếu:\n" + sb);
                    }

                    // 3. Ghi nợ chỉ cho khách quen
                    if (ghiNo)
                    {
                        if (!quen) throw new NghiepVuException("Chỉ khách quen mới được ghi nợ.");
                        if (tienNo <= 0 || tienNo > tong) throw new NghiepVuException("Số tiền nợ phải lớn hơn 0 và không vượt tổng tiền hóa đơn.");
                        if (string.IsNullOrWhiteSpace(lyDo)) throw new NghiepVuException("Phải nhập lý do nợ.");
                        if (ngayDuKienTra.Date < DateTime.Today) throw new NghiepVuException("Ngày dự kiến trả không được trước ngày lập phiếu.");
                    }

                    // 4. Hóa đơn + chi tiết + trừ kho phần giao ngay
                    string soHD = MaService.Tiep("HoaDon", "SoHD", "HD", 3, tx);
                    Db.Execute(tx, "INSERT INTO HoaDon(SoHD,MaKH,MaNV,NgayLap,TongTien) VALUES(@h,@k,@nv,@n,@t)",
                        Db.P("@h", soHD), Db.P("@k", maKH), Db.P("@nv", maNV), Db.P("@n", DateTime.Now), Db.P("@t", tong));
                    foreach (DongBan x in ds)
                    {
                        Db.Execute(tx, "INSERT INTO ChiTietHoaDon(SoHD,MaNGK,SoLuong,DonGia) VALUES(@h,@m,@q,@g)",
                            Db.P("@h", soHD), Db.P("@m", x.MaNGK), Db.P("@q", x.SoLuong), Db.P("@g", x.DonGia));
                        int giaoNgay = Math.Min(x.SoLuong, x.SoLuongTon);
                        if (giaoNgay > 0)
                            Db.Execute(tx, "UPDATE NuocGiaiKhat SET SoLuongTon=SoLuongTon-@q WHERE MaNGK=@m", Db.P("@q", giaoNgay), Db.P("@m", x.MaNGK));
                    }

                    string kq = "Đã lập hóa đơn " + soHD + " - tổng tiền " + tong.ToString("N0") + " đ.";

                    // 5. Phiếu hẹn cho phần thiếu
                    if (thieu.Count > 0)
                    {
                        string soPH = MaService.Tiep("PhieuHen", "SoPhieuHen", "PH", 3, tx);
                        Db.Execute(tx, "INSERT INTO PhieuHen(SoPhieuHen,SoHD,NgayHen,TrangThai) VALUES(@p,@h,@n,N'Chưa giao')",
                            Db.P("@p", soPH), Db.P("@h", soHD), Db.P("@n", ngayHen.Value.Date));
                        foreach (DongBan x in thieu)
                            Db.Execute(tx, "INSERT INTO ChiTietPhieuHen(SoPhieuHen,MaNGK,SoLuongHen) VALUES(@p,@m,@q)",
                                Db.P("@p", soPH), Db.P("@m", x.MaNGK), Db.P("@q", x.SoLuong - x.SoLuongTon));
                        kq += "\nĐã giao ngay phần có sẵn; phần thiếu hẹn giao ngày " + ngayHen.Value.ToString("dd/MM/yyyy") + " (phiếu hẹn " + soPH + ").";
                    }
                    else
                    {
                        kq += "\nĐủ hàng - đã giao ngay cho khách.";
                    }

                    // 6. Phiếu ghi nợ
                    if (ghiNo)
                    {
                        string soPN = MaService.Tiep("PhieuGhiNo", "SoPhieuNo", "PGN", 3, tx);
                        Db.Execute(tx, @"INSERT INTO PhieuGhiNo(SoPhieuNo,SoHD,MaKH,MaNV,NgayLap,SoTienNo,NgayDuKienTra,LyDo)
                                         VALUES(@p,@h,@k,@nv,@n,@t,@d,@l)",
                            Db.P("@p", soPN), Db.P("@h", soHD), Db.P("@k", maKH), Db.P("@nv", maNV), Db.P("@n", DateTime.Today),
                            Db.P("@t", tienNo), Db.P("@d", ngayDuKienTra.Date), Db.P("@l", lyDo.Trim()));
                        kq += "\nĐã lập phiếu ghi nợ " + soPN + " - " + tienNo.ToString("N0") + " đ.";
                    }

                    tx.Commit();
                    return kq;
                }
            });
        }
    }
}
