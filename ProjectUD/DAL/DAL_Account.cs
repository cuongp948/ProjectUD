using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Account
    {
        SqlConnection sql = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-IDUPMK4;Initial Catalog=QLCP;Integrated Security=True");
        public DataTable uploadAccount()
        {
            sql.Open();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWACCOUNT", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            sql.Close();
            return tableName;

        }

       
        // thêm
        public void insertAccount(string username, string displayname, string pass, int type)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_INSERTACCOUNT", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@username", username);
                sqlcm.Parameters.AddWithValue("@displayname", displayname);
                sqlcm.Parameters.AddWithValue("@pass", pass);
                sqlcm.Parameters.AddWithValue("@type", type);


                if (sqlcm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("thêm thành công");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        // xoa
        public void deleteAccount(string sname)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_DELETEACCOUNT", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@username", sname);


                if (sqlcm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("xóa thành công");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
        //sua
        public void updateAccount(string username, string displayname, string pass, int type)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_UPDATEACCOUNT", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@username", username);
                sqlcm.Parameters.AddWithValue("@displayname", displayname);
                sqlcm.Parameters.AddWithValue("@pass", pass);
                sqlcm.Parameters.AddWithValue("@type", type);


                if (sqlcm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }


        //check login
        public bool checklogin(string username,string password)
        {
                
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("CHECKLOGIN", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@username", username);
                sqlcm.Parameters.AddWithValue("@pass",password);
                sqlcm.Connection = sql;

                SqlDataReader reader = sqlcm.ExecuteReader();
                if (reader.Read())
                {
                    
                    MessageBox.Show("Đăng nhập thành công");
                    sql.Close();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                    sql.Close();
 
                }

            return false;
        }


    }
}
