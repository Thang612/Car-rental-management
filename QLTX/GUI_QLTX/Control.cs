using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLTX
{
    public partial class Control : Form
    {
        static ThueXe thuexeForm = new ThueXe();
        public static void thueXe(int xeID)
        {
            thuexeForm.themXeThue(xeID);
        }
        public static void tinhTien()
        {
            thuexeForm.tinhTien();
        }

        public static void hienThiThueXe()
        {
            thuexeForm.Show();
            thuexeForm.StartPosition = FormStartPosition.CenterParent;
        }

        public Control()
        {
            InitializeComponent();
        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void btXe_Click(object sender, EventArgs e)
        {
            TimXe txForm = new TimXe();
            // Đặt form con thành không phải là form cấp cao nhất trong ứng dụng
            txForm.TopLevel = false;

            // Đặt DockStyle của form con thành Fill để lấp đầy Panel
            txForm.Dock = DockStyle.Fill;
            txForm.FormBorderStyle = FormBorderStyle.None;
            
            // Thêm form con vào Panel
            pnForm.Controls.Clear(); // Xóa các control hiện có trong Panel trước khi thêm form mới
            pnForm.Controls.Add(txForm);
            // Xác định vị trí của form trong pnForm
            int x = (pnForm.Width - txForm.Width) / 2;
            int y = (pnForm.Height - txForm.Height) / 2;

            // Đặt vị trí của form trong pnForm
            txForm.Location = new Point(x, y);
            // Hiển thị form con
            txForm.Show();
        }
    }
}
