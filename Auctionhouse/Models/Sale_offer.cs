using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auctionhouse.Data;
using Auctionhouse.Db;
using Auctionhouse.Properties;
using Auctionhouse.Utilitis;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using Auctionhouse.Gui;
using Auctionhouse.Models;


namespace Auctionhouse.Models
{
    class Sale_offer
    {
        private int sale_code;
        private string id;
        private DateTime date_;
        private DateTime tim;
        private double cost;
        public void PutInto(DataRow dr)
        {
            dr["sale_code"] = this.sale_code;
            dr["id"] = this.id;
            dr["date_"] = this.date_;
            dr["tim"] = this.tim;
            dr["cost"] = this.cost;
          
        }

        public Sale_offer(DataRow dr)
        {
            this.sale_code = Convert.ToInt32(dr["sale_code"].ToString());
            this.id = dr["id"].ToString();
            this.date_ = Convert.ToDateTime(dr["date_"]);
            this.tim = Convert.ToDateTime(dr["tim"]);
            this.cost = Convert.ToDouble(dr["cost"]);
           
        }


        public Sale_offer()
        { }


        public int Sale_code
        {
            get
            {
                return this.sale_code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                    sale_code= value;
                else
                    throw new Exception("הקש קוד תקין של מכירה");


            }
        }

        public string Id
        {
            get
            {
                return this.id;

            }
            set
            {
                if (ValidateUtilities.LegalId(value))
                   id = value;
                else
                    throw new Exception("הקש מספר זהוי תקין");


            }
        }

        public DateTime Date_
        {
            get
            {
                return this.date_;

            }
            set
            {
               date_ = value;
            }
        }


               
                    
                   
               


       

       

        public DateTime Tim
        {
            get
            {
                return this.tim;

            }
            set
            {
                
                   tim = value;
               
            }
        }

            public double Cost
           {
            get
            {
                return this.cost;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                    cost = value;
                else
                    throw new Exception("הקש מחיר תקין וודא שהסכום טרם הוצע");


            }
        }
        
    }
}
