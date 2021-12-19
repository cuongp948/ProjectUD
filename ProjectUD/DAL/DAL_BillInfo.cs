using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_BillInfo
    {
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-IDUPMK4;Initial Catalog=QLCP;Integrated Security=True");

        public List<ET_BillInfo> getlistbillinfo(int positionbill)
        {
          
            List<ET_BillInfo> listbillinfo = new List<ET_BillInfo>();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_GETLISTBILLINFO", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.Parameters.AddWithValue("@idbill", positionbill);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            foreach (DataRow item in tableName.Rows)
            {
                ET_BillInfo billinfo = new ET_BillInfo(item);
                listbillinfo.Add(billinfo);
            }
            sql.Close();
            return listbillinfo;

        }


        public void insertbillinfo(int id,int idbill,int idfood,int soluong)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_THEMBILLINFO", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@idbill", idbill);
                sqlcm.Parameters.AddWithValue("@idfood", idfood);
                sqlcm.Parameters.AddWithValue("@amount", soluong);

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

        public void updatebillinfo(int id, int idbill, int idfood, int soluong)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_UPDATEBILLINFO", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@idbill", idbill);
                sqlcm.Parameters.AddWithValue("@idfood", idfood);
                sqlcm.Parameters.AddWithValue("@amount", soluong);

                if (sqlcm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("cập nhật thành công");
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

        public void deletebillinfo(int id)
        {
            try
            {
                sql.Open();
                // comman
                SqlCommand sqlcm = new SqlCommand("PS_DELETEBILLINFO", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);

                if (sqlcm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("xóa thành công");
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
        public DataTable search(int id)
        {
            DataTable table = new DataTable();
            try
            {
                sql.Open();
             
          
                SqlCommand sqlcm = new SqlCommand("SEARCHBILLINFO", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
                adapter.Fill(table);
                // command
        
           
                sqlcm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sql.Close();
            }
            return table;
            
        }
        

        public DataTable showbillinfo()
        {
            sql.Open();
            DataTable table = new DataTable();
            SqlCommand sqlcm = new SqlCommand("SHOWBILLINFO", sql);
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(table);
            sql.Close();
               return table;
        }
    }
}
