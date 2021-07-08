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
    class Product
    {
        private int product_code;
        private string product_name;
        private int category_code;
        private int auctionhouse_code;
        private string picture;
        private int creature_year;
        private bool status;

        public void PutInto(DataRow dr)
        {
            dr["product_code"] = this.product_code;
            dr["product_name"] = this.product_name;
            dr["category_code"] = this.category_code;
            dr["auctionhouse_code"] = this.auctionhouse_code;
            dr["picture"] = this.picture;
            dr["creature_year"] = this.creature_year;
            dr["status"] = this.status;

        }

        public Product(DataRow dr)
        {
            this.product_code = Convert.ToInt32(dr["product_code"].ToString());
            this.product_name = dr["product_name"].ToString();
            this.category_code = Convert.ToInt32(dr["category_code"].ToString());
            this.auctionhouse_code = Convert.ToInt32(dr["auctionhouse_code"].ToString());
            this.picture = dr["picture"].ToString();
            this.creature_year = Convert.ToInt32 (dr["creature_year"]);
            if (dr["status"].Equals(true))
                this.status = true;
            else
                this.status = false;
        }


        public Product()
        { }


        public int Product_code
        {
            get
            {
                return this.product_code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                    product_code = value;
                else
                    throw new Exception("הקש קוד מוצר תקין");

            }
        }

        public string Product_name
        {
            get
            {
                return this.product_name;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    product_name = value;
                else
                    throw new Exception("הקש שם מוצר תקין");


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

        public string Picture
        {
            get
            {
                return this.picture;

            }
            set
            {
                
                    picture = value;
              


            }
        }

        public int Creature_year
        {
            get
            {
                return this.creature_year;

            }
            set
            {
                if (((value) <= Convert.ToInt32(DateTime.Today.Year))&&((value) > -3760))//המוצר יכול להמצא מהשנה הראשונה לבריאת העולם, לפי היהדות ועד ימינו. לפי מנוסים
                    creature_year = value;
                else
                    throw new Exception("הקש שנת מציאת המוצר תקינה");


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


