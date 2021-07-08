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
    public partial class FrmSearchSale : Form
    {
        private SaleDB tbls;
        private SaleFRM1 s;
        private int a;
        private Show_placeDB tblsp;
        private Show_place sp;
        private int n; 

        public FrmSearchSale()
        {
            InitializeComponent();
            tblsp = new Show_placeDB();
            sp = new Show_place();
            cmbShow_place_code.DataSource = tblsp.GetTable();
            cmbShow_place_code.ValueMember = "show_place_code";
            cmbShow_place_code.DisplayMember = "show_place_name";
            cmbShow_place_code.Text = "";
            tbls = new SaleDB();
            dgSearchSale.DataSource=tbls.GetTable();
            cmbShow_place_code.Text = "";
            a =0;
        }
        public FrmSearchSale(Sale5FRM sw)
        {
            a = 5;
            InitializeComponent();
            tblsp = new Show_placeDB();
            sp = new Show_place();
            cmbShow_place_code.DataSource = tblsp.GetTable();
            cmbShow_place_code.ValueMember = "show_place_code";
            cmbShow_place_code.DisplayMember = "show_place_name";
            cmbShow_place_code.Text = "";
            tbls = new SaleDB();
            cmbShow_place_code.Text = "";
            dgSearchSale.DataSource =tbls.GetTable();

        }
        public FrmSearchSale(Sale4FRM sw)
        {
            a =4;
            InitializeComponent();
            tbls = new SaleDB();
            dgSearchSale.DataSource = tbls.GetTable();

        }
        public FrmSearchSale(Sale3FRM sw)
        {
            a =3;
            InitializeComponent();
            tbls = new SaleDB();
            dgSearchSale.DataSource = tbls.GetTable();

        }
        public FrmSearchSale(SaleFRM2 sw)
        {
            a =2;
            InitializeComponent();
            tbls = new SaleDB();
            dgSearchSale.DataSource = tbls.GetTable();

        }
        public FrmSearchSale(SaleFRM1 sw)
        {
            a =1;
            InitializeComponent();
            tbls = new SaleDB();
            dgSearchSale.DataSource = tbls.GetTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBy_Load(object sender, EventArgs e)
        {

        }

        private void txtbySale_code_TextChanged(object sender, EventArgs e)
        {
            tblsp.Find(cmbShow_place_code.SelectedValue);
            sp = tblsp.GetCurrentRow();
            n = sp.Show_place_code;
            DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and deadline.year =" + dtpDeadline.Value.Year+ " and deadline.month =" + dtpDeadline.Value.Month + " and deadline.day =" + dtpDeadline.Value.Day + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            dgSearchSale.DataSource = d;
        }

        private void txtbyShow_place_code_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbyFirst_price_TextChanged(object sender, EventArgs e)
        {
            tblsp.Find(cmbShow_place_code.SelectedValue);
            sp = tblsp.GetCurrentRow();
            n = sp.Show_place_code;
            DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and win_client_id like'" + txtbyWin_client_id.Text + "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            dgSearchSale.DataSource = d;
        }

        private void txtbyStart_date_TextChanged(object sender, EventArgs e)
        {
            tblsp.Find(cmbShow_place_code.SelectedValue);
            sp = tblsp.GetCurrentRow();
            n = sp.Show_place_code;
            DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and win_client_id like'" + txtbyWin_client_id.Text + "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            dgSearchSale.DataSource = d;
        }

        private void txtbyLast_price_TextChanged(object sender, EventArgs e)
        {
            tblsp.Find(cmbShow_place_code.SelectedValue);
            sp = tblsp.GetCurrentRow();
            n = sp.Show_place_code;
            DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and win_client_id like'" + txtbyWin_client_id.Text + "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            dgSearchSale.DataSource = d;
        }

        private void txtbyDeadline_TextChanged(object sender, EventArgs e)
        {
            tblsp.Find(cmbShow_place_code.SelectedValue);
            sp = tblsp.GetCurrentRow();
            n = sp.Show_place_code;
            DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and win_client_id like'" + txtbyWin_client_id.Text + "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            dgSearchSale.DataSource = d;
        }

        private void txtbyWin_client_id_TextChanged(object sender, EventArgs e)
        {
            tblsp.Find(cmbShow_place_code.SelectedValue);
            sp = tblsp.GetCurrentRow();
            n = sp.Show_place_code;
            DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and win_client_id like'" + txtbyWin_client_id.Text + "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            dgSearchSale.DataSource = d;
        }

        private void btnBackSale_Click(object sender, EventArgs e)
        {
            SaleFRM1 s = new SaleFRM1();
            s.Show();
            this.Hide();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void cmbShow_place_code_SelectedIndexChanged(object sender, EventArgs e)
        {



            //if (cmbShow_place_code.Text=="")
            //{
            DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%'   and" /*win_client_id like'" + txtbyWin_client_id.Text + "%'*/+ " and deadline.year =" + dtpDeadline.Value.Year + " and deadline.month =" + dtpDeadline.Value.Month + " and deadline.day =" + dtpDeadline.Value.Day + "%' and last_price like'" + txtbyLast_price.Text + "%'  and product_code like'" + txtbyProduct_code.Text + "%' ");
            dgSearchSale.DataSource = d;
            //}
            //else
            //{
            //tblsp.Find(cmbShow_place_code.SelectedValue);
            //sp = tblsp.GetCurrentRow();
            //n = sp.Show_place_code;
            //DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and win_client_id like'" + txtbyWin_client_id.Text + "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            //dgSearchSale.DataSource = d;
            //}
        }

        private void cmbShow_place_code_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbShow_place_code.SelectedValue == null)
            {
                DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%'  and win_client_id like'" + txtbyWin_client_id.Text + " and deadline.year =" + dtpDeadline.Value.Year + " and deadline.month =" + dtpDeadline.Value.Month + " and deadline.day =" + dtpDeadline.Value.Day + " and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
                dgSearchSale.DataSource = d;
            }
            //else
            //{
            //    tblsp.Find(cmbShow_place_code.SelectedValue);
            //    sp = tblsp.GetCurrentRow();
            //    n = sp.Show_place_code;
            //    DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + " and win_client_id like'" + txtbyWin_client_id.Text + "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            //    dgSearchSale.DataSource = d;
            //}
        }

        private void cmbShow_place_code_TextChanged(object sender, EventArgs e)
        {
            //if (cmbShow_place_code.Text == "")
            //{
            //DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%'  and deadline =" + dtpDeadline.Value + "%' and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            //dgSearchSale.DataSource = d;

            //}
            //else
            //{
            //tblsp.Find(cmbShow_place_code.SelectedValue);
            //sp = tblsp.GetCurrentRow();
            //n = sp.Show_place_code;
            //DataTable d = tbls.SelectWhere("first_price like'" + txtbyFirst_price.Text + "%' and sale_code like'" + txtbySale_code.Text + "%' and show_place_code =" + n + /*" and win_client_id like'" + txtbyWin_client_id.Text +*/ "%' and deadline =" + dtpDeadline.Value + "% and last_price like'" + txtbyLast_price.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' ");
            //dgSearchSale.DataSource = d;
            //}
        }
    }
}
