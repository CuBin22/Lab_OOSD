using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyNhanSu.Services
{
    /// <summary>Kết quả xử lý nghiệp vụ: thành công hay bị từ chối kèm thông báo (giống KetQuaXuLy trong dự án mẫu).</summary>
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }

        public static KetQuaXuLy Ok(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = true, ThongBao = thongBao };
        }

        public static KetQuaXuLy Fail(string thongBao)
        {
            return new KetQuaXuLy { ThanhCong = false, ThongBao = thongBao };
        }
    }

    /// <summary>Dịch lỗi SQL Server sang thông báo tiếng Việt dễ hiểu.</summary>
    public static class Loi
    {
        public static string Dich(Exception ex)
        {
            SqlException sql = ex as SqlException;
            if (sql == null) return ex.Message;

            // Lỗi do trigger (RAISERROR) đã có sẵn thông báo tiếng Việt.
            foreach (SqlError er in sql.Errors)
                if (er.Number == 50000) return er.Message;

            string m = sql.Message;
            if (sql.Number == 2627 || sql.Number == 2601)
            {
                if (m.Contains("UQ_QDL_NV_Ngay")) return "Nhân viên đã có quyết định lương với cùng ngày hiệu lực.";
                if (m.Contains("UQ_QDCV_NV_Ngay")) return "Nhân viên đã có quyết định chức vụ với cùng ngày hiệu lực.";
                if (m.Contains("UQ_CTPC_NV_Ngay_Ca")) return "Nhân viên đã được phân công ca này trong ngày (trong kế hoạch khác).";
                if (m.Contains("UQ_PCC_NV_Ngay_Ca")) return "Nhân viên đã được chấm công cho ca này trong ngày.";
                if (m.Contains("UQ_BL_NV_Thang_Nam")) return "Nhân viên đã có bảng lương của tháng này.";
                if (m.Contains("UQ_HSBH_NV_Loai")) return "Nhân viên đã có hồ sơ loại bảo hiểm này.";
                if (m.Contains("PRIMARY KEY")) return "Mã/số chứng từ này đã tồn tại.";
                if (m.Contains("dbo.NhanVien")) return "CCCD này đã được dùng cho nhân viên khác.";
                if (m.Contains("dbo.PhongBan")) return "Tên phòng ban đã tồn tại.";
                if (m.Contains("dbo.QuyetDinhTuyenDung")) return "Nhân viên này đã có quyết định tuyển dụng.";
                if (m.Contains("dbo.PhieuChiKhenThuong")) return "Quyết định khen thưởng này đã có phiếu chi.";
                if (m.Contains("dbo.PhieuThuNopPhat")) return "Quyết định kỷ luật này đã có phiếu thu nộp phạt.";
                return "Dữ liệu bị trùng với bản ghi đã có.";
            }
            if (sql.Number == 547)
            {
                if (m.Contains("FOREIGN KEY"))
                    return "Dữ liệu tham chiếu không tồn tại hoặc đang được sử dụng (kiểm tra nhân viên, phòng ban, hợp đồng...).";
                Match mt = Regex.Match(m, "constraint \"([^\"]+)\"");
                return "Dữ liệu không thỏa ràng buộc" + (mt.Success ? " (" + mt.Groups[1].Value + ")" : "") + ".";
            }
            return sql.Message;
        }
    }

    /// <summary>Các kiểm tra nghiệp vụ dùng chung.</summary>
    public static class KiemTra
    {
        public static bool Trong(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool CoVaiTro(string maNV, string mauVaiTro)
        {
            return Convert.ToInt32(Data.Db.Scalar("SELECT COUNT(*) FROM NhanVien WHERE MaNV=@m AND VaiTro LIKE @v",
                Data.Db.P("@m", maNV), Data.Db.P("@v", mauVaiTro))) > 0;
        }

        /// <summary>Nhân viên đã ký hợp đồng chính thức (có hợp đồng đang hiệu lực).</summary>
        public static bool CoHopDongHieuLuc(string maNV)
        {
            return Convert.ToInt32(Data.Db.Scalar("SELECT COUNT(*) FROM HopDong WHERE MaNV=@m AND TrangThai=N'Hiệu lực'",
                Data.Db.P("@m", maNV))) > 0;
        }
    }
}
