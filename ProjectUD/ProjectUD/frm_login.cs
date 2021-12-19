using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;

namespace ProjectUD
{
    public partial class frm_login : Form
    {
        SqlConnection sql = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-IPDUPMK4;Initial Catalog=QLCP;Integrated Security=True");

        public frm_login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            login();
        }




        void login()
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            //if (login(username,password))
            //{

            //}else
            //{
            //MessageBox.Show("Tên đăng nhập hoặc mật khẩu bị sai !!!");
            //}

            if (username == "" || password == "")
            {
                checklogin(username, password);
            }
            else if (username == "")
            {
                checklogin(username, password);
            }
            else if (password == "")
            {
                checklogin(username, password);
            }

            checklogin(username, password);
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
            /*string[] arr = checklogin.Split(' ');
            Properties.Settings.Default. = arr[0];*/

            /* Main main = new Main();
             this.Hide();
             main.ShowDialog();
             this.Show();*/
        }

        void checklogin (string username,string password)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("CHECKLOGIN", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@username", username);
                sqlcm.Parameters.AddWithValue("@pass", password);
                sqlcm.Connection = sql;

                SqlDataReader reader = sqlcm.ExecuteReader();
                if (reader.Read())
                {
                   
                    Main main = new Main();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi" + ex);

            }
            finally
            {
                sql.Close();
            }
           

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
