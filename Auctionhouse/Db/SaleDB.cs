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


namespace Auctionhouse.Db
{
    class SaleDB:GeneralDB
    {
        public SaleDB() : base("sale", "sale_code")
        {
        }
        public new Sale GetCurrentRow()

        {


            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Models.Sale(dr);
        }
        public void UpdateRow(Models.Sale s)
        {

            DataRow dr = base.GetCurrentRow();
            s.PutInto(dr);
            this.Update();
        }
        public void AddNew(Models.Sale s)
        {
            DataRow dr = table.NewRow();
            s.PutInto(dr);
            this.Add(dr);


        }
    }
}
