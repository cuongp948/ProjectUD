using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BillInfo
    {
        private int id;
        private int idbill;
        private int idfood;
        private int amount;
        public ET_BillInfo(DataRow row)
        {
            this.id = (int)row["id"];
            this.idbill = (int)row["idbill"];
            this.idfood = (int)row["idfood"];
            this.amount = (int)row["amount"];

        }
        public ET_BillInfo(int id, int idbill, int idfood,int amount)
        {
            this.id = id;
            this.idbill = idbill;
            this.idfood = idfood;
            this.amount = amount;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Idbill
        {
            get
            {
                return idbill;
            }

            set
            {
                idbill = value;
            }
        }

        public int Idfood
        {
            get
            {
                return idfood;
            }

            set
            {
                idfood = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }
    }
}
