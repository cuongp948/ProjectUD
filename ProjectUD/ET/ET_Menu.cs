using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_Menu
    {
        private string food;
        private int count;
        private int totalprice;
        private int  price;
        public ET_Menu( string food,int count,int price,int totalprice = 0)
        {
            this.food = food;
            this.count = count;
            this.price = price;
            this.totalprice = totalprice;
        }
        public ET_Menu(DataRow row)
        {
            this.food = row["name"].ToString();
            this.count = (int)row["amount"]; 
            this.price = (int)row["price"];
            this.totalprice = (int)row["totalprice"];
        }
        public string Food
        {
            get
            {
                return food;
            }

            set
            {
                food = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int Totalprice
        {
            get
            {
                return totalprice;
            }

            set
            {
                totalprice = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
