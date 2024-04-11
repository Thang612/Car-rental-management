using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTX
{
    public class DAL_NguoiDung:DBConnect
    {
        public NguoiDung layNguoiDung (string username, string password)
        {
            NguoiDung nguoiDung = null;

            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM NguoiDung WHERE TaiKhoan = '{0}' AND MatKhau = '{1}'", username,password);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nguoiDung = new NguoiDung
                    {
                        MaNguoiDung = (int)reader[0],
                        TenNguoiDung = (string)reader[1],
                        TaiKhoan = (string)reader[2],
                        MatKhau = (string)reader[3]
                    };
                }

                reader.Close();
            }
            catch (Exception e)
            {
                // Ghi log hoặc xử lý ngoại lệ
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }

            return nguoiDung;
        }
    }
}
