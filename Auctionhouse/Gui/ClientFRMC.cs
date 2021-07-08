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
    public partial class ClientFRMC : Form
    {
        

        private Client cl;
        private ClientDB tblcl;
        private bool flagAdd;
        private bool flagUpdate;



        public ClientFRMC()
        {
            InitializeComponent();
            tblcl = new ClientDB();
            cl = tblcl.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            Updatefields(cl);


        }
        public ClientFRMC(string w,bool m)
        {
            InitializeComponent();
            tblcl = new ClientDB();
            cl = tblcl.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            Updatefields(cl);


        }
        public ClientFRMC(bool b)
        {
            InitializeComponent();
            tblcl = new ClientDB();
            cl = tblcl.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            Updatefields(cl);
            flagAdd = true;
            flagUpdate = false;
            txtId.ReadOnly = false;
            txtId.Text = "";
            txtFname.Text = "";
            txtCode.Text = "";
            txtLname.Text = "";
            txtAddress.Text = "";
            txtCredit.Text = "";
            cmbMeffect.Text = "";
            cmbYeffect.Text = "";
            txtPel.Text = "";
            chkStatus.Checked = true;
            Program.cd = txtId.Text;
            Possible();

        }

        public ClientFRMC(string key)
        {
            tblcl = new ClientDB();
            tblcl.Find(key);
            cl = tblcl.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            InitializeComponent();
            Updatefields(cl);


        }
        public ClientFRMC(string key,string i,bool x)
        {
            tblcl = new ClientDB();
            tblcl.Find(key);
            cl = tblcl.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            InitializeComponent();
            Updatefields(cl);
            Possible();
            if(x==true)
            {
                flagAdd = true;
                flagUpdate = false;
                txtId.ReadOnly = false;
                txtId.Text =key;
                txtFname.Text = "";
                txtCode.Text = i;
                txtLname.Text = "";
                txtAddress.Text = "";
                txtCredit.Text = "";
                cmbMeffect.Text = "";
                cmbYeffect.Text = "";
                txtPel.Text = "";
                chkStatus.Checked = true;
                Possible();
            }

                //אם זה חדש


        }

        private void Updatefields(Client cl)
        {
            if (tblcl.Size() > 0)
            {
                txtId.Text = cl.Id;
                txtFname.Text = cl.Fname.ToString();
                txtLname.Text = cl.Lname.ToString();
                txtCode.Text = cl.Code.ToString();
                txtAddress.Text = cl.Address.ToString();
                txtCredit.Text = cl.Credit.ToString();
                cmbMeffect.Text =cl.Meffect.ToString();
                cmbYeffect.Text =cl.Yffect.ToString();
                txtPel.Text = cl.Pel;
                if (cl.Status.Equals(true))
                    chkStatus.Checked = true;
                else
                    chkStatus.Checked = false;
                if (cl.Status == true)
                {

                    btnRe.Visible = false;
                    
                    btnDel.Visible = true;

                }

                else
                {
                    btnRe.Visible = true;
                    btnDel.Visible = false;
                }


            }

            else
            {
                txtId.Text = "";
                txtFname.Text = "";
                txtLname.Text = "";
                txtCode.Text = "";
                txtAddress.Text = "";
                txtCredit.Text = "";
                cmbMeffect.Text = "";
                cmbYeffect.Text = "";
                txtPel.Text = "";
                chkStatus.Checked = false;
            }
        }

       
           
           
                

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (flagUpdate == true)
                if (CreateFields(cl))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן לקוח זה", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblcl.UpdateRow(cl);
                        NotPossible();
                    }
                }
            if (flagAdd == true)
            {
                DataTable dt = tblcl.SelectWhere("code=" + txtCode.Text + "");
                if (dt.Rows.Count == 0)
                {
                    Client cl = new Client();
                    DataRow[] arr = tblcl.Filter("id='" + txtId.Text.ToString() + "'");
                    if (arr.Length != 0)
                        MessageBox.Show("לקוח זה כבר קים", "שגיאת הוספה", MessageBoxButtons.OK);
                    else
                        if (CreateFields(cl))
                    {
                        DialogResult r = MessageBox.Show("האם להוסיף לקוח זה", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {

                            tblcl.AddNew(cl);
                            NotPossible();
                            Program.cd = txtId.Text;
                            btnDel.Visible = true;
                            btnRe.Visible = false;
                        }
                    }


                }

                else
                {
                    errorProvider1.SetError(txtCode,"הקש קוד שאינו בשמוש! ובעל שמונה ספרות");
                }



            }
        }
        private bool CreateFields(Client cl)

        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                cl.Id = txtId.Text;
            }
            
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }

            try
            {
                cl.Fname = txtFname.Text;
            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtFname, ex.Message);

            }

            try
            {
                cl.Lname = txtLname.Text;

            }

            catch (Exception ex)

            {
                ok = false;
                errorProvider1.SetError(txtLname, ex.Message);

            }

            try
            {
                cl.Code = Convert.ToInt32(txtCode.Text);

            }

            catch (Exception ex)

            {
                ok = false;
                errorProvider1.SetError(txtCode, ex.Message);

            }

            try
            {
                cl.Address = txtAddress.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtAddress, ex.Message);

            }

            try
            {
                cl.Credit = txtCredit.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtCredit, ex.Message);

            }

            try
            {
                cl.Meffect = Convert.ToInt32(cmbMeffect.Text.ToString());

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(cmbMeffect, ex.Message);

            }

            try
            {
                cl.Yffect = Convert.ToInt32(cmbYeffect.Text.ToString());

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(cmbYeffect, ex.Message);

            }



            try
            {
                cl.Pel = txtPel.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtPel, ex.Message);

            }
            cl.Status = (chkStatus.Checked == true);


            return ok;

        }

        private void Possible()
        {
            btnSave.Visible = true;
            btnCancel.Visible =true;
            
            btnUpdate.Visible = false;
            txtId.ReadOnly = false;
            txtFname.ReadOnly = false;
            txtLname.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCode.ReadOnly = false;
            txtCredit.ReadOnly = false;
            cmbMeffect.Enabled = true;
            cmbYeffect.Enabled =true;
            txtPel.ReadOnly = false;
            chkStatus.Enabled = false;
           
            btnRe.Visible = false;
            btnDel.Visible = false;


        }

        private void NotPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            

            btnUpdate.Visible = true;
            txtId.ReadOnly = true;
            txtFname.ReadOnly = true;
            txtCode.ReadOnly = true;
            txtLname.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCredit.ReadOnly = true;
            cmbMeffect.Enabled=false;
            cmbYeffect.Enabled = false;
            txtPel.ReadOnly = true;
            btnRe.Visible = true;
            btnDel.Visible = true;
            if (chkStatus.Checked ==true)
            {
                btnRe.Visible = false;
                btnDel.Visible = true;
            }
                
            else
            {
            btnRe.Visible = true;
                btnDel.Visible = false;
            }
                
            chkStatus.Enabled = false;
           


        }



        private void ClientFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            BeginB b = new BeginB();
            b.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchClient dg = new FrmSearchClient();
            dg.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            Possible();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק לקוח זה", "אשור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                cl = tblcl.GetCurrentRow();
                cl.Status = false;
                tblcl.UpdateRow(cl);
                Updatefields(cl);
                NotPossible();
                
                btnRe.Visible = true;

            }


        }

        private void btnFirsrt_Click(object sender, EventArgs e)
        {
            tblcl.GoToFirst();
            cl = tblcl.GetCurrentRow();
            Updatefields(cl);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblcl.MovePrev();
            cl = tblcl.GetCurrentRow();
            Updatefields(cl);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
          
            flagAdd = true;
            flagUpdate = false;
            txtId.ReadOnly = false;
            txtId.Text = "";
            txtFname.Text = "";
            txtCode.Text = "";
            txtLname.Text = "";
            txtAddress.Text = "";
            txtCredit.Text = "";
            cmbMeffect.Text = "";
            cmbYeffect.Text = "";
            txtPel.Text = "";
            chkStatus.Checked = true;
            Possible();
        }

        private void txtCredit_account_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblcl.MoveToNext();
            cl = tblcl.GetCurrentRow();
            Updatefields(cl);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblcl.GoToLast();
            cl = tblcl.GetCurrentRow();
            Updatefields(cl);

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (flagUpdate == true)
                if (CreateFields(cl))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן לקוח זה", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblcl.UpdateRow(cl);
                        NotPossible();
                    }
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
          
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMeffect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRe_Click(object sender, EventArgs e)
        {
             cl = tblcl.GetCurrentRow();
            if (!(cl.Meffect < DateTime.Today.Month && cl.Yffect <= DateTime.Today.Year) || (cl.Meffect > DateTime.Today.Month && cl.Yffect < DateTime.Today.Year))
            {
                if (cl.Status == false)
            {
                DialogResult r = MessageBox.Show("האם לשחזר לקוח זה מארכיון", "אשור שחזור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                        cl.Status = true;
                        tblcl.UpdateRow(cl);
                        Updatefields(cl);
                        btnRe.Visible = false;
                    }
                }

            }
        }
    }

}