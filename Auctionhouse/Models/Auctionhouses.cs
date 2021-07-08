using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Auctionhouse.Data;
using Auctionhouse.Db;
using Auctionhouse.Properties;
using Auctionhouse.Utilitis;
using System.Data.OleDb;
using System.Windows.Forms;
using Auctionhouse.Gui;
using Auctionhouse.Models;
using System.Collections;


namespace Auctionhouse.Models
{
    class Auctionhouses
    {
        private int auctionhouse_code;
        private string auctionhouse_name;
        private int category_code;
        private string tel;
        private bool status;

        public void PutInto(DataRow dr)
        {
            dr["auctionhouse_code"] = this.auctionhouse_code;
            dr["auctionhouse_name"] = this.auctionhouse_name;
            dr["category_code"] = this.category_code;
            dr["tel"] = this.tel;
            dr["status"] = this.status;

        }

        public Auctionhouses(DataRow dr)
        {
            this.auctionhouse_code = Convert.ToInt32(dr["auctionhouse_code"]);
            this.auctionhouse_name = dr["auctionhouse_name"].ToString();
            this.category_code =Convert.ToInt32(dr["category_code"]);
            this.tel = dr["tel"].ToString();
            if (dr["status"].Equals(true))
                this.status = true;
            else
                this.status = false;
        }


        public Auctionhouses()
        { }


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
                    throw new Exception("הקש קוד בית מכירות תקין");


            }
        }

        public string Auctionhouse_name
        {
            get
            {
                return this.auctionhouse_name;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    auctionhouse_name = value;
                else
                    throw new Exception("הקש שנית שם בית מכירות תקין");


            }
        }

        public int Category_code
        {
            get
            {
                return this.category_code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                    category_code = value;
                else
                    throw new Exception("הקש קוד קטגוריה תקין");


            }
        }

        public string Tel
        {
            get
            {
                return this.tel;

            }
            set
            {
                if (ValidateUtilities.IsTelPhone(value))
                    tel = value;
                else
                    throw new Exception("הקש מספר טלפון תקין לבית המכירות");


            }
        }


        public bool Status
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
