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
    public partial class FrmSearchClient : Form
    {
        private Client cl;
        private ClientDB tblcl;
        private SaleFRM1 s;

        
        public FrmSearchClient()
        {

            tblcl = new ClientDB();
            InitializeComponent();
            dgClient.DataSource = tblcl.GetTable();
            
        }

        public FrmSearchClient(SaleFRM1 S)
        {
            this.s = s;
            tblcl = new ClientDB();
            InitializeComponent();
            dgClient.DataSource = tblcl.GetTable();
            btnBackSale_offer.Visible = true;
            btnBackClient.Visible = false;

        }
        public FrmSearchClient(SaleFRM2 S)
        {
            this.s = s;
            tblcl = new ClientDB();
            InitializeComponent();
            dgClient.DataSource = tblcl.GetTable();
            btnBackSale_offer.Visible = true;
            btnBackClient.Visible = false;

        }
        public FrmSearchClient(Sale3FRM S)
        {
            this.s = s;
            tblcl = new ClientDB();
            InitializeComponent();
            dgClient.DataSource = tblcl.GetTable();
            btnBackSale_offer.Visible = true;
            btnBackClient.Visible = false;

        }
        public FrmSearchClient(Sale4FRM S)
        {
            this.s = s;
            tblcl = new ClientDB();
            InitializeComponent();
            dgClient.DataSource = tblcl.GetTable();
            btnBackSale_offer.Visible = true;
            btnBackClient.Visible = false;

        }
        public FrmSearchClient(Sale5FRM S)
        {
            this.s = s;
            tblcl = new ClientDB();
            InitializeComponent();
            dgClient.DataSource = tblcl.GetTable();
            btnBackSale_offer.Visible = true;
            btnBackClient.Visible = false;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void FrmSearchClient_Load(object sender, EventArgs e)
        {

        }

        private void txtbyFname_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tblcl.SelectWhere("id like'" + txtbyId.Text + "%' and lname like'" + txtbyLname.Text + "%' and pel like'" + txtbyPel.Text + "%' and fname like'" + txtbyFname.Text + "%' ");
            dgClient.DataSource = dt;
        }

        private void txtbyId_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tblcl.SelectWhere("id like'"+txtbyId.Text+ "%' and lname like'" + txtbyLname.Text + "%' and pel like'" + txtbyPel.Text + "%' and fname like'" + txtbyFname.Text + "%' ");
            dgClient.DataSource = dt;
        }

        private void txtbyLname_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tblcl.SelectWhere("id like'" + txtbyId.Text + "%' and lname like'" + txtbyLname.Text + "%' and pel like'" + txtbyPel.Text + "%' and fname like'" + txtbyFname.Text + "%' ");
            dgClient.DataSource = dt;
        }

        private void txtbyPel_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tblcl.SelectWhere("id like'" + txtbyId.Text + "%' and lname like'" + txtbyLname.Text + "%' and pel like'" + txtbyPel.Text + "%' and fname like'" + txtbyFname.Text + "%' ");
            dgClient.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(dgClient.RowCount>0)
            {
            string x = dgClient.CurrentRow.Cells["Column1"].Value.ToString();
            ClientFRM fcl = new ClientFRM(x);
            fcl.Show();
            this.Hide();
            }
            else
            {
                ClientFRM fcl = new ClientFRM();
                fcl.Show();
                this.Hide();
            }
            
        }

        private void btnBackSale_offer_Click(object sender, EventArgs e)
        {
            if (dgClient.RowCount > 0)
            {
                string x = dgClient.CurrentRow.Cells["column1"].Value.ToString();
                s.miluyClient(x);
                this.Hide();

            }
            




        }
    }
}
