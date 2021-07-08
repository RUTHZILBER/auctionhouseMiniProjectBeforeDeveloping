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
    class Client
    {

        private string id;
        private string fname;
        private string lname;
        private int code;
        private string address;
        private string credit;
        private int meffect;
        private int yeffect;
        private string pel;
        private bool status;

        public void PutInto(DataRow dr)
        {
            dr["id"] = this.id;
            dr["fname"] = this.fname;
            dr["lname"] = this.lname;
            dr["code"] = this.code;
            dr["address"] = this.address;
            dr["credit"] = this.credit;
            dr["meffect"] = this.meffect;
            dr["yeffect"] = this.yeffect;
            dr["pel"] = this.pel;
            dr["status"] = this.status;

        }

        public Client(DataRow dr)
        {
            this.id = dr["id"].ToString();
            this.fname = dr["fname"].ToString();
            this.lname = dr["lname"].ToString();
            this.code =Convert.ToInt32(dr["code"].ToString());
            this.address = dr["address"].ToString();
            this.credit = dr["credit"].ToString();
            this.meffect =Convert.ToInt32(dr["meffect"].ToString());
            this.yeffect = Convert.ToInt32(dr["yeffect"].ToString());
            this.pel = dr["pel"].ToString();
            if (dr["status"].Equals(true))
                this.status = true;
            else
                this.status = false;
        }


        public Client()
        { }


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
                    throw new Exception("הקש מספר זהות תקין");


            }
        }

        public string Fname
        {
            get
            {
                return this.fname;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    fname = value;
                else
                    throw new Exception("הקש שם פרטי תקין");


            }
        }

        public string Lname
        {
            get
            {
                return this.lname;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    lname = value;
                else
                    throw new Exception("הקש שם משפחה תקין");


            }
        }

        public int Code
        {
            get
            {
                return this.code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString())&&(value>9999000)&&(value<100000000))//8 ספרות 
                    code = value;
                else
                    throw new Exception("בחר קוד שעוד לא נבחר בן שמונה ספרות");


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
                if (ValidateUtilities.IsAddress(value))
                   address = value;
                else
                    throw new Exception("הקש כתבת תקינה");


            }
        }

        public string Credit
        {
            get
            {
                return this.credit;

            }
            set
            {
                if (ValidateUtilities.IsNum(value))
                    credit = value;
                else
                    throw new Exception("הקש מספר אשראי תקין");


            }
        }
        public int Meffect
        {
            get
            {
                return this.meffect;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString())&&((Convert.ToInt32(value)>0)&&((Convert.ToInt32(value) <13))))
                    meffect = value;
                else
                    throw new Exception("בחר חדש תקין");


            }
        }

        public int Yffect
        {
            get
            {
                return this.yeffect;

            }
            set
            {
                if (((value > DateTime.Today.Year) || (value == DateTime.Today.Year && meffect>DateTime.Today.Month))&& (Convert.ToInt32(value) < 2031))
                {
                    
                      yeffect = value;
                }
                    
                else
            
                    throw new Exception("בחר שנה תקינה");


            }
        }


        public string Pel
        {
            get
            {
                return this.pel;

            }
            set
            {
                if (ValidateUtilities.IsCellPhone(value))
                    pel = value;
                else
                    throw new Exception("הקש פלאפון תקין");


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
