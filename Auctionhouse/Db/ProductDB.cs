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
    class ProductDB:GeneralDB
    {
        public ProductDB():base("product","product_code")
        {
        }
        public new Product GetCurrentRow()

        {


            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Product(dr);
        }
        public void UpdateRow(Product p)
        {

            DataRow dr = base.GetCurrentRow();
            p.PutInto(dr);
            this.Update();
        }
        public void AddNew(Product p)
        {
            DataRow dr = table.NewRow();
            p.PutInto(dr);
            this.Add(dr);


        }

    }
}
