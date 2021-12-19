using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TableFood
    {
        private int iD;
        private string name;
        private string status;

        public ET_TableFood(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = row["statuss"].ToString();
        }
        public ET_TableFood(int id, string name,string status)
        {
            this.iD = id;
            this.name = name;
            this.status = status;
        }
        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
