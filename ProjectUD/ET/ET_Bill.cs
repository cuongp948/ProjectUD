using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public class ET_Bill
    {
        private int id;
        private DateTime checkin;
        private DateTime? checkout;
        private int status;
        public ET_Bill(int id, DateTime checkin,DateTime? checkout,int status)
        {
            this.id = id;
            this.checkin = checkin;
            this.checkout = checkout;
            this.status = status;

        }
        public ET_Bill(DataRow row)
        {
            this.id =(int)row["id"];
            this.checkin = (DateTime)row["datecheckin"];

            var datecheckouttemp = row["datecheckout"];
            if(datecheckouttemp.ToString() != " ")
            {
                this.checkout = (DateTime?)datecheckouttemp;
            }
           
            this.status = (int)row["statuss"];

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

        public DateTime Checkin
        {
            get
            {
                return checkin;
            }

            set
            {
                checkin = value;
            }
        }

        public DateTime? Checkout
        {
            get
            {
                return checkout;
            }

            set
            {
                checkout = value;
            }
        }

        public int Status
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
