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
    public partial class Admin : Form
    {

        public Admin()
        {
            InitializeComponent();
            uploadBillinfo();

        }



        // Category
        private void uploadCategory()
        {
            BUS_CategoryFood admin = new BUS_CategoryFood();
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.DataSource = admin.hienthi();
            cbcategoryfood.DataSource = admin.hienthi();
            cbcategoryfood.DisplayMember = "name";
            cbcategoryfood.ValueMember = "id";
        }
        private void btnXemcategpry_Click(object sender, EventArgs e)
        {
            uploadCategory();
        }

        private void themCategory()
        {
            if (txtIDcategory.Text == string.Empty || txtnameCategory.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                BUS_CategoryFood admin = new BUS_CategoryFood();
                int id = int.Parse(txtIDcategory.Text);
                admin.them(id, txtnameCategory.Text);
                uploadCategory();
                txtIDcategory.Clear();
                txtnameCategory.Clear();
                txtIDcategory.Focus();
            }

        }

        private void btnThemcategpry_Click(object sender, EventArgs e)
        {
            themCategory();
        }

        private void xoaCategory()
        {

            BUS_CategoryFood admin = new BUS_CategoryFood();
            int id = int.Parse(txtIDcategory.Text);
            admin.xoa(id);
            uploadCategory();
            txtIDcategory.Clear();
            txtnameCategory.Clear();
            txtIDcategory.Focus();



        }

        private void btnXoacategpry_Click(object sender, EventArgs e)
        {
            xoaCategory();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDcategory.Text = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnameCategory.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void suaCategory()
        {
            BUS_CategoryFood admin = new BUS_CategoryFood();
            int id = int.Parse(txtIDcategory.Text);
            admin.sua(id, txtnameCategory.Text);

            txtIDcategory.Clear();
            txtnameCategory.Clear();
            txtIDcategory.Focus();
        }

        private void btnSuacategpry_Click(object sender, EventArgs e)
        {
            suaCategory();
        }


        // Account
        private void uploadAccount()
        {
            BUS_Account admin = new BUS_Account();
            dgvaccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvaccount.DataSource = admin.hienthi();
        }

        private void btnxemaccount_Click(object sender, EventArgs e)
        {
            uploadAccount();
        }

        private void themacccout()
        {
            BUS_Account admin = new BUS_Account();
            int type = 0;
            if (cbtype.SelectedIndex == 0)
            {
                type = int.Parse(cbtype.Text);
            }
            else
            {
                type = int.Parse(cbtype.Text);
            }
            admin.insertAccount(txtusername.Text, txtdisplayname.Text, txtpass.Text, type);
            uploadAccount();
            txtusername.Clear();
            txtdisplayname.Clear();
            txtpass.Clear();
            cbtype.ResetText();
            txtusername.Focus();
        }

        private void btnthemaccount_Click(object sender, EventArgs e)
        {
            themacccout();

        }
        private void xoaAccount()
        {
            BUS_Account admin = new BUS_Account();
            admin.xoa(txtusername.Text);
            uploadAccount();
        }

        private void btnxoaaccount_Click(object sender, EventArgs e)
        {
            xoaAccount();
        }

        private void dgvaccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = dgvaccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdisplayname.Text = dgvaccount.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpass.Text = dgvaccount.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbtype.Text = dgvaccount.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void suaAccount()
        {
            BUS_Account admin = new BUS_Account();
            int type = 0;
            if (cbtype.SelectedIndex == 0)
            {
                type = int.Parse(cbtype.Text);
            }
            else
            {
                type = int.Parse(cbtype.Text);
            }
            admin.sua(txtusername.Text, txtdisplayname.Text, txtpass.Text, type);
            uploadAccount();
            txtusername.Clear();
            txtdisplayname.Clear();
            txtpass.Clear();
            cbtype.ResetText();
            txtusername.Focus();
        }

        private void btnsuaaccount_Click(object sender, EventArgs e)
        {
            suaAccount();
        }



        //TABLE FOOD
        private void uploadTableFood()
        {
            BUS_TableFood admin = new BUS_TableFood();
            dgvtable.DataSource = admin.hienthi();
            dgvtable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbtable.DataSource = admin.hienthi();
            cbtable.DisplayMember = "name";
            cbtable.ValueMember = "id";

        }

        private void btnxemtable_Click(object sender, EventArgs e)
        {
            uploadTableFood();
        }

        private void themTableFood()
        {
            if (txtnametable.Text == string.Empty || txtidtable.Text == string.Empty || cbstatus.Text == string.Empty)
            {
                MessageBox.Show("nhập đẩy đủ thông tin");
            }
            else
            {
                BUS_TableFood admin = new BUS_TableFood();

                int idtablefood = int.Parse(txtidtable.Text);
                string status = "";
                if (cbstatus.SelectedIndex == 0)
                {
                    status = cbstatus.Text;
                }
                else
                {
                    status = cbstatus.Text;
                }
                admin.insertTableFood(idtablefood, txtnametable.Text, status);
                uploadTableFood();

                txtnametable.Clear();
                txtidtable.Clear();
                cbstatus.ResetText();
                txtidtable.Focus();
            }

        }

        private void btnthemtable_Click(object sender, EventArgs e)
        {
            themTableFood();
        }

        private void dgvtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidtable.Text = dgvtable.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnametable.Text = dgvtable.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbstatus.Text = dgvtable.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void xoaTableFood()
        {
            BUS_TableFood admin = new BUS_TableFood();
            int idtable = int.Parse(txtidtable.Text);
            admin.deleteTableFood(idtable);
            uploadTableFood();
        }

        private void btnxoatable_Click(object sender, EventArgs e)
        {
            xoaTableFood();
        }

        private void suaTableFood()
        {
            BUS_TableFood admin = new BUS_TableFood();
            int idtablefood = int.Parse(txtidtable.Text);
            string status = "";
            if (cbstatus.SelectedIndex == 0)
            {
                status = cbstatus.Text;
            }
            else
            {
                status = cbstatus.Text;
            }
            admin.updateTableFood(idtablefood, txtnametable.Text, status);
            uploadTableFood();
            txtnametable.Clear();
            txtidtable.Clear();
            cbstatus.ResetText();
            txtidtable.Focus();
        }

        private void btnsuatable_Click(object sender, EventArgs e)
        {
            suaTableFood();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                uploadCategory();
                uploadAccount();
                uploadTableFood();
                uploadFood();
                uploadBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi: " + ex);
            }

        }


        // FOOD

        private void uploadFood()
        {
            BUS_Food admin = new BUS_Food();
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvFood.DataSource = admin.hienthi();
        }

        private void btxemFood_Click(object sender, EventArgs e)
        {
            uploadFood();
        }

        private void themFood()
        {
            if (txtidfood.Text == string.Empty || txtnamefood.Text == string.Empty || cbcategoryfood.Text == string.Empty || txtprice.Text == string.Empty)
            {
                MessageBox.Show("nhập đầy đủ thông tin");
            }
            else
            {
                BUS_Food admin = new BUS_Food();
                int idfood = int.Parse(txtidfood.Text);
                int idcategory = int.Parse(cbcategoryfood.SelectedValue.ToString());
                int price = int.Parse(txtprice.Text);

                admin.insertFood(idfood, txtnamefood.Text, idcategory, price);

                txtidfood.Clear();
                txtnamefood.Clear();
                cbcategoryfood.ResetText();
                txtprice.Clear();

                txtidfood.Focus();
            }


        }

        private void btnthemfood_Click(object sender, EventArgs e)
        {
            themFood();
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidfood.Text = dgvFood.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnamefood.Text = dgvFood.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbcategoryfood.SelectedValue = dgvFood.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtprice.Text = dgvFood.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void xoaFood()
        {
            BUS_Food admin = new BUS_Food();
            int idfood = int.Parse(txtidfood.Text);
            admin.deleteFood(idfood);
            uploadFood();
        }

        private void btnXoaFood_Click(object sender, EventArgs e)
        {
            xoaFood();
        }

        private void suafood()
        {
            BUS_Food admin = new BUS_Food();
            int idfood = int.Parse(txtidfood.Text);
            int idcategory = int.Parse(cbcategoryfood.SelectedValue.ToString());
            int price = int.Parse(txtprice.Text);

            admin.updateFood(idfood, txtnamefood.Text, idcategory, price);

            uploadFood();
            txtidfood.Clear();
            txtnamefood.Clear();
            cbcategoryfood.ResetText();
            txtprice.Clear();

            txtidfood.Focus();
        }

        private void btnSuaFood_Click(object sender, EventArgs e)
        {
            suafood();
        }


        // BILL

        private void uploadBill()
        {
            BUS_Bill admin = new BUS_Bill();
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBill.DataSource = admin.uploadBill();
        }

        private void btnxembill_Click(object sender, EventArgs e)
        {
            uploadBill();
        }
        private void themBill()
        {
            if (txtidbill.Text == string.Empty || dtpcheckin.Text == string.Empty
                || dtpcheckout.Text == string.Empty || cbtable.Text == string.Empty || cbstatusbill.Text == string.Empty)
            {
                MessageBox.Show("nhập đẩy đủ thông tin");
            }
            else
            {
                int idbill = int.Parse(txtidbill.Text);
                int idtable = int.Parse(cbtable.SelectedValue.ToString());

                int sstatus = 0;
                if (cbstatusbill.SelectedIndex == 0)
                {
                    sstatus = int.Parse(cbstatusbill.Text);
                }
                else
                {
                    sstatus = int.Parse(cbstatusbill.Text);
                }

                BUS_Bill admin = new BUS_Bill();
                admin.insertBill(idbill, dtpcheckin.Text, dtpcheckout.Text, idtable, sstatus);
                uploadBill();
                txtidbill.Clear();
                dtpcheckin.ResetText();
                dtpcheckout.ResetText();
                cbtable.ResetText();
                cbstatusbill.ResetText();
                txtidbill.Focus();
            }

        }

        private void btnthembill_Click(object sender, EventArgs e)
        {
            themBill();
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidbill.Text = dgvBill.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpcheckin.Text = dgvBill.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpcheckout.Text = dgvBill.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbtable.SelectedValue = dgvBill.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbstatusbill.Text = dgvBill.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void xoaBill()
        {
            BUS_Bill admin = new BUS_Bill();
            int idbill = int.Parse(txtidbill.Text);
            admin.deleteBill(idbill);
            txtidbill.Clear();
            dtpcheckin.ResetText();
            dtpcheckout.ResetText();
            cbtable.ResetText();
            cbstatusbill.ResetText();
            txtidbill.Focus();

        }

        private void btnxoabill_Click(object sender, EventArgs e)
        {
            xoaBill();
            uploadBill();
        }


        private void updateBill()
        {
            int idbill = int.Parse(txtidbill.Text);
            int idtable = int.Parse(cbtable.SelectedValue.ToString());

            int sstatus = 0;
            if (cbstatusbill.SelectedIndex == 0)
            {
                sstatus = int.Parse(cbstatusbill.Text);
            }
            else
            {
                sstatus = int.Parse(cbstatusbill.Text);
            }

            BUS_Bill admin = new BUS_Bill();
            admin.updateBill(idbill, dtpcheckin.Text, dtpcheckout.Text, idtable, sstatus);
            uploadBill();
            txtidbill.Clear();
            dtpcheckin.ResetText();
            dtpcheckout.ResetText();
            cbtable.ResetText();
            cbstatusbill.ResetText();
            txtidbill.Focus();
        }

        private void btncapnhatbill_Click(object sender, EventArgs e)
        {
            updateBill();
        }



        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportCategory report = new ReportCategory();
            report.ShowDialog();

        }

        private void btnInFood_Click(object sender, EventArgs e)
        {
            ReportFoodPrice report = new ReportFoodPrice();
            report.ShowDialog();

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
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



        // bill info 

        private void uploadBillinfo()
        {
            BUS_BillInFo admin = new BUS_BillInFo();
            dgvbillinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbillinfo.DataSource = admin.showbillinfo();
        }

        private void thembillinfo()
        {
            if(txtidbillinfo.Text  == string.Empty || txtidbillbillinfo.Text == string.Empty||
                txtidfoodbillinfo.Text == string.Empty || txtamount.Text == string.Empty)
            {
                MessageBox.Show("nhập đầy đủ thông tin");
                
            }
            else
            {
                int id = int.Parse(txtidbillinfo.Text);

                int idbill = int.Parse(txtidbillbillinfo.Text);
                int idfood = int.Parse(txtidfoodbillinfo.Text);
                int iamount = int.Parse(txtamount.Text);

                BUS_BillInFo admin = new BUS_BillInFo();
                admin.insertbillinfo(id, idbill, idfood, iamount);
                uploadBillinfo();
                txtidbillinfo.Clear();
                txtidbillbillinfo.Clear();
                txtidfoodbillinfo.Clear();
                txtamount.Clear();
                txtidbillinfo.Focus();
            }
         



        }

        private void btnthembillinfo_Click(object sender, EventArgs e)
        {
            thembillinfo();

        }

        private void dgvbillinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidbillinfo.Text = dgvbillinfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtidbillbillinfo.Text = dgvbillinfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtidfoodbillinfo.Text = dgvbillinfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtamount.Text = dgvbillinfo.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void suabillinfo()
        {
            int id = int.Parse(txtidbillinfo.Text);

            int idbill = int.Parse(txtidbillbillinfo.Text);
            int idfood = int.Parse(txtidfoodbillinfo.Text);
            int iamount = int.Parse(txtamount.Text);

            BUS_BillInFo admin = new BUS_BillInFo();
            admin.updatebillinfo(id, idbill, idfood, iamount);
            uploadBillinfo();
            txtidbillinfo.Clear();
            txtidbillbillinfo.Clear();
            txtidfoodbillinfo.Clear();
            txtamount.Clear();
            txtidbillinfo.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uploadBillinfo();
        }

        private void btnsuabillinfo_Click(object sender, EventArgs e)
        {
            suabillinfo();
        }
        private void deltebillinfo()
        {
            int id = int.Parse(txtidbillinfo.Text);
            BUS_BillInFo admin = new BUS_BillInFo();
            admin.deletebillinfo(id);
            uploadBillinfo();
            txtidbillinfo.Clear();
            txtidbillbillinfo.Clear();
            txtidfoodbillinfo.Clear();
            txtamount.Clear();
            txtidbillinfo.Focus();
        }

        private void btnxoabillinfo_Click(object sender, EventArgs e)
        {
            deltebillinfo();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
