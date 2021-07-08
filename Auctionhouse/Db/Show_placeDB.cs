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
    class Show_placeDB:GeneralDB
    {
        public Show_placeDB():base("show_place","show_place_code")
        {
        }
        public new Show_place GetCurrentRow()

        {


            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Show_place(dr);
        }
        public void UpdateRow(Show_place sp)
        {

            DataRow dr = base.GetCurrentRow();
            sp.PutInto(dr);
            this.Update();
        }
        public void AddNew(Show_place sp)
        {
            DataRow dr = table.NewRow();
            sp.PutInto(dr);
            this.Add(dr);


        }
    }
}
