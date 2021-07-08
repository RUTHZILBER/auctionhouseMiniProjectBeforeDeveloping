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
    class HoursDB:GeneralDB
    {
        public HoursDB():base("hours","show_place_code","day_kind_code")
        {
        }
        public new Hours GetCurrentRow()

        {


            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Hours(dr);
        }
        public void UpdateRow(Hours h)
        {

            DataRow dr = base.GetCurrentRow();
            h.PutInto(dr);
            this.Update();
        }
        public void AddNew(Hours h)
        {
            DataRow dr = table.NewRow();
            h.PutInto(dr);
            this.Add(dr);


        }
    }
}
