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
    public partial class FrmSearchAuctionhouses : Form
    {
        private Auctionhouses a;
        private AuctionhousesDB tbla;
        private CategoryDB tblca;
        public FrmSearchAuctionhouses()
        {InitializeComponent();
            tblca = new CategoryDB();
            tbla = new AuctionhousesDB();
            cmbCategoryy.DataSource = tblca.GetTable();
            cmbCategoryy.DisplayMember = "category_name";
            cmbCategoryy.ValueMember = "category_code";
            
            dgAuctionhouse.DataSource = tbla.GetTable();
        }

        

        private void FrmSearchAuctionhouses_Load(object sender, EventArgs e)
        {

        }

        private void FrmSearchAuctionhouses_Load_1(object sender, EventArgs e)
        {

        }

        private void dgAuctionhouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like'" + txtbyAuctionhouse_name.Text + "%' and Category_code like'" + txtbyCategory_code.Text + "%' and Tel like'" + txtbyTel.Text + "%'");
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
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like'" + txtbyAuctionhouse_name.Text + "%' and Category_code like'" + txtbyCategory_code.Text + "%' and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void txtbyCategory_code_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like'" + txtbyAuctionhouse_name.Text + "%' and Category_code like'" + txtbyCategory_code.Text + "%' and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void txtbyTel_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like'" + txtbyAuctionhouse_name.Text + "%' and Category_code like'" + txtbyCategory_code.Text + "%' and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like'" + txtbyAuctionhouse_name.Text + "%' and Category_code =" + cmbCategoryy.SelectedValue + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like'" + txtbyAuctionhouse_name.Text + "%' and Category_code =" + cmbCategoryy.SelectedValue + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategoryy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tbla.SelectWhere("Auctionhouse_code like'" + txtbyAuctionhouse_code.Text + "%' and Auctionhouse_name like'" + txtbyAuctionhouse_name.Text + "%' and Category_code =" + cmbCategoryy.SelectedValue + " and Tel like'" + txtbyTel.Text + "%'");
            dgAuctionhouse.DataSource = dt;
        }

        private void cmbCategoryy_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
