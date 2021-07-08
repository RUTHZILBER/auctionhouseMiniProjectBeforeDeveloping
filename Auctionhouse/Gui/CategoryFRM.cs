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
    public partial class CategoryFRM : Form
    {
       

        private  Category ca;
        private CategoryDB tblca;

        public CategoryFRM()
        {
            tblca = new CategoryDB();
            ca = tblca.GetCurrentRow();
            InitializeComponent();
            Updatefields(ca);
        }

        private void Updatefields(Category ca)
        {
            if (tblca.Size() > 0)
            {
                txtCategory_code.Text = ca.Category_code.ToString();
                txtCategory_name.Text = ca.Category_name.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            Category ca = new Category();
            DataRow[] arrca = tblca.Filter("category_name='" + txtCategory_name.Text.ToString() + "'");
            if (arrca.Length != 0)
                MessageBox.Show("קטגוריה זו כבר קימת","שגיאת הוספרה",MessageBoxButtons.OK);
            else
            {
                if(CreateFields(ca))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף קטגוריה זו", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblca.AddNew(ca);
                        NotPossible();
                    }
                }
            }
        }

        private void Possible()
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Visible = false;
            txtCategory_name.ReadOnly = false;
        }

        private void NotPossible()
        {
            
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnNew.Visible = true;
            txtCategory_name.ReadOnly = true;

        }
        private bool CreateFields(Category ca)

        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                ca.Category_code = (Convert.ToInt32(txtCategory_code.Text));

            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtCategory_code, ex.Message);
                ok = false;

            }

            try
            {
                ca.Category_name = (txtCategory_name.Text);

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtCategory_name, ex.Message);

            }
           return ok;

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

        private void CategoryFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            tblca = new CategoryDB();

            txtCategory_code.Text = tblca.GetKey().ToString();
            txtCategory_name.Text = "";
            Possible();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblca.GoToFirst();
            ca = tblca.GetCurrentRow();
            Updatefields(ca);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblca.MovePrev();
            ca = tblca.GetCurrentRow();
            Updatefields(ca);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblca.MoveToNext();
            ca = tblca.GetCurrentRow();
            Updatefields(ca);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblca.GoToLast();
            ca = tblca.GetCurrentRow();
            Updatefields(ca);
        }

        private void txtCategory_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCategory_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
