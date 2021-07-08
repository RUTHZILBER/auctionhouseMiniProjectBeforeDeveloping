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
    class Sale_offerDB:GeneralDB
    {
        public Sale_offerDB() : base("sale_offer", "sale_code","id","date_","tim")
        {
        }
        public new Sale_offer GetCurrentRow()

        {
            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Sale_offer(dr);
        }
        public void UpdateRow(Sale_offer so)
        {

            DataRow dr = base.GetCurrentRow();
            so.PutInto(dr);
            this.Update();
        }
        public void AddNew(Sale_offer so)
        {
            DataRow dr = table.NewRow();
            so.PutInto(dr);
            this.Add(dr);


        }
    }
}
