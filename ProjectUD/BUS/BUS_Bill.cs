using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Bill
    {
        DAL_Bill admin = new DAL_Bill();
        public DataTable uploadBill()
        {
            return admin.uploadBill();
        }
        public void insertBill(int id, string checkin, string checkout, int idtable, int status)
        {
            admin.insertBill(id,checkin,checkout,idtable,status);
        }
        public void deleteBill(int id)
        {
            admin.deleteBill(id);
        }
        public void updateBill(int id, string checkin, string checkout, int idtable, int status)
        {
            admin.updateBill(id, checkin, checkout, idtable, status);
        }

        public int getIDBillbytable(int position)
        {
            return admin.getIDBillbytable(position);
        }
        public void insertBillByidTable(int id, int idtable)
        {
            admin.insertBillByidTable(id, idtable);
        }

        public int getIbBillMax()
        {
           return admin.getIbBillMax();
        }
        public void insertbill2(int id,int idtable)
        {
            admin.insertbill2(id,idtable);
        }
    }
}
