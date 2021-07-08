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
using Auctionhouse.Gui;
using Auctionhouse.Models;

namespace Auctionhouse.Db
{
    class Day_kindDB:GeneralDB
       
    {
        public Day_kindDB():base("day_kind","day_kind_code")
        {
        }

        public new Day_kind GetCurrentRow()

        {


            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Day_kind(dr);
        }
        public void UpdateRow(Day_kind d)
        {

            DataRow dr = base.GetCurrentRow();
            d.PutInto(dr);
            this.Update();
        }
        public void AddNew(Day_kind d)
        {
            DataRow dr = table.NewRow();
            d.PutInto(dr);
            this.Add(dr);


        }

    }
}
