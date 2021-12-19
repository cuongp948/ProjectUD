using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Account
    {
        DAL_Account admin = new DAL_Account();
        public DataTable hienthi()
        {
            return admin.uploadAccount();
        }

        public void insertAccount(string username, string displayname, string pass, int type)
        {
            admin.insertAccount(username,displayname,pass,type);
        }
        public void xoa(string username)
        {
            admin.deleteAccount(username);
        }

        public void sua(string username, string displayname, string pass, int type)
        {
            admin.updateAccount(username, displayname, pass, type);
        }

        public bool checklogin(string username, string password)
        {
            return admin.checklogin(username, password);
        }
    }
}
