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
using Auctionhouse.Models;

namespace Auctionhouse.Db
{
    class AuctionhousesDB:GeneralDB
    {
        public AuctionhousesDB():base("auctionhouses", "auctionhouse_code")
        {
        }
        public new Auctionhouses GetCurrentRow()
        {
            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Auctionhouses(dr);
        }
        public void UpdateRow(Auctionhouses a)
        {

            DataRow dr = base.GetCurrentRow();
            a.PutInto(dr);
            this.Update();
        }
        public void AddNew(Auctionhouses a)
        {
            DataRow dr = table.NewRow();
            a.PutInto(dr);
            this.Add(dr);


        }
    }



}

      

