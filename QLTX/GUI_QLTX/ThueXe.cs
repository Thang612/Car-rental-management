using BUS_QLTX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace GUI_QLTX
{
    public partial class ThueXe : Form
    {
        BUS_Xe busXe = new BUS_Xe();
        private HashSet<int> dsIDXe = new HashSet<int>();
        public void themXeThue (int xeID)
        {
            dsIDXe.Add(xeID);
            fpDSXe.Controls.Clear();
            foreach (int item in dsIDXe)
            {
                XeUI xeUI = new XeUI();
                xeUI.hienThi(item);
                fpDSXe.Controls.Add(xeUI);
            }
        }

        public void tinhTien()
        {
            TimeSpan difference = dtNgayTra.Value.Subtract(dtNgayLay.Value);

            int day = difference.Days+1;

            int total = 0; 
            fpTinhTien.Controls.Clear();
            foreach (int xeID in dsIDXe)
            {
                DTO_QLTX.Xe xe = busXe.LayXeTheoID(xeID);
                Label lb = new Label();
                lb.Text = string.Format("{0} : {1} đ * {2}= {3} đ", xe.BienSo, xe.GiaThue, day, day* xe.GiaThue);
                lb.AutoSize = true;
                fpTinhTien.Controls.Add(lb);
                total += day * (int)xe.GiaThue;
            }
            lbTongTien.Text = total.ToString() + " đ";
        }
        public ThueXe()
        {
            InitializeComponent();
        }

        private void ThueXe_Load(object sender, EventArgs e)
        {
            tinhTien();
            fpDSXe.Controls.Clear();
            foreach (int item in dsIDXe)
            {
                XeUI xeUI = new XeUI();
                xeUI.hienThi(item);
                fpDSXe.Controls.Add(xeUI);
            }
        }

        private void dtNgayLay_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = dtNgayTra.Value.Subtract(dtNgayLay.Value);

            int day = difference.Days;
            TimeSpan differenceNow = dtNgayLay.Value.Subtract(DateTime.Now);

            int dayNow = differenceNow.Days;
            if (day < 0 || dayNow < 0)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Đặt giá trị ngày lấy xe thành ngày trước đó (ví dụ: ngày hiện tại)
                dtNgayLay.Value = DateTime.Now;
                return;
            }
            tinhTien();
        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = dtNgayTra.Value.Subtract(dtNgayLay.Value);
            int day = difference.Days;

            if (day < 0)
            {
                MessageBox.Show("Ngày trả xe không thể trước ngày lấy xe!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Đặt giá trị ngày trả xe thành ngày lấy xe
                dtNgayTra.Value = dtNgayLay.Value;
                return; // Dừng thực thi phương thức để người dùng có thể chỉnh sửa ngày trả xe
            }

            tinhTien();
        }

    }
}
