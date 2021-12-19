using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace ProjectUD
{
    public partial class SearchBillInfo : Form
    {
        public SearchBillInfo()
        {
            InitializeComponent();
        }

        private void search ()
        {
            int ikey = int.Parse(txtMabillnfo.Text);
            BUS_BillInFo admin = new BUS_BillInFo();
            dgvresult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvresult.DataSource = admin.search(ikey);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void SearchBillInfo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
