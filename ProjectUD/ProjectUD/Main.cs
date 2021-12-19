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
using ET;
using System.Globalization;

namespace ProjectUD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            loadTable();
            loadcategoryfood();
            
        }

        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            //this.Hide();
            admin.ShowDialog();
            //this.Show();
           
          
        }

        public void loadTable()
        {
            BUS_TableFood admin = new BUS_TableFood();
            List<ET_TableFood> listtable = admin.uploadTableFoodlist();
            
            foreach(ET_TableFood table in listtable)
            {
                Button btn = new Button()
                {
                    Width = 75,
                    Height = 75
                };
                btn.Text = table.Name + Environment.NewLine + table.Status; 
                
                // click vào button để hiển thị bill của bàn đó
                btn.Click += btn_Click;
                // lưu vị trí tại bàn được click
                btn.Tag = table;
                if(table.Status == "Chưa có khách")
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.LightGreen;
                }
                flptable.Controls.Add(btn);
                
            }
                   
        }

        void btn_Click(object sender,EventArgs e)
        {
            // lấy được vị trí của bàn để hiển thị lên listview
            int position = ((sender as Button).Tag as ET_TableFood).ID;
            // lưu table vào listview
            lvBill.Tag = (sender as Button).Tag;
            showbill(position);
        }
        void showbill(int position)
        {
            lvBill.Items.Clear();
          
            BUS_BillInFo admin = new BUS_BillInFo();
            BUS_Bill bill = new BUS_Bill();
            BUS_Menu menu = new BUS_Menu();
            //admin.getlistbillinfo(bill.getIDBillbytable(position));
            List<ET_Menu> listmenu = menu.getListmenuByTable(position);
            //List<ET_BillInfo> listbillinfo = admin.getlistbillinfo(bill.getIDBillbytable(position));
            int totalprice = 0;
            foreach (ET_Menu menu1 in listmenu)
            {
                ListViewItem lvitem = new ListViewItem(menu1.Food.ToString());
                lvitem.SubItems.Add(menu1.Count.ToString());
                lvitem.SubItems.Add(menu1.Price.ToString());
                lvitem.SubItems.Add(menu1.Totalprice.ToString());

                totalprice += menu1.Totalprice;
                lvBill.Items.Add(lvitem);
            }
            CultureInfo cultu = new CultureInfo("vi-VN");


            lbtongtien.Text = totalprice.ToString("c",cultu);

        }



        private void loadcategoryfood()
        {
            BUS_CategoryFood admin = new BUS_CategoryFood();
            cbcategoryfood.DataSource = admin.hienthi();
            cbcategoryfood.DisplayMember = "name";
        }
        private void loadfoodByidcategory(int idCategoryfood)
        {
            BUS_Food admin = new BUS_Food();
            cbfood.DataSource = admin.uploadFoodbyIDcategory(idCategoryfood);
            cbfood.DisplayMember = "name";
        }

        private void cbcategoryfood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbcategoryfood.SelectedItem == null)
            {
                return;
            }
            loadfoodByidcategory(cbcategoryfood.SelectedIndex + 1);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
        }
        void them()
        {
            BUS_Bill bill = new BUS_Bill();
            BUS_BillInFo billinfo = new BUS_BillInFo();
            ET_Food food = new ET_Food();
            // lấy table hiện tại
            ET_TableFood table = lvBill.Tag as ET_TableFood;
            int thamsoidbill = 1;
            int thamsoidbillinfo = 4;
            int idfood = (cbfood.SelectedItem as ET_Food).Id;
            int idbill = bill.getIDBillbytable(table.ID);
            int soluong = (int)nbcount.Value;
            // nếu chưa có bill
            if (idbill == -1)
            {
                bill.insertbill2(thamsoidbill, table.ID);
                billinfo.insertbillinfo(thamsoidbillinfo, bill.getIbBillMax(), idfood, soluong);

            }
            // nếu bill đã có 
            else
            {
                billinfo.insertbillinfo(thamsoidbillinfo, idbill, idfood, soluong);

            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongtin thongtin = new frmthongtin();
            thongtin.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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

        private void searchBillInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBillInfo search = new SearchBillInfo();
            search.ShowDialog();
        }
    }
}
