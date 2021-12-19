using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
   public class ET_Food
    {
        private int id;
        private string name;
        private int idcategory;
        private int price;
        public ET_Food (int id,string name,int idcategory, int price)
        {
            this.id = id;
            this.Name = name;
            this.Idcategory = idcategory;
            this.price = price;
        }
        public ET_Food()
        {

        }
        public ET_Food(DataRow row)
        {
            this.id =(int)row["id"];
            this.Name = row["name"].ToString();
            this.Idcategory = (int)row["idcategory"];
            this.price = (int)row["price"];
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

        public int Idcategory
        {
            get
            {
                return idcategory;
            }

            set
            {
                idcategory = value;
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
    }
}
