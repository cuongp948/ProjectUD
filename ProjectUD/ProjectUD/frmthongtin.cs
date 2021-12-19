using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUD
{
    public partial class frmthongtin : Form
    {
        public frmthongtin()
        {
            InitializeComponent();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fr = new frmDoiMatKhau();
            fr.ShowDialog();
        }

        private void frmthongtin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fr = MessageBox.Show("bạn có muốn thoát hay không ", "Thông báo",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (fr == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
