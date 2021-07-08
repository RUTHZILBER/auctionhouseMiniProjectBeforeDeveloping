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
    class CategoryDB : GeneralDB
    {
        public CategoryDB() : base("category", "category_code")
        {
        }

        public new Category GetCurrentRow()
        {
            DataRow dr = base.GetCurrentRow();
            if (dr == null)
                return null;
            else
                return new Category(dr);
        }
        public void UpdateRow(Category c)
        {

            DataRow dr = base.GetCurrentRow();
            c.PutInto(dr);
            this.Update();
        }
        public void AddNew(Category c)
        {
            DataRow dr = table.NewRow();
            c.PutInto(dr);
            this.Add(dr);






        }

    }
}

