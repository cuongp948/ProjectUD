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
    
    public class BUS_Menu
    {
        DAL_Menu admin = new DAL_Menu();
        public List<ET_Menu> getListmenuByTable(int position)
        {
            return admin.getListmenuByTable(position);
        }

    }
}
