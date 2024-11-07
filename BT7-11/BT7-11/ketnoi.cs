using System;
using System.Data;
using System.Data.SqlClient;

namespace BT7_11
{
    class KetNoi
    {
        string conStr = @"Data Source=NHAT\SQLEXPRESS;Initial Catalog=Simthe;Integrated Security=True";

        // Hàm kiểm tra kết nối
        public bool KiemTraKetNoi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();  // Thử mở kết nối
                    return true;  // Nếu kết nối thành công, trả về true
                }
            }
            catch (Exception ex)
            {
                // In ra lỗi chi tiết nếu kết nối không thành công
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
                return false;  // Nếu có lỗi, trả về false
            }
        }

        // Hàm lấy dữ liệu
        public DataSet LayDuLieu(string truyvan)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(truyvan, conn))
                    {
                        da.Fill(ds);
                    }
                }
                return ds;
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc thông báo lỗi chi tiết
                Console.WriteLine("Lỗi khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }

        // Phương thức thực thi câu lệnh SQL (Insert, Update, Delete)
        public bool ThucThi(string truyvan)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(truyvan, conn))
                    {
                        int r = cmd.ExecuteNonQuery();
                        return r > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi hoặc thông báo lỗi chi tiết
                Console.WriteLine("Lỗi khi thực thi câu lệnh: " + ex.Message);
                return false;
            }
        }
    }
}
