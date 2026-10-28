using System;
using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangNuoc.Data;

namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Đơn đặt hàng gửi nhà cung ứng.</summary>
    public class DatHangService
    {
        public string MaMoi() { return MaService.Tiep("DonDatHang", "SoDDH", "DDH", 3); }

        public DataTable LayNCC()
        {
            return Db.Query("SELECT MaNCC,TenNCC FROM NhaCungCap ORDER BY MaNCC");
        }

        public DataTable LayHangTheoNCC(string maNCC)
        {
            return Db.Query("SELECT MaNGK,TenNGK,DonViTinh FROM NuocGiaiKhat WHERE MaNCC=@c ORDER BY MaNGK", Db.P("@c", maNCC));
        }

        public DataTable LayDon(string kw, DateTime tu, DateTime den)
        {
            return Db.Query(@"SELECT d.SoDDH,d.MaNCC,c.TenNCC,d.MaNV,n.HoTen AS NhanVien,d.NgayDat,d.NgayNhanDuKien,
                                     (SELECT COUNT(*) FROM PhieuGiaoHang p WHERE p.SoDDH=d.SoDDH) AS SoDotGiao
                              FROM DonDatHang d JOIN NhaCungCap c ON c.MaNCC=d.MaNCC JOIN NhanVien n ON n.MaNV=d.MaNV
                              WHERE (d.SoDDH LIKE @k OR c.TenNCC LIKE @k) AND d.NgayDat BETWEEN @tu AND @den
                              ORDER BY d.NgayDat DESC, d.SoDDH DESC",
                Db.P("@k", "%" + (kw ?? "").Trim() + "%"), Db.P("@tu", tu.Date), Db.P("@den", den.Date));
        }

        public DataTable LayChiTiet(string soDDH)
        {
            return Db.Query(@"SELECT ct.MaNGK,n.TenNGK,n.DonViTinh,ct.SoLuongDat FROM ChiTietDonDatHang ct
                              JOIN NuocGiaiKhat n ON n.MaNGK=ct.MaNGK WHERE ct.SoDDH=@s ORDER BY ct.MaNGK", Db.P("@s", soDDH));
        }

        void KiemTra(string so, string maNCC, string maNV, DateTime ngayDat, DateTime ngayNhan, List<DongHang> ds)
        {
            if (string.IsNullOrWhiteSpace(so) || string.IsNullOrWhiteSpace(maNCC) || string.IsNullOrWhiteSpace(maNV))
                throw new NghiepVuException("Số đơn, nhà cung ứng và nhân viên lập không được để trống.");
            if (ngayNhan.Date < ngayDat.Date)
                throw new NghiepVuException("Ngày nhận dự kiến không được trước ngày đặt.");
            if (ds == null || ds.Count == 0)
                throw new NghiepVuException("Đơn đặt hàng phải có ít nhất một mặt hàng.");
            foreach (DongHang x in ds)
                if (x.SoLuong <= 0) throw new NghiepVuException("Số lượng đặt của " + x.MaNGK + " phải lớn hơn 0.");
        }

        void GhiChiTiet(System.Data.SqlClient.SqlTransaction tx, string so, string maNCC, List<DongHang> ds)
        {
            foreach (DongHang x in ds)
            {
                object ncc = Db.Scalar(tx, "SELECT MaNCC FROM NuocGiaiKhat WHERE MaNGK=@m", Db.P("@m", x.MaNGK));
                if (ncc == null) throw new NghiepVuException("Không tìm thấy mặt hàng " + x.MaNGK + ".");
                if (Convert.ToString(ncc) != maNCC)
                    throw new NghiepVuException("Mặt hàng " + x.MaNGK + " không do nhà cung ứng này cung cấp.");
                Db.Execute(tx, "INSERT INTO ChiTietDonDatHang(SoDDH,MaNGK,SoLuongDat) VALUES(@s,@m,@q)",
                    Db.P("@s", so), Db.P("@m", x.MaNGK), Db.P("@q", x.SoLuong));
            }
        }

        public KetQuaXuLy LapDon(string so, string maNCC, string maNV, DateTime ngayDat, DateTime ngayNhan, List<DongHang> ds)
        {
            return KetQuaXuLy.Chay(() =>
            {
                KiemTra(so, maNCC, maNV, ngayDat, ngayNhan, ds);
                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    Db.Execute(tx, "INSERT INTO DonDatHang(SoDDH,MaNCC,MaNV,NgayDat,NgayNhanDuKien) VALUES(@s,@c,@nv,@d,@n)",
                        Db.P("@s", so.Trim()), Db.P("@c", maNCC), Db.P("@nv", maNV), Db.P("@d", ngayDat.Date), Db.P("@n", ngayNhan.Date));
                    GhiChiTiet(tx, so.Trim(), maNCC, ds);
                    tx.Commit();
                }
                return "Đã lập đơn đặt hàng " + so.Trim() + " gồm " + ds.Count + " mặt hàng.";
            });
        }

        public KetQuaXuLy CapNhatDon(string so, string maNV, DateTime ngayDat, DateTime ngayNhan, List<DongHang> ds)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(so)) throw new NghiepVuException("Chưa chọn đơn cần cập nhật.");
                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    DataTable dt = Db.Query(tx, "SELECT MaNCC FROM DonDatHang WHERE SoDDH=@s", Db.P("@s", so));
                    if (dt.Rows.Count == 0) throw new NghiepVuException("Không tìm thấy đơn " + so + ".");
                    string maNCC = Convert.ToString(dt.Rows[0][0]);
                    KiemTra(so, maNCC, maNV, ngayDat, ngayNhan, ds);
                    if (Convert.ToInt32(Db.Scalar(tx, "SELECT COUNT(*) FROM PhieuGiaoHang WHERE SoDDH=@s", Db.P("@s", so))) > 0)
                        throw new NghiepVuException("Đơn đã có phiếu giao hàng nên không được cập nhật.");
                    Db.Execute(tx, "UPDATE DonDatHang SET MaNV=@nv,NgayDat=@d,NgayNhanDuKien=@n WHERE SoDDH=@s",
                        Db.P("@nv", maNV), Db.P("@d", ngayDat.Date), Db.P("@n", ngayNhan.Date), Db.P("@s", so));
                    Db.Execute(tx, "DELETE FROM ChiTietDonDatHang WHERE SoDDH=@s", Db.P("@s", so));
                    GhiChiTiet(tx, so, maNCC, ds);
                    tx.Commit();
                }
                return "Đã cập nhật đơn đặt hàng " + so + ".";
            });
        }

        public KetQuaXuLy XoaDon(string so)
        {
            return KetQuaXuLy.Chay(() =>
            {
                if (string.IsNullOrWhiteSpace(so)) throw new NghiepVuException("Chưa chọn đơn cần xóa.");
                using (var cn = Db.MoKetNoi())
                using (var tx = cn.BeginTransaction())
                {
                    if (Convert.ToInt32(Db.Scalar(tx, "SELECT COUNT(*) FROM PhieuGiaoHang WHERE SoDDH=@s", Db.P("@s", so))) > 0)
                        throw new NghiepVuException("Đơn đã có phiếu giao hàng nên không được xóa.");
                    Db.Execute(tx, "DELETE FROM ChiTietDonDatHang WHERE SoDDH=@s", Db.P("@s", so));
                    int n = Db.Execute(tx, "DELETE FROM DonDatHang WHERE SoDDH=@s", Db.P("@s", so));
                    if (n == 0) throw new NghiepVuException("Không tìm thấy đơn " + so + ".");
                    tx.Commit();
                }
                return "Đã xóa đơn đặt hàng " + so + ".";
            });
        }
    }
}
