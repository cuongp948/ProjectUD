using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;


namespace BUS
{
    public class BUS_BillInFo
    {
        DAL_BillInfo admin = new DAL_BillInfo();
        public List<ET_BillInfo> getlistbillinfo(int positionbill)
        {
            return admin.getlistbillinfo(positionbill);
        }

        public void insertbillinfo(int id,int idbill, int idfood, int soluong)
        {
            admin.insertbillinfo(id, idbill, idfood, soluong);
        }
        public void updatebillinfo(int id, int idbill, int idfood, int soluong)
        {
            admin.updatebillinfo(id, idbill, idfood, soluong);
        }

        public void deletebillinfo(int id)
        {
            admin.deletebillinfo(id);
        }
        public DataTable search(int id)
        {
            return admin.search(id);
        }

        public DataTable showbillinfo()
        {
            return admin.showbillinfo();
        }
    }
 
}
