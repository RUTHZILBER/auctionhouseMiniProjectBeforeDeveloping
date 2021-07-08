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
    class Hours
    {
        private int show_place_code;
        private int day_kind_code;
        private DateTime o_hour;
        private DateTime s_hour;

        public void PutInto(DataRow dr)
        {
            dr["show_place_code"] = this.show_place_code;
            dr["day_kind_code"] = this.day_kind_code;
            dr["o_hour"] = this.o_hour;
            dr["s_hour"] = this.s_hour;

        }

        public Hours(DataRow dr)
        {
            this.show_place_code = Convert.ToInt32(dr["show_place_code"].ToString());
            this.day_kind_code = Convert.ToInt32(dr["day_kind_code"].ToString());
            this.o_hour = Convert.ToDateTime(dr["o_hour"]);
            this.s_hour = Convert.ToDateTime(dr["s_hour"]);
        }


        public Hours()
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
                    throw new Exception("הקש קוד סוג יום תקין");


            }
        }

        public DateTime O_hour
        {
            get
            {
                return this.o_hour;

            }
            set
            {
                if (day_kind_code == 6)
                {
                    if ((Convert.ToInt32(value.Hour) >= 8) && (Convert.ToInt32(value.Hour) < 14))
                        o_hour = value;
                    else
                        throw new Exception("הקש שעת פתיחה ליום שישי תקינה");
                }
                else
                {
                    if (day_kind_code == 7)
                    {
                        if (((Convert.ToInt32(value.Hour)) >= 21))
                            o_hour = value;
                        else
                            throw new Exception("הקש שעת פתיחה למוצש הגדולה מ21 תקינה");
                    }
                    else
                    {
                        if ((Convert.ToInt32(value.Hour) >= 8))
                            o_hour = value;
                        else
                            throw new Exception("הקש שעת פתיחה תקינה");
                    }

                }

            }



        }

        public DateTime S_hour
        {
            get
            {
                return this.s_hour;

            }
            set
            {

                if (day_kind_code == 6)
                {
                    if ((Convert.ToInt32(value.Hour) <= 23) && (Convert.ToInt32(value.Hour) > o_hour.Hour) && (Convert.ToInt32(value.Hour) <= 14))
                        s_hour = value;
                    else
                        throw new Exception("הקש שעת סגירה לפני 14 מפאת יום שישי");
                }


                else
                {
                    if (day_kind_code == 7)
                    {
                        if ((Convert.ToInt32(value.Hour) <= 23) && (Convert.ToInt32(value.Hour) > o_hour.Hour) && (Convert.ToInt32(value.Hour) > 21))
                            s_hour = value;
                        else
                            throw new Exception("הקש שעת סגירה בין 21 ל23 בגלל מוצש");
                    }
                    else
                    {
                    if ((Convert.ToInt32(value.Hour) < 23) && (Convert.ToInt32(value.Hour) > o_hour.Hour))
                        s_hour = value;
                    else
                        throw new Exception("הקש שעת סגירה תקינה");
                    }

                   
                }




            }
        }

    }
}

