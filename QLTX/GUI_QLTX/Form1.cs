using BUS_QLTX;
using DTO_QLTX;
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
    public partial class formLogin : Form
    {
        BUS_NguoiDung busNguoiDung = new BUS_NguoiDung();
        public static NguoiDung nd = null;
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                nd = busNguoiDung.layNguoiDung(username, password);
                if (nd != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kiểm tra xem người dùng có nhấn nút "OK" không
                    if (dialogResult == DialogResult.OK)
                    {
                        Main newForm = new Main();
                        newForm.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Nhập tài khoản và mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtUsername.Text == "")
                    {
                        MessageBox.Show("Nhập tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
