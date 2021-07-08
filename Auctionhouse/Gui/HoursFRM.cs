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
    public partial class HoursFRM : Form
    {
        

        private Hours h;
        private HoursDB tblh;
        private Day_kindDB tbld;
        private bool flagAdd;
        private bool flagUpdate;



        public HoursFRM()
        {
            InitializeComponent();
            tbld = new Day_kindDB();
            tblh = new HoursDB();
            cmbDay_kind_code.DataSource = tbld.GetTable();
            cmbDay_kind_code.DisplayMember = "mame_day";
            cmbDay_kind_code.ValueMember = "day_kind_code";
            h = tblh.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            Updatefields(h);


        }

        public HoursFRM(string key)
        {
            tblh = new HoursDB();
            tblh.Find(key);
            h = tblh.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            InitializeComponent();
            Updatefields(h);


        }

        private void Updatefields(Hours h)
        {
            if (tblh.Size() > 0)
            {
                txtShow_place_code.Text = h.Show_place_code.ToString();
                cmbDay_kind_code.Text = h.Day_kind_code.ToString();
                dtPO_hour.Value = h.O_hour;
                dtPS_hour.Value = h.O_hour;



            }

            else
            {
                txtShow_place_code.Text = "";
                cmbDay_kind_code.Text = "";
                dtPO_hour.Text = "";
                dtPS_hour.Text = "";

            }
        }

        private void Possible()
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Visible = false;
            btnUpdate.Visible = false;
            txtShow_place_code.ReadOnly = false;
            cmbDay_kind_code.Enabled= false;
            dtPO_hour.Enabled = false;
            dtPS_hour.Enabled = false;


        }

        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnNew.Visible = true;
            btnUpdate.Visible = true;
            txtShow_place_code.ReadOnly = true;
            cmbDay_kind_code.Enabled = true;
            dtPO_hour.Enabled = true;
            dtPS_hour.Enabled = true;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (flagUpdate == true)
                if (CreateFields(h))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן סוגי שעות אלו", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblh.UpdateRow(h);
                        NotPossible();
                    }
                }
            if (flagAdd == true)
            {
                Client c = new Client();
                DataRow[] arr = tblh.Filter("show_place_code='" + txtShow_place_code.Text.ToString() + "'");
                if (arr.Length != 0)
                    MessageBox.Show("סוג שעות זה כבר קים", "שגיאת הוספה", MessageBoxButtons.OK);
                else
                    if (CreateFields(h))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף סוג שעות זה", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {

                        tblh.AddNew(h);
                        NotPossible();
                    }
                }
            }
        }
        private bool CreateFields(Hours h)

        {
            bool ok = false;
            errorProvider1.Clear();
            try
            {
                h.Show_place_code = txtShow_place_code.Text;


            }



            catch (Exception ex)
            {

                errorProvider1.SetError(txtShow_place_code, ex.Message);
                ok = false;

            }

            try
            {
                h.Day_kind_code = cmbDay_kind_code.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(cmbDay_kind_code, ex.Message);

            }

            try
            {
                h.O_hour = dtPO_hour.Value;

            }

            catch (Exception ex)

            {
                ok = false;
                errorProvider1.SetError(dtPO_hour, ex.Message);

            }

            try
            {
                h.S_hour = dtPO_hour.Value;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(dtPO_hour, ex.Message);

            }

           
            return ok;

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Begin b = new Begin();
            b.Show();
            this.Hide();
        }

        private void txtShow_place_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoursFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblh.GoToFirst();
            h = tblh.GetCurrentRow();
            Updatefields(h);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblh.MovePrev();
            h = tblh.GetCurrentRow();
            Updatefields(h);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblh.MoveToNext();
            h = tblh.GetCurrentRow();
            Updatefields(h);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblh.GoToLast();
            h = tblh.GetCurrentRow();
            Updatefields(h);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            flagAdd = true;
            flagUpdate = false;
            txtShow_place_code.ReadOnly = false;
            cmbDay_kind_code.Text = "";
            dtPS_hour.Text = "";
            dtPO_hour.Text = "";
            Possible();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק שעה זו", "אשור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                h = tblh.GetCurrentRow();
                tblh.UpdateRow(h);
                NotPossible();

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            Possible();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }
    }
}
