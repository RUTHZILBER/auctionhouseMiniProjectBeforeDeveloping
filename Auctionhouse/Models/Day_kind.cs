using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;
using Auctionhouse.Data;
using Auctionhouse.Db;
using Auctionhouse.Properties;
using Auctionhouse.Utilitis;
using Auctionhouse.Gui;
using Auctionhouse.Models;
using System.Data;

namespace Auctionhouse.Models
{
    class Day_kind
    {
        private int day_kind_code;
        private string name_day;


        public void PutInto(DataRow dr)
        {

            dr["day_kind_code"] = this.day_kind_code;
            dr["name_day"] = this.name_day;
        }


        public Day_kind()
        { }



        public int Day_kind_code
        {
            get
            {
                return this.day_kind_code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                    day_kind_code = value;
                else
                    throw new Exception("הקש סוג יום תקין");


            }
        }

        public string Name_day
        {
            get
            {
                return this.name_day;

            }
            set
            {
                if (ValidateUtilities.IsHebrew(value))
                    name_day = value;
                else
                    throw new Exception("הקש שם יום תקין");


            }
        }




        public Day_kind(DataRow dr)
        {
            this.day_kind_code = Convert.ToInt32(dr["day_kind_code"].ToString());
            this.name_day = dr["name_day"].ToString();

        }
    }


  }
