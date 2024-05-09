using System;
using System.Collections.Generic;
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
        public void themHopDong(DateTime ngayLapHopDong, float tongTien, float tienDatCoc, string cacDieuKhoan)
        {
            // Kết nối đến cơ sở dữ liệu
            try
            {
                _conn.Open();
                string queryInsert = ("INSERT INTO Xe (BienSo, MoTa, TinhTrang, GiaThue, MaLoaiXe, MaThuongHieu, MayLanh, CamBienLui, AC, HinhAnh) " +
                                     "VALUES (@BienSo, @MoTa, @TinhTrang, @GiaThue, @MaLoaiXe, @MaThuongHieu, @MayLanh, @CamBienLui, @AC, @HinhAnh)");
                SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);

            }
            catch (Exception ex)
            {
                // Log lỗi vào một file hoặc hiển thị thông báo lỗi cho người dùng
                Console.WriteLine("Đã xảy ra lỗi khi thêm hợp đồng: " + ex.Message);
                MessageBox.Show("Thêm xe thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { _conn.Close(); }
        }
    }
}
