using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Bill
    {
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-IDUPMK4;Initial Catalog=QLCP;Integrated Security=True");
        public DataTable uploadBill()
        {
            sql.Open();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWBILL", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            sql.Close();
            return tableName;

        }


        // thêm
        public void insertBill(int id, string checkin, string checkout, int idtable, int status)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_INSERBILL", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@datecheckin", checkin);
                sqlcm.Parameters.AddWithValue("@datecheckout", checkout);
                sqlcm.Parameters.AddWithValue("@idtable", idtable);
                sqlcm.Parameters.AddWithValue("@statuss", status);
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
        public void deleteBill(int id)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_DELETEBILL", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);

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
        public void updateBill(int id, string checkin, string checkout, int idtable, int status)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_UPDATEBILL", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@datecheckin", checkin);
                sqlcm.Parameters.AddWithValue("@datecheckout", checkout);
                sqlcm.Parameters.AddWithValue("@idtable", idtable);
                sqlcm.Parameters.AddWithValue("@statuss", status);
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

        // lay ID cua bill theo bàn
        public int getIDBillbytable(int position)
        {

            // command
            SqlCommand sqlcm = new SqlCommand("GETID", sql);
            DataTable tableName = new DataTable();
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@idtable", position);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            if (tableName.Rows.Count > 0)
            {
                ET_Bill bill = new ET_Bill(tableName.Rows[0]);
                return bill.Id;
            }
            sql.Close();
            return -1;

        }

        public void insertBillByidTable(int id, int idtable)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_INSERBILLBYIDTABLE", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@idtable", idtable);

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


        public int getIbBillMax()
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("GETMAXIDBILL", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                return 0;
                
            }
            catch (Exception ex)
            {
                return 1;
            }
            finally
            {
                sql.Close();
            }
        }


        public void insertbill2(int id,int idtable)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_INSERBILL2", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@idtable", idtable);
             
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
    }
}
