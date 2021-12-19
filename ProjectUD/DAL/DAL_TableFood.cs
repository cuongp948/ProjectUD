using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ET;

namespace DAL
{
    public class DAL_TableFood
    {
        public static int tableWidth = 50;
        public static int tableHeight = 50;
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-IDUPMK4;Initial Catalog=QLCP;Integrated Security=True");
        public DataTable uploadTableFood()
        {
            sql.Open();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWTABLEFOOD", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            sql.Close();
            return tableName;

        }

        // thêm
        public void insertTableFood(int id, string snametable, string sstatus)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_INSERTTABLEFOOD", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@name", snametable);
                sqlcm.Parameters.AddWithValue("@statuss", sstatus);
              


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
        public void deleteTableFood(int id)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_DELETETABLEFOOD", sql);
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
        public void updateTableFood(int id, string snametable, string sstatus)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_UPDATETABLEFOOD", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@name", snametable);
                sqlcm.Parameters.AddWithValue("@statuss", sstatus);


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

        // lay ID cua bill
      


        
        public List<ET_TableFood> uploadTableFoodlist()
        {
            sql.Open();
            List<ET_TableFood> listtable = new List<ET_TableFood>();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWTABLEFOOD", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            foreach (DataRow item in tableName.Rows)
            {
                ET_TableFood table = new ET_TableFood(item);
                listtable.Add(table);
            }
            sql.Close();
            return listtable;

        }
    }
}
