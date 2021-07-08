using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auctionhouse.Properties;
using Auctionhouse.Utilitis;
using System.Data.OleDb;
using Auctionhouse.Gui;
using Auctionhouse.Models;
using Auctionhouse.Data;
using Auctionhouse.Db;
using System.Collections;
namespace Auctionhouse.Gui
{
    public partial class FrmSearchShow_place : Form
    {
        private Show_placeDB tblsp;
        private Show_place sp;
        private SaleFRM1 fs;
        private AuctionhousesDB tbla;
        private Auctionhouses a;
        private int k;

        public FrmSearchShow_place()
        {
            InitializeComponent();
            tblsp = new Show_placeDB();
            dgSearchShow_place.DataSource = tblsp.GetTable();
            btnBack.Visible = true;
            btnBackSale.Visible = false;
            tbla = new AuctionhousesDB();
            a = new Auctionhouses();
            cmbAuctionhouse_name.DataSource = tbla.GetTable();
            cmbAuctionhouse_name.DisplayMember = "auctionhouse_name";
            cmbAuctionhouse_name.ValueMember = "auctionhouse_code";
            cmbAuctionhouse_name.Text = "";
            
            
        }

        public FrmSearchShow_place(SaleFRM1 s)
        {
            InitializeComponent();
            this.fs = s;
            tblsp = new Show_placeDB();
            dgSearchShow_place.DataSource = tblsp.GetTable();
            btnBack.Visible =false;
            btnBackSale.Visible =  true;
            tbla = new AuctionhousesDB();
            a = new Auctionhouses();
            cmbAuctionhouse_name.DataSource = tbla.GetTable();
            cmbAuctionhouse_name.DisplayMember = "auctionhouse_name";
            cmbAuctionhouse_name.ValueMember = "auctionhouse_code";
            cmbAuctionhouse_name.Text = "";
        }




        private void FrmSearchShow_place_Load(object sender, EventArgs e)
        {

        }

        private void txtbyShow_place_code_TextChanged(object sender, EventArgs e)
        {
            tbla.Find(cmbAuctionhouse_name.SelectedValue);
            a = tbla.GetCurrentRow();
            k = a.Auctionhouse_code;
            DataTable d = tblsp.SelectWhere("show_place_code like'" + txtbyShow_place_code.Text + "%' and Auctionhouse_code =" + k + " and Address like'" + txtbyAddress.Text + "%' and City like'" + txtbyCity.Text + "%'");
            dgSearchShow_place.DataSource = d;
        }

        private void txtbyAuctionhouse_code_TextChanged(object sender, EventArgs e)
        {
            //DataTable d = tblsp.SelectWhere("show_place_code like'" + txtbyShow_place_code.Text + "%' and Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Address like'" + txtbyAddress.Text + "%' and City like'" + txtbyCity.Text + "%'");
            //dgSearchShow_place.DataSource = d;
        }

        private void txtbyAddress_TextChanged(object sender, EventArgs e)
        {
            tbla.Find(cmbAuctionhouse_name.SelectedValue);
            a = tbla.GetCurrentRow();
            k = a.Auctionhouse_code;
            DataTable d = tblsp.SelectWhere("show_place_code like'" + txtbyShow_place_code.Text + "%' and Auctionhouse_code =" + k + " and Address like'" + txtbyAddress.Text + "%' and City like'" + txtbyCity.Text + "%'");
            dgSearchShow_place.DataSource = d;
        }

        private void txtbyCity_TextChanged(object sender, EventArgs e)
        {
            tbla.Find(cmbAuctionhouse_name.SelectedValue);
            a = tbla.GetCurrentRow();
            k = a.Auctionhouse_code;
            DataTable d = tblsp.SelectWhere("show_place_code like'" + txtbyShow_place_code.Text + "%' and Auctionhouse_code =" + k + " and Address like'" + txtbyAddress.Text + "%' and City like'" + txtbyCity.Text + "%'");
            dgSearchShow_place.DataSource = d;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(dgSearchShow_place.RowCount>0)
            {
                string x = dgSearchShow_place.CurrentRow.Cells["column1"].Value.ToString();
                Show_placeFRM fsp = new Show_placeFRM(x);
                fsp.Show();
                this.Hide();
            }
            else
            {
                Show_placeFRM fsp = new Show_placeFRM();
                fsp.Show();
                this.Hide();
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (Program.ab == 0)
            {
                BeginA a1 = new BeginA();
                this.Hide();
                a1.Show();
            }
            else
            {
                if (Program.ab == 2)
                {
                    BeginC b2 = new BeginC();
                    this.Hide();
                    b2.Show();
                }
            }
        }

        private void btnBackSale_Click(object sender, EventArgs e)
        {
            if(dgSearchShow_place.RowCount>0)
            {
                string x = dgSearchShow_place.CurrentRow.Cells["column1"].Value.ToString();
                fs.miluyShow_place(x);
                this.Hide();
            }
        }

        private void dgSearchShow_place_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSearchShow_place_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbAuctionhouse_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAuctionhouse_name.SelectedValue==null)
            {
            DataTable d1 = tblsp.SelectWhere("show_place_code like'" + txtbyShow_place_code.Text + "%'and Address like'" + txtbyAddress.Text + "%' and City like'" + txtbyCity.Text + "%'");
            dgSearchShow_place.DataSource = d1;
            }
            else
            {
            tbla.Find(cmbAuctionhouse_name.SelectedValue);
            a = tbla.GetCurrentRow();
            k = a.Auctionhouse_code;
            DataTable d = tblsp.SelectWhere("show_place_code like'" + txtbyShow_place_code.Text + "%' and Auctionhouse_code =" + k + " and Address like'" + txtbyAddress.Text + "%' and City like'" + txtbyCity.Text + "%'");
            dgSearchShow_place.DataSource = d;
            }
               
            
        }
    }
}
