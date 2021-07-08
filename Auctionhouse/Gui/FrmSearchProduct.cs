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
    public partial class FrmSearchProduct : Form
    {
        private Product p;
        private ProductDB tblp;
        private SaleFRM1 s1;
        private SaleFRM2 s2;
        private Sale3FRM s3;
        private Sale4FRM s4;
        private int n;
        private CategoryDB tblca;
        private Category ca;
        private Sale5FRM s5;
        public FrmSearchProduct()
        {
            tblp = new ProductDB();
            InitializeComponent();
            dgProduct.DataSource = tblp.GetTable();
            btnBack.Visible = true;
            btnBackSale.Visible = false;
            tblca = new CategoryDB();
            btnBegin.Visible = true;
            txtAuctionhouse_code.Visible = false;
            cmbCategory_name.DataSource = tblca.GetTable();
            cmbCategory_name.ValueMember = "category_code";
            cmbCategory_name.DisplayMember = "category_name";
            cmbCategory_name.Text= "";
        }

        public FrmSearchProduct(SaleFRM1 s1)
        {
            this.s1 = s1;
            tblca = new CategoryDB();
            tblp = new ProductDB();
            InitializeComponent();
            dgProduct.DataSource = tblp.SelectWhere("status="+true+"");
            btnBack.Visible = false;
            btnBackSale.Visible = true;
            btnBegin.Visible = false;
            l5.Visible = true;
            txtAuctionhouse_code.Visible=true;
            txtbyCategory_code.Visible = false;
            label3.Visible = false;
            cmbCategory_name.DataSource = tblca.GetTable();
            cmbCategory_name.ValueMember = "category_code";
            cmbCategory_name.DisplayMember = "category_name";
            cmbCategory_name.Text = "";
            label2.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            txtbyCategory_code.Visible = false;
            txtbyProduct_name.Visible = false;
            txtbyCreature_year.Visible = false;
            txtbyProduct_code.Visible = false;
            }
        public FrmSearchProduct(SaleFRM2 s2)
        {
            this.s2 = s2;
            tblca = new CategoryDB();
            tblp = new ProductDB();
            InitializeComponent();
            dgProduct.DataSource = tblp.SelectWhere("status=" + true + "");
            btnBack.Visible = false;
            btnBackSale.Visible = true;
            btnBegin.Visible = false;
            l5.Visible = true;
            txtAuctionhouse_code.Visible = true;
            txtbyCategory_code.Visible = false;
            label3.Visible = false;
            cmbCategory_name.DataSource = tblca.GetTable();
            cmbCategory_name.ValueMember = "category_code";
            cmbCategory_name.DisplayMember = "category_name";
            label2.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            txtbyCategory_code.Visible = false;
            txtbyProduct_name.Visible = false;
            txtbyCreature_year.Visible = false;
            txtbyProduct_code.Visible = false;
        }
        public FrmSearchProduct(Sale3FRM s3)
        {
            this.s3 = s3;
            tblp = new ProductDB();
            InitializeComponent();
            dgProduct.DataSource = tblp.SelectWhere("status=" + true + "");
            btnBack.Visible = false;
            btnBackSale.Visible = true;
            btnBegin.Visible = false;
            l5.Visible = true;
            txtAuctionhouse_code.Visible = true;
            txtbyCategory_code.Visible = false;
            label3.Visible = false;

            label2.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            txtbyCategory_code.Visible = false;
            txtbyProduct_name.Visible = false;
            txtbyCreature_year.Visible = false;
            txtbyProduct_code.Visible = false;
        }
        public FrmSearchProduct(Sale4FRM s4)
        {
            this.s4 = s4;
            tblp = new ProductDB();
            InitializeComponent();
            dgProduct.DataSource = tblp.SelectWhere("status=" + true + "");
            btnBack.Visible = false;
            btnBackSale.Visible = true;
            btnBegin.Visible = false;
            l5.Visible = true;
            txtAuctionhouse_code.Visible = true;
            txtbyCategory_code.Visible = false;
            label3.Visible = false;

            label2.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            txtbyCategory_code.Visible = false;
            txtbyProduct_name.Visible = false;
            txtbyCreature_year.Visible = false;
            txtbyProduct_code.Visible = false;
        }
        public FrmSearchProduct(Sale5FRM s5)
        {
            this.s5 = s5;
            tblp = new ProductDB();
            InitializeComponent();
            dgProduct.DataSource = tblp.SelectWhere("status=" + true + "");
            btnBack.Visible = false;
            btnBackSale.Visible = true;
            btnBegin.Visible = false;
            l5.Visible = true;
            txtAuctionhouse_code.Visible = true;
            txtbyCategory_code.Visible = false;
            label3.Visible = false;

            label2.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            txtbyCategory_code.Visible = false;
            txtbyProduct_name.Visible = false;
            txtbyCreature_year.Visible = false;
            txtbyProduct_code.Visible = false;
        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            Begin b = new Begin();
            b.Show();
            this.Hide();
        }

        private void dgProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtbyProduct_code_TextChanged(object sender, EventArgs e)
        {
            tblca.Find(cmbCategory_name.SelectedValue);
            Category caa = tblca.GetCurrentRow();
            n = caa.Category_code;
            DataTable dt = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and Category_code =" + n + " and Creature_year like'" + txtbyCreature_year.Text + "%'");
            dgProduct.DataSource = dt;
        }

        private void txtbyProduct_name_TextChanged(object sender, EventArgs e)
        {
            tblca.Find(cmbCategory_name.SelectedValue);
            Category caa = tblca.GetCurrentRow();
            n = caa.Category_code;
            DataTable dt = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and Category_code =" + n + " and Creature_year like'" + txtbyCreature_year.Text + "%'");
            dgProduct.DataSource = dt;

        }

        private void txtbyCategory_code_TextChanged(object sender, EventArgs e)
        {

            tblca.Find(cmbCategory_name.SelectedValue);
            Category caa = tblca.GetCurrentRow();
            n = caa.Category_code;
            DataTable dt = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and Category_code =" + n + " and Creature_year like'" + txtbyCreature_year.Text + "%'");
            dgProduct.DataSource = dt;

        }

        private void txtbyCreature_year_TextChanged(object sender, EventArgs e)
        {
            tblca.Find(cmbCategory_name.SelectedValue);
            Category caa = tblca.GetCurrentRow();
            n = caa.Category_code;
            DataTable dt = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and Category_code =" + n + " and Creature_year like'" + txtbyCreature_year.Text + "%'");
            dgProduct.DataSource = dt;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            string x = dgProduct.CurrentRow.Cells["Column1"].Value.ToString();
            Product1FRM p = new Product1FRM(x);
            p.Show();
            this.Hide();
        }

        private void btnBackSale_Click(object sender, EventArgs e)
        {
            string x = dgProduct.CurrentRow.Cells["Column1"].Value.ToString();

            s1.miluyProduct(x);
            this.Hide();
          
        }
       
        public void miluy(string x)
        {
            
        }

        private void txtAuctionhouse_code_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = tblp.SelectWhere("auctionhouse_code like'" + txtAuctionhouse_code.Text + "%'");
            dgProduct.DataSource = dt;

            label6.Visible = true;
            label5.Visible =true;
            label7.Visible = true;
            txtProductName.Visible = true;
            txtCreature.Visible = true;
            txtProductCode.Visible =true;

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {         
                DataTable dt = tblp.SelectMore("select p.product_code, p.product_name, p.creature_year, p.status,ca.category_name,a.auctionhouse_name from category ca, product p, auctionhouses a where p.category_code=ca.category_code and p.auctionhouse_code = a.auctionhouse_code and ca.category_code =a.category_code  and p.Product_name like'" + txtProductName.Text + "%' and p.auctionhouse_code like'" + txtAuctionhouse_code.Text + "%' and p.creature_year like'" + txtCreature.Text + "%' and p.product_code like'" + txtProductCode.Text + "%' and p.statuse="+true+"");
                dgProduct.DataSource = dt;
        }
        private void txtCreature_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = tblp.SelectMore("select p.product_code, p.product_name, p.creature_year, p.status,ca.category_name,a.auctionhouse_name from category ca, product p, auctionhouses a where p.category_code=ca.category_code and p.auctionhouse_code = a.auctionhouse_code and ca.category_code =a.category_code  and p.Product_name like'" + txtProductName.Text + "%' and p.auctionhouse_code like'" + txtAuctionhouse_code.Text + "%' and p.creature_year like'" + txtCreature.Text + "%' and p.product_code like'" + txtProductCode.Text + "%' and p.statuse=" + true + "");
            dgProduct.DataSource = dt;

        }
        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = tblp.SelectMore("select p.product_code, p.product_name, p.creature_year, p.status,ca.category_name,a.auctionhouse_name from category ca, product p, auctionhouses a where p.category_code=ca.category_code and p.auctionhouse_code = a.auctionhouse_code and ca.category_code =a.category_code  and p.Product_name like'" + txtProductName.Text + "%' and p.auctionhouse_code like'" + txtAuctionhouse_code.Text + "%' and p.creature_year like'" + txtCreature.Text + "%' and p.product_code like'" + txtProductCode.Text + "%' and p.statuse=" + true + "");
            dgProduct.DataSource = dt;

        }
        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCategory_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategory_name.SelectedValue==null)
            {
                DataTable dt = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and  Creature_year like'" + txtbyCreature_year.Text + "%'");
                dgProduct.DataSource = dt;
            }
            else
            {
                tblca.Find(cmbCategory_name.SelectedValue);
                Category caa = tblca.GetCurrentRow();
                n = caa.Category_code;
                DataTable dt2 = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and Category_code =" + n + " and Creature_year like'" + txtbyCreature_year.Text + "%'");
                dgProduct.DataSource = dt2;
            }
          
        }

        private void cmbCategory_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCategory_name.SelectedValue == null)
            {
                DataTable dt = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and  Creature_year like'" + txtbyCreature_year.Text + "%'");
                dgProduct.DataSource = dt;
            }
            else
            {
                tblca.Find(cmbCategory_name.SelectedValue);
                Category caa = tblca.GetCurrentRow();
                n = caa.Category_code;
                DataTable dt2 = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and Category_code =" + n + " and Creature_year like'" + txtbyCreature_year.Text + "%'");
                dgProduct.DataSource = dt2;
            }
        }

        private void cmbCategory_name_TextChanged(object sender, EventArgs e)
        {
            if (cmbCategory_name.Text =="")
            {
                DataTable dt = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and  Creature_year like'" + txtbyCreature_year.Text + "%'");
                dgProduct.DataSource = dt;
            }
            else
            {
                tblca.Find(cmbCategory_name.SelectedValue);
                Category caa = tblca.GetCurrentRow();
                n = caa.Category_code;
                DataTable dt2 = tblp.SelectWhere("Product_name like'" + txtbyProduct_name.Text + "%' and product_code like'" + txtbyProduct_code.Text + "%' and Category_code =" + n + " and Creature_year like'" + txtbyCreature_year.Text + "%'");
                dgProduct.DataSource = dt2;
            }
        }
    }
}