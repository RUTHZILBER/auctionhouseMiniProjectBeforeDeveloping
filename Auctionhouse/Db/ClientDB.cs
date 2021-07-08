using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Auctionhouse.Data;
using Auctionhouse.Db;
using Auctionhouse.Properties;
using Auctionhouse.Utilitis;
using System.Data.OleDb;
using System.Collections;
using Auctionhouse.Gui;
using Auctionhouse.Models;




namespace Auctionhouse.Db
{
    class ClientDB : GeneralDB
    {
        public ClientDB():base("client", "id") { }

        public new Client GetCurrentRow()

        {


            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Client(dr);
        }
        public void UpdateRow(Client c)
        {

            DataRow dr = base.GetCurrentRow();
            c.PutInto(dr);
            this.Update();
        }
        public void AddNew(Client c)
        {
            DataRow dr = table.NewRow();
            c.PutInto(dr);
            this.Add(dr);


        }
    }

    
  
}
