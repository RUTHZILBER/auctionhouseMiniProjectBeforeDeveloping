using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using Auctionhouse.Data;
using Auctionhouse.Db;
using Auctionhouse.Properties;
using Auctionhouse.Utilitis;

using Microsoft.Office.Interop.Access;



namespace Auctionhouse.Data
{
    public class Dal
    {
        private static Dal instance;
        private OleDbConnection con;
        private DataSet ds;
        private Hashtable adapters;
        private Dal(string connectionString)
        {
            con = new OleDbConnection(connectionString);
            ds = new DataSet();
            adapters = new Hashtable();
        }
        public static Dal GetInstance()
        {
            if (instance == null)
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                int x = path.IndexOf("\\bin");
                path = path.Substring(0, x) + "\\Data\\Auctionhouse.accdb";
                instance = new Dal(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
            }
            return instance;

        }
        public bool AddTable(string tableName, string sqlStat)
        {
            if (!ds.Tables.Contains(tableName))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStat, con);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.Fill(ds, tableName);
                adapters.Add(tableName, adapter);
                return true;
            }
            return false;
        }
        public bool AddTable(string tableName)
        {
            return AddTable(tableName, " Select * from " + tableName);
        }
        public DataTable GetTable(string tableName)
        {
            return ds.Tables[tableName];
        }
        public DataTable GetSelectTable(string sql)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            adapter.Fill(dt);
            return dt;
        }
        public bool RemoveTable(string tableName)
        {
            bool suceed = true;
            try
            {
                ds.Tables.Remove(tableName);
                adapters.Remove(tableName);
            }
            catch
            {
                suceed = false;
            }
            return suceed;
        }
        public void Update(string tableName)
        {
            OleDbDataAdapter adapter = (OleDbDataAdapter)adapters[tableName];
            adapter.Update(ds, tableName);
        }
        public void Update()
        {
            foreach (DataTable table in ds.Tables)
            {
                Update(table.TableName);
            }
        }

        public static void DealWithReport(string reportName, string whereCondindition)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            int x = path.IndexOf("\\bin");
            path = path.Substring(0, x) + "\\Data\\Auctionhouse.accdb";
            Microsoft.Office.Interop.Access.Application oAccess = null;
        oAccess = new Microsoft.Office.Interop.Access.Application();
            try
            {
                oAccess.OpenCurrentDatabase(path, true);
                oAccess.DoCmd.OpenReport(reportName, AcView.acViewPreview, System.Reflection.Missing.Value, whereCondindition);
                oAccess.DoCmd.OutputTo(AcOutputObjectType.acOutputReport, System.Reflection.Missing.Value, "PDF", System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, AcExportQuality.acExportQualityPrint);
            }
            catch
            {
            }
oAccess.Quit();
        }

    }
}



