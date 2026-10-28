using System;
using System.Data.SqlClient;

namespace QuanLyCuaHangNuoc.Services
{
    /// <summary>Lỗi nghiệp vụ (vi phạm quy tắc) - được chuyển thành thông báo cho người dùng.</summary>
    public class NghiepVuException : Exception
    {
        public NghiepVuException(string thongBao) : base(thongBao) { }
    }

    /// <summary>Kết quả xử lý: thành công hoặc nguyên nhân từ chối.</summary>
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

        /// <summary>Chạy một thao tác, bắt mọi lỗi và đổi thành KetQuaXuLy.</summary>
        public static KetQuaXuLy Chay(Func<string> hanhDong, string loiRangBuoc = null)
        {
            try
            {
                return Ok(hanhDong());
            }
            catch (NghiepVuException ex)
            {
                return Fail(ex.Message);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return Fail("Mã hoặc dữ liệu bị trùng với bản ghi đã có.");
                if (ex.Number == 547)
                    return Fail(loiRangBuoc ?? "Dữ liệu vi phạm ràng buộc toàn vẹn (khóa ngoại hoặc điều kiện kiểm tra).");
                return Fail(ex.Message);
            }
            catch (Exception ex)
            {
                return Fail(ex.Message);
            }
        }
    }
}
