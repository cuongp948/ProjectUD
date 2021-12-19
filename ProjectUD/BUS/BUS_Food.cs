using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class BUS_Food
    {
        DAL_Food admin = new DAL_Food();
        public DataTable hienthi()
        {
            return admin.uploadFood();
        }
        public DataTable uploadFoodprice(int price)
        {
            return admin.uploadFoodprice(price);
        }
        public void insertFood(int id, string snamefood, int intcategoryfood, int price)
        {
            admin.insertFood(id, snamefood, intcategoryfood, price);
        }
        public void deleteFood(int id)
        {
            admin.deleteFood(id);
        }

        public void updateFood(int id, string snamefood, int intcategoryfood, int price)
        {
            admin.updateFood(id, snamefood, intcategoryfood, price);
        }



        public DataTable uploadFoodbyIDcategory(int idcategory)
        {
            return admin.uploadFoodbyIDcategory(idcategory);
        }
    }
}
