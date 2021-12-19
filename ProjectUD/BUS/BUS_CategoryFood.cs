using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CategoryFood
    {
        DAL_CategoryFood admin = new DAL_CategoryFood();
        public DataTable hienthi()
        {
           return admin.uploadCaterogy();
        }
        public void them(int id, string name)
        {
            admin.insertcategory(id, name);
        }
        public void xoa(int id)
        {
            admin.deletecategory(id);
        }

        public void sua(int id, string name)
        {
            admin.updatecategory(id, name);
        }

    }
}
