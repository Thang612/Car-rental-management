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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        GUI_DSXe gui_DSXe = null;
        private void danhSáchXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gui_DSXe == null)
            {
                gui_DSXe = new GUI_DSXe();
                gui_DSXe.MdiParent = this;
                gui_DSXe.Show();
            }
        }
    }
}
