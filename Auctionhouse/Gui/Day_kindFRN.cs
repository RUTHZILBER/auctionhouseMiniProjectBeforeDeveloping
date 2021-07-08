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
    public partial class Day_kindFRN : Form
    {
        

        private Day_kind d;
        private Day_kindDB tbld;
       
        public Day_kindFRN()
        {
            InitializeComponent();
            tbld = new Day_kindDB();
            d = tbld.GetCurrentRow();
            Updatefields(d);
        }

        private void Updatefields(Day_kind d)
        {
            if (tbld.Size() > 0)
            {
                txtDay_kind_code.Text = d.Day_kind_code.ToString();
                txtName_day.Text = d.Name_day;

            }
            else
            {
                txtDay_kind_code.Text ="";
                txtName_day.Text ="";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            Day_kind d = new Day_kind();
            DataRow[] arrd = tbld.Filter("name_day='" + txtName_day.Text.ToString()+ "'");
            if (arrd.Length != 0)
                MessageBox.Show("יום זה כבר קים", "שגיאת הוספה", MessageBoxButtons.OK);
            else
            {
                if (CreateFields(d))
                { 
                    DialogResult r = MessageBox.Show ("האם לעדכן פריט זה", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                  if (r == DialogResult.Yes)
                  {
                    tbld.AddNew(d);
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
            txtName_day.ReadOnly = false;
        }

        private void NotPossible()
        {
           
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnNew.Visible = true;
            txtName_day.ReadOnly = true;

        }
        private bool CreateFields(Day_kind d)

        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                d.Day_kind_code = Convert.ToInt32((txtDay_kind_code.Text));

            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtDay_kind_code, ex.Message);
                ok = false;

            }

            try
            {
                d.Name_day = (txtName_day.Text);

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtName_day, ex.Message);

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

        private void Day_kindFRN_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbld = new Day_kindDB();
            txtDay_kind_code.Text = tbld.GetKey().ToString();
            txtName_day.Text = "";
            Possible();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbld.GoToFirst();
            d = tbld.GetCurrentRow();
            Updatefields(d);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tbld.MovePrev();
            d = tbld.GetCurrentRow();
            Updatefields(d);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbld.MoveToNext();
            d = tbld.GetCurrentRow();
            Updatefields(d);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbld.GoToLast();
            d = tbld.GetCurrentRow();
            Updatefields(d);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_day_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
