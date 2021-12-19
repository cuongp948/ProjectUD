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
    public class DAL_Menu
    {
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-IDUPMK4;Initial Catalog=QLCP;Integrated Security=True");

        public List<ET_Menu> getListmenuByTable(int position)
        {
            sql.Open();
            List<ET_Menu> listmenu = new List<ET_Menu>();
            DataTable tablelistmenu = new DataTable();
            //string strsql = "Select * FROM " + tablename + "";
            SqlCommand sqlcm = new SqlCommand("PS_GETMENUBYTABLE", sql);
            sqlcm.Parameters.AddWithValue("@idtable", position);
            //sqlcm.CommandText = strsql;
            sqlcm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcm);
            adapter.Fill(tablelistmenu);
            foreach(DataRow item in tablelistmenu.Rows)
            {
                ET_Menu menu = new ET_Menu(item);
                listmenu.Add(menu);

            }
            sql.Close();
            return listmenu;

        }
    }
}

