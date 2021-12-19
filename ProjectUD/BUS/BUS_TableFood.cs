using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using ET;

namespace BUS
{
   public class BUS_TableFood
    {
        DAL_TableFood admin = new DAL_TableFood();
        public DataTable hienthi()
        {
            return admin.uploadTableFood();
        }

        public void insertTableFood(int id, string snametable, string sstatus)
        {
            admin.insertTableFood(id, snametable, sstatus);
        }
        public void deleteTableFood(int id)
        {
            admin.deleteTableFood(id);
        }

        public void updateTableFood(int id, string snametable, string sstatus)
        {
            admin.updateTableFood(id, snametable, sstatus);
        }
        public List<ET_TableFood> uploadTableFoodlist()
        {
            return admin.uploadTableFoodlist();
        }


    }
}
