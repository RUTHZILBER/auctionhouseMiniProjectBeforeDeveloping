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
    public partial class FrmSearchAuctionhouss : Form
    {
        private Auctionhouses a;
        private AuctionhousesDB tbla;
        private CategoryDB tblca;
        private Category ca;
        public FrmSearchAuctionhouss()
        {
            InitializeComponent();
            ca = new Category();
            tblca = new CategoryDB();
            tbla = new AuctionhousesDB();

            cmbCategoryy.DataSource = tblca.GetTable();
            cmbCategoryy.DisplayMember = "category_name";
            cmbCategoryy.ValueMember = "category_code";
            cmbCategoryy.Text = "";
            dgAuctionhouse.DataSource = tbla.GetTable();
            
        }

        private void FrmSearchAuctionhouss_Load(object sender, EventArgs e)
        {

        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            Begin b = new Begin();
            b.Show();
            this.Hide();
        }

        private void txtbyAuctionhouse_code_TextChanged(object sender, EventArgs e)
        {
            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "%' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string x = dgAuctionhouse.CurrentRow.Cells["column1"].Value.ToString();
            AuctionhousesFRM fa = new AuctionhousesFRM(x);
            fa.Show();
            this.Hide();
        }

        private void txtbyAuctionhouse_name_TextChanged(object sender, EventArgs e)
        {

            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void txtbyCategory_code_TextChanged(object sender, EventArgs e)
        {
            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "%' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void txtbyTel_TextChanged(object sender, EventArgs e)
        {
            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "%' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategoryy_SelectionChangeCommitted(object sender, EventArgs e)
        {

            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategoryy_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoryy_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategoryy_TextChanged(object sender, EventArgs e)
        {
            tblca.Find(cmbCategoryy.SelectedValue);
            Category ca1 = tblca.GetCurrentRow();
            int p = ca1.Category_code;
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoryy.Text == "")
            {
                DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Tel like'" + txtbyTel.Text + "%'");
            }
            else
            {
                tblca.Find(cmbCategoryy.SelectedValue);
                Category ca1 = tblca.GetCurrentRow();
                int p = ca1.Category_code;
                DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like '" + txtbyAuctionhouse_name.Text + "' and Category_code=" + p + " and Tel like'" + txtbyTel.Text + "%'");
                dgAuctionhouse.DataSource = dt;
            }
        }

        private void cmbCategoryy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
