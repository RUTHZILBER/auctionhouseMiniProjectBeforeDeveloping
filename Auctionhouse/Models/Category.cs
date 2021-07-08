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
    class Category
    {
        private string category_name;
        private int category_code;

        public void PutInto(DataRow dr)
        {

            dr["category_name"] = this.category_name;
            dr["category_code"] = this.category_code;
        }


        public Category()
        { }



        public string Category_name
        {
            get
            {
                return this.category_name;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    category_name = value;
                else
                    throw new Exception("הקש שנית שם קטגוריה תקינה");


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

      


        public Category(DataRow dr)
        {
            this.Category_name = dr["Category_name"].ToString();
            this.category_code =Convert.ToInt16( dr["category_code"].ToString());
 
        }
    }
}
