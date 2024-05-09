using BUS_QLTX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLTX;

namespace GUI_QLTX
{
    public partial class TimXe : Form
    {
        BUS_LoaiXe busLoaiXe = new BUS_LoaiXe();
        BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        BUS_Xe busXe = new BUS_Xe();
        Xe xeForm = new Xe();
       
        public TimXe()
        {
            InitializeComponent();
        }

        private void TimXe_Load(object sender, EventArgs e)
        {
            DataTable listLoaiXe = busLoaiXe.layLoaiXe();
            cbLoaiXe.Items.Clear();
            cbLoaiXe.Items.Add("Tất cả");

            if (listLoaiXe != null && listLoaiXe.Rows.Count > 0)
            {
                foreach (DataRow row in listLoaiXe.Rows)
                {
                    cbLoaiXe.Items.Add(row["TenLoaiXe"].ToString());
                }
            }
            cbLoaiXe.SelectedIndex = 0;
            //----------------
            DataTable listThuongHieu = busThuongHieu.layThuongHieu();
            cbThuongHieu.Items.Clear();
            cbThuongHieu.Items.Add("Tất cả");

            if (listThuongHieu != null && listThuongHieu.Rows.Count > 0)
            {
                foreach (DataRow row in listThuongHieu.Rows)
                {
                    cbThuongHieu.Items.Add(row["TenThuongHieu"].ToString());
                }
            }
            cbThuongHieu.SelectedIndex = 0;
            //-------------------
            hienThiXe();
            
        }

        public void hienThiXe()
        {          
            fpDanhSachXe.Controls.Clear();

            if (cbLoaiXe.SelectedIndex == 0 && cbThuongHieu.SelectedIndex == 0)
            {
                DataTable listXe = busXe.layXe();
                if (listXe != null && listXe.Rows.Count > 0)
                {
                    foreach (DataRow xe in listXe.Rows)
                    {
                        XeUI xeForm = new XeUI(xe);
                        xeForm.setTimXeForm(this);
                        fpDanhSachXe.Controls.Add(xeForm);
                    }
                }
            }
            
        }
        private void btThemXe_Click(object sender, EventArgs e)
        {
            xeForm.showThemXe();
            xeForm.Owner = this;
            xeForm.setTimXeForm(this);
            xeForm.StartPosition = FormStartPosition.CenterParent;
            xeForm.Show(); 
        }

        private void cbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
