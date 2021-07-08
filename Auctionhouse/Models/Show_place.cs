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
using System.Windows.Forms;
using Auctionhouse.Gui;
using Auctionhouse.Models;
using System.Collections;

namespace Auctionhouse.Models
{
 public   class Show_place
    {
        private int show_place_code;
        private int auctionhouse_code;
        private string show_place_name;
        private string address;
        private string city;
        private bool status;

        public void PutInto(DataRow dr)
        {
            dr["show_place_code"] = this.show_place_code;
            dr["show_place_name"] = this.show_place_name;
            dr["auctionhouse_code"] = this.auctionhouse_code;
            dr["address"] = this.address;
            dr["city"] = this.city;
            dr["status"] = this.status;


        }

        public Show_place(DataRow dr)
        {
            this.show_place_code = Convert.ToInt32(dr["show_place_code"]);
            this.show_place_name = dr["show_place_name"].ToString();
            this.auctionhouse_code = Convert.ToInt32(dr["auctionhouse_code"]);
            this.address = dr["address"].ToString();
            this.city = dr["city"].ToString();
            if (dr["status"].Equals(true))
              this.status = true;
            else
                this.status = false;
        }
        

        public Show_place()
        { }


        public int Show_place_code
        {
            get
            {
                return this.show_place_code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                    show_place_code = value;
                else
                    throw new Exception("הקש קוד אולם תצוגה תקין");


            }
        }


        public string Show_place_name
        {
            get
            {
                return this.show_place_name;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    show_place_name = value;
                else
                    throw new Exception("הקש שם אולם תצוגה תקין");


            }
        }
        public int Auctionhouse_code
        {
            get
            {
                return this.auctionhouse_code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                    auctionhouse_code = value;
                else
                    throw new Exception("הקש שנית קוד בית מכירות תקין");


            }
        }

        public string Address
        {
            get
            {
                return this.address;

            }
            set
            {
                if (ValidateUtilities.IsHebrewNum(value))
                    address = value;
                else
                    throw new Exception("הקש כתבת אולם תצוגה שנית");


            }
        }

        public string City
        {
            get
            {
                return this.city;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    city = value;
                else
                    throw new Exception("הקש עיר של אולם תצוגה שנית");


            }
        }
        public bool Status
        {
            get
            {
                return this.status;

            }
            set
            {
                
                  status = value;
              


            }
        }

    }
}
