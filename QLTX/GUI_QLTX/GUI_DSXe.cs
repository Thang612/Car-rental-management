using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLTX;

namespace GUI_QLTX
{
    public partial class GUI_DSXe : Form
    {
        BUS_LoaiXe busLoaiXe = new BUS_LoaiXe();
        BUS_Xe busXe = new BUS_Xe();
        public GUI_DSXe()
        {
            InitializeComponent();
        }

        private void GUI_DSXe_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ busLoaiXe
            DataTable dtLoaiXe = busLoaiXe.layLoaiXe();

            // Thêm một dòng mới vào đầu DataTable với giá trị "Tất cả"
            DataRow dr = dtLoaiXe.NewRow();
            dr["TenLoaiXe"] = "Tất cả";
            dtLoaiXe.Rows.InsertAt(dr, 0);

            // Gán DataTable đã chỉnh sửa vào ComboBox
            cbLoaiXe.DataSource = dtLoaiXe;
            cbLoaiXe.DisplayMember = "TenLoaiXe";

            // Chọn mục "Tất cả" làm mặc định
            cbLoaiXe.SelectedIndex = 0;

            // Lấy dữ liệu từ busXe và hiển thị lên DataGridView
            DataTable dtXe = busXe.layXe();
            dgvDSXe.DataSource = dtXe;
        }

        private void btnSearchBienSo_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Nhập biển số cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dtXe = null;
                if (cbLoaiXe.Text == "Tất cả")
                {
                    dtXe = busXe.layXe(txtSearch.Text);
                }
                else
                {
                    dtXe = busXe.layXe(txtSearch.Text, cbLoaiXe.Text);
                }
                dgvDSXe.DataSource = dtXe;
            }
            
        }

        private void cbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtXe = null;
            if (cbLoaiXe.Text == "Tất cả")
            {
                dtXe = busXe.layXe();
            }
            else
            {
                dtXe = busXe.layXe(txtSearch.Text, cbLoaiXe.Text);
            }
            dgvDSXe.DataSource = dtXe;
        }
    }
}
