using System;
using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangNuoc.Data;

namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Nhận hàng từ nhà cung ứng: mỗi đơn tối đa 3 phiếu giao (3 đợt).</summary>
    public class NhanHangService
    {
        public const int ToiDaDot = 3;

        public string MaMoi() { return MaService.Tiep("PhieuGiaoHang", "SoPhieuGiao", "PG", 3); }

        public DataTable LayDon()
        {
            return Db.Query(@"SELECT d.SoDDH,
                                     d.SoDDH + N' - ' + c.TenNCC + N' (đã giao ' + CAST((SELECT COUNT(*) FROM PhieuGiaoHang p WHERE p.SoDDH=d.SoDDH) AS NVARCHAR(5)) + N'/3 đợt)' AS HienThi
                              FROM DonDatHang d JOIN NhaCungCap c ON c.MaNCC=d.MaNCC ORDER BY d.SoDDH");
        }

        public DataTable LayTienDo(string soDDH)
        {
            return Db.Query(@"SELECT ct.MaNGK,n.TenNGK,n.DonViTinh,ct.SoLuongDat,
                                     ISNULL((SELECT SUM(g.SoLuongGiao) FROM ChiTietPhieuGiao g JOIN PhieuGiaoHang p ON p.SoPhieuGiao=g.SoPhieuGiao
                                             WHERE p.SoDDH=ct.SoDDH AND g.MaNGK=ct.MaNGK),0) AS DaGiao,
                                     ct.SoLuongDat - ISNULL((SELECT SUM(g.SoLuongGiao) FROM ChiTietPhieuGiao g JOIN PhieuGiaoHang p ON p.SoPhieuGiao=g.SoPhieuGiao
                                             WHERE p.SoDDH=ct.SoDDH AND g.MaNGK=ct.MaNGK),0) AS ConLai
                              FROM ChiTietDonDatHang ct JOIN NuocGiaiKhat n ON n.MaNGK=ct.MaNGK
                              WHERE ct.SoDDH=@s ORDER BY ct.MaNGK", Db.P("@s", soDDH));
        }

        public int SoDotDaGiao(string soDDH)
        {
            return Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM PhieuGiaoHang WHERE SoDDH=@s", Db.P("@s", soDDH)));
        }

        public DataTable LayPhieu(string soDDH)
        {
            return Db.Query("SELECT SoPhieuGiao,DotGiao,NgayGiao,SoTienPhaiTra FROM PhieuGiaoHang WHERE SoDDH=@s ORDER BY DotGiao", Db.P("@s", soDDH));
        }

        public DataTable LayChiTietPhieu(string soPhieu)
        {
            return Db.Query(@"SELECT g.MaNGK,n.TenNGK,n.DonViTinh,g.SoLuongGiao FROM ChiTietPhieuGiao g
                              JOIN NuocGiaiKhat n ON n.MaNGK=g.MaNGK WHERE g.SoPhieuGiao=@p ORDER BY g.MaNGK", Db.P("@p", soPhieu));
        }

        public KetQuaXuLy LapPhieu(string soPhieu, string soDDH, DateTime ngayGiao, decimal soTien, List<DongHang> ds)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(soPhieu) || string.IsNullOrWhiteSpace(soDDH))
                    throw new NghiepVuException("Số phiếu giao và đơn đặt hàng không được để trống.");
                if (soTien < 0) throw new NghiepVuException("Số tiền phải trả không được âm.");
                if (ds == null || ds.Count == 0) throw new NghiepVuException("Phiếu giao phải có ít nhất một mặt hàng.");
                foreach (DongHang x in ds)
                    if (x.SoLuong <= 0) throw new NghiepVuException("Số lượng giao của " + x.MaNGK + " phải lớn hơn 0.");

                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    DataTable don = Db.Query(tx, "SELECT NgayDat FROM DonDatHang WHERE SoDDH=@s", Db.P("@s", soDDH));
                    if (don.Rows.Count == 0) throw new NghiepVuException("Không tìm thấy đơn đặt hàng " + soDDH + ".");
                    if (ngayGiao.Date < Convert.ToDateTime(don.Rows[0][0]).Date)
                        throw new NghiepVuException("Ngày giao không được trước ngày đặt hàng.");

                    int dot = Convert.ToInt32(Db.Scalar(tx, "SELECT ISNULL(MAX(DotGiao),0) FROM PhieuGiaoHang WHERE SoDDH=@s", Db.P("@s", soDDH))) + 1;
                    if (dot > ToiDaDot) throw new NghiepVuException("Mỗi đơn đặt hàng chỉ được giao tối đa " + ToiDaDot + " đợt.");

                    foreach (DongHang x in ds)
                    {
                        DataTable t = Db.Query(tx, @"SELECT ct.SoLuongDat - ISNULL((SELECT SUM(g.SoLuongGiao) FROM ChiTietPhieuGiao g JOIN PhieuGiaoHang p ON p.SoPhieuGiao=g.SoPhieuGiao
                                                         WHERE p.SoDDH=ct.SoDDH AND g.MaNGK=ct.MaNGK),0) AS ConLai
                                                     FROM ChiTietDonDatHang ct WHERE ct.SoDDH=@s AND ct.MaNGK=@m",
                            Db.P("@s", soDDH), Db.P("@m", x.MaNGK));
                        if (t.Rows.Count == 0) throw new NghiepVuException("Mặt hàng " + x.MaNGK + " không thuộc đơn đặt hàng " + soDDH + ".");
                        int conLai = Convert.ToInt32(t.Rows[0][0]);
                        if (x.SoLuong > conLai)
                            throw new NghiepVuException("Mặt hàng " + x.MaNGK + ": số lượng giao (" + x.SoLuong + ") vượt số còn phải nhận (" + conLai + ").");
                    }

                    Db.Execute(tx, "INSERT INTO PhieuGiaoHang(SoPhieuGiao,SoDDH,DotGiao,NgayGiao,SoTienPhaiTra) VALUES(@p,@s,@d,@n,@t)",
                        Db.P("@p", soPhieu.Trim()), Db.P("@s", soDDH), Db.P("@d", dot), Db.P("@n", ngayGiao.Date), Db.P("@t", soTien));
                    foreach (DongHang x in ds)
                    {
                        Db.Execute(tx, "INSERT INTO ChiTietPhieuGiao(SoPhieuGiao,MaNGK,SoLuongGiao) VALUES(@p,@m,@q)",
                            Db.P("@p", soPhieu.Trim()), Db.P("@m", x.MaNGK), Db.P("@q", x.SoLuong));
                        Db.Execute(tx, "UPDATE NuocGiaiKhat SET SoLuongTon=SoLuongTon+@q WHERE MaNGK=@m", Db.P("@q", x.SoLuong), Db.P("@m", x.MaNGK));
                    }
                    tx.Commit();
                    return "Đã lập phiếu giao " + soPhieu.Trim() + " (đợt " + dot + "/" + ToiDaDot + ") và cộng " + ds.Count + " mặt hàng vào tồn kho.";
                }
            });
        }
    }
}
