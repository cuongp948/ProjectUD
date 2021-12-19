using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;

namespace DAL
{
   public class DAL_CategoryFood
    {
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-IDUPMK4;Initial Catalog=QLCP;Integrated Security=True");
        public DataTable uploadCaterogy()
        {
            sql.Open();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWCATEROGY", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            sql.Close();
            return tableName;
        
        }

        // thêm
        public void insertcategory(int id, string name)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_INSERTCATEGORY", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@name", name);
             

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



        public void deletecategory(int id)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_DELETECATEGORY", sql);
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




        public void updatecategory(int id, string name)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_UPDATECATEGORY", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@name", name);


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

        public List<ET_CategoryFood> uploadCategorylist()
        {
            sql.Open();
            List<ET_CategoryFood> listtable = new List<ET_CategoryFood>();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWCATEROGY", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            foreach (DataRow item in tableName.Rows)
            {
                ET_CategoryFood table = new ET_CategoryFood(item);
                listtable.Add(table);
            }
            sql.Close();
            return listtable;

        }


    }
}
