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
    public class DAL_Food
    {
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-IDUPMK4;Initial Catalog=QLCP;Integrated Security=True");
        public DataTable uploadFood()
        {
            sql.Open();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWFOOD", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            sql.Close();
            return tableName;

        }
        public DataTable uploadFoodprice(int price)
        {
            sql.Open();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWFOODPRICE", sql);
            sqlcm.Parameters.AddWithValue("@price", price);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            sql.Close();
            return tableName;

        }


        // thêm
        public void insertFood(int id, string snamefood, int  intcategoryfood,int price)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_INSERTFOOD", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@name", snamefood);
                sqlcm.Parameters.AddWithValue("@idcategory", intcategoryfood);
                sqlcm.Parameters.AddWithValue("@price", price);
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
        public void deleteFood(int id)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_DELETEFOOD", sql);
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
        public void updateFood(int id, string snamefood, int intcategoryfood, int price)
        {
            try
            {
                sql.Open();
                // command
                SqlCommand sqlcm = new SqlCommand("PS_UPDATEFOOD", sql);
                sqlcm.CommandType = CommandType.StoredProcedure;
                sqlcm.Parameters.AddWithValue("@id", id);
                sqlcm.Parameters.AddWithValue("@name", snamefood);
                sqlcm.Parameters.AddWithValue("@idcategory", intcategoryfood);
                sqlcm.Parameters.AddWithValue("@price", price);

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


        public DataTable uploadFoodbyIDcategory(int idcategory)
        {
            sql.Open();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_LOADFOODGETBYIDCATEGORY", sql);
            sqlcm.Parameters.AddWithValue("@idcategory", idcategory);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            sql.Close();
            return tableName;

        }

        public List<ET_Food> getfoodcategoryID()
        {
            sql.Open();
            List<ET_Food> listtable = new List<ET_Food>();
            DataTable tableName = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_SHOWFOOD", sql);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tableName);
            foreach (DataRow item in tableName.Rows)
            {
                ET_Food table = new ET_Food(item);
                listtable.Add(table);
            }
            sql.Close();
            return listtable;

        }

    }
}
