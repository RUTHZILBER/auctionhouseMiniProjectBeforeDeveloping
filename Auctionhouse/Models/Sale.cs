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
   public class Sale
    {
        private int sale_code;
        private int product_code;
        private int show_place_code;
        private double first_price;
        private DateTime start_date;
        private double last_price;
        private DateTime deadline;
        private string win_client_code;
        private ProductDB tblp1;
        private Product p1;
        private double x;
        private int y;

        public void PutInto(DataRow dr)
        {
            dr["sale_code"] = this.sale_code;
            dr["product_code"] = this.product_code;
            dr["show_place_code"] = this.show_place_code;
            dr["first_price"] = this.first_price;
            dr["start_date"] = this.start_date;
            dr["last_price"] = this.last_price;
            dr["deadline"] = this.deadline;
            dr["win_client_id"] = this.win_client_code;


        }

        public Sale(DataRow dr)
        {
            this.sale_code = Convert.ToInt32(dr["sale_code"].ToString());
            this.product_code = Convert.ToInt32(dr["product_code"].ToString());
            this.show_place_code = Convert.ToInt32(dr["show_place_code"].ToString());
            this.first_price = Convert.ToDouble(dr["first_price"]);
            this.start_date = Convert.ToDateTime(dr["start_date"]);
            this.last_price = Convert.ToDouble(dr["last_price"]);
            this.deadline = Convert.ToDateTime(dr["deadline"]);
            this.win_client_code = dr["win_client_id"].ToString();
        }


        public Sale()
        { }

          public int Sale_code
        {
                get
                  {
                return this.sale_code;
                  }

                set
                {
                    sale_code= value;
                }
        }



        public int Product_code
        {

            get
            {
                return this.product_code;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString()))
                {
                  //tblp1 = new ProductDB();
                  //tblp1.Find(value);
                  //p1 = tblp1.GetCurrentRow();
                  //if(p1.Status==true)
                  //    product_code = value;
                  //  if (p1.Status == false)
                  //      throw new Exception("בחר מוצר");
                }
                else
                    throw new Exception("בחר מוצר");
            }
        }

       

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
                    throw new Exception("בחר אולם תצוגה תקין");


            }
        }

        public double FirstPrice
        {
            get
            {
                return this.first_price;

            }
            set
            {
                if (ValidateUtilities.IsNum(value.ToString())&&(value>=10))
                {
                first_price = value;
                    x = value;
                }
                   
                
                else
                    throw new Exception(" הקש מחיר ראשוני הגבוה מ10 שקלים");


            }
        }

        public DateTime Start_date
        {
            get
            {
                return this.start_date;

            }
            set
            {
                
                y = (Convert.ToInt32(value.DayOfWeek));
                if (y!=6)
                    if(y!=5)
                        start_date = value;
                
                    else
                         throw new Exception("אין אפשרות להכריז על פתיחת מכירה מכירה בשישי שבת");
                    
                      
                       
            }
        }
        public double LastPrice
        {
            get
            {
                return this.last_price;

            }
            set
            {
                if ((ValidateUtilities.IsNum(value.ToString())&&(value>=x)))
                    last_price = value;
                else
                    throw new Exception("הקש מחיר סופי תקין");


            }
        }

        public DateTime Deadline
        {
            get
            {
                return this.deadline;

            }
            set
            {

                y = (Convert.ToInt32(value.DayOfWeek));
                if(value.Year==start_date.Year)
                {
                     if ((value.DayOfYear > start_date.DayOfYear)&& (y != 6) && (y != 5))
                        deadline = value;
                      else
                         throw new Exception("בחר מועד סיום מכירה אחרי מועד פתיחת המכירה ולא בשישי שבת");

                }
                    
                else
                {
                if ((value.Year > start_date.Year) && (y != 6) && (y != 5))
                        deadline = value;
                else
                       throw new Exception("בחר מועד סיום מכירה אחרי מועד פתיחת המכירה ולא בשישי שבת");

                }
               
                        
            }
        }

        public string Win_client_id
        {



            get
            {
                return this.win_client_code;

            }
            set
            {
                
                    win_client_code = value;
               

            }
        }

    }
}
