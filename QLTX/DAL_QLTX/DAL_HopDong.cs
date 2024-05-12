using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLTX
{
    public class DAL_HopDong:DBConnect
    {
        public void themHopDong(DateTime ngayLapHopDong, float tongTien, float tienDatCoc, string cacDieuKhoan, int maKhachHang, HashSet<ChiTietHopDong>dsChiTIet)
        {
            // Kết nối đến cơ sở dữ liệu
            try
            {
                _conn.Open();
                string queryInsert = ("INSERT INTO HopDong(NgayLaphopDong, TongTien, TienDatCoc, CacDieuKhoan, MaKhachHang)"+
                                    "VALUES(@NgayLapHopDong, @TongTien, @TienDatCoc, @CacDieuKhoan, @MaKhachHang); ");
                SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);
                commandInsert.Parameters.AddWithValue("@NgayLapHopDong", ngayLapHopDong);
                commandInsert.Parameters.AddWithValue("@TongTien", tongTien);
                commandInsert.Parameters.AddWithValue("@TienDatCoc", tienDatCoc);
                commandInsert.Parameters.AddWithValue("@cacDieuKhoan", cacDieuKhoan);
                commandInsert.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                commandInsert.ExecuteNonQuery();
                string queryScope = "SELECT MAX(MaHopDong) FROM HopDong";
                SqlCommand commandScope = new SqlCommand(queryScope, _conn);
                int hopDongId = Convert.ToInt32(commandScope.ExecuteScalar());

                MessageBox.Show("Thêm hợp đồng thành công!" + hopDongId, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach(var chitiet in dsChiTIet)
                {
                    themChiTietHopDong(hopDongId, chitiet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hợp đồng thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { _conn.Close(); }
        }

        public void themChiTietHopDong(int idHopDong, ChiTietHopDong chiTiet)
        {
            string queryInsert = ("INSERT INTO ChiTietHopDong(NgayKhoiHanh, NgayKetThuc, MaXe, MaHopDong) " +
                "VALUES(@NgayBatDau, @NgayKetThuc, @MaXe, @MaHopDong); ");
            SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);
            commandInsert.Parameters.AddWithValue("@NgayBatDau", chiTiet.NgayKhoiHanh);
            commandInsert.Parameters.AddWithValue("@NgayKetThuc", chiTiet.NgayKetThuc);
            commandInsert.Parameters.AddWithValue("@MaXe", chiTiet.MaXe);
            commandInsert.Parameters.AddWithValue("@MaHopDong", idHopDong);
            commandInsert.ExecuteNonQuery();
        }

        public bool kiemtraDate(int maXe, DateTime ngay)
        {

            try
            {
                _conn.Open();
                string query = "SELECT COUNT(*) FROM ChiTietHopDong WHERE MaXe = @MaXe AND @ngay BETWEEN NgayKhoiHanh AND NgayKetThuc";

                SqlCommand cmd = new SqlCommand(query, _conn);

                cmd.Parameters.AddWithValue("@MaXe", maXe);
                cmd.Parameters.AddWithValue("@ngay", ngay);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally { _conn.Close(); }
        }


        
    }
}
