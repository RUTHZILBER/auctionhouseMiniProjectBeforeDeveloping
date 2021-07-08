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
    public partial class AuctionhousesFRM : Form
    {

        private Auctionhouses a;//עצמים וטבלאות לטפול בטופס.
        private AuctionhousesDB tbla;
        private CategoryDB tblca;
        private bool flagAdd;
        private bool flagUpdate;
        private ProductDB tblp;
        private Product p;



        public AuctionhousesFRM()//פעולה בונה
        {
            InitializeComponent();
            tbla = new AuctionhousesDB();
            a = tbla.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            tblca = new CategoryDB();
            cmbCategory_code.DataSource = tblca.GetTable();
            cmbCategory_code.DisplayMember = "category_name";
            cmbCategory_code.ValueMember = "category_code";
            Updatefields(a);


        }


        public AuctionhousesFRM(string key)//פעולה בונה המקבלת קוד
        {
            tbla = new AuctionhousesDB();
            tbla.Find(key);
            a = tbla.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            InitializeComponent();
            tblca = new CategoryDB();
            cmbCategory_code.DataSource = tblca.GetTable();
            cmbCategory_code.DisplayMember = "category_name";
            cmbCategory_code.ValueMember = "category_code";
            Updatefields(a);


        }

        private void Updatefields(Auctionhouses a)//מלוי פקדי הטופס
        {
            if (tbla.Size() > 0)
            {
                txtAuctionhouse_code.Text = a.Auctionhouse_code.ToString();
                txtAuctionhouse_name.Text = a.Auctionhouse_name;
                cmbCategory_code.SelectedValue = a.Category_code.ToString();
                txtTel.Text = a.Tel;
                chkStatus.Checked = (a.Status.Equals(true));
                if (a.Status == true)
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
                txtAuctionhouse_code.Text = "";
                txtAuctionhouse_name.Text = "";
                cmbCategory_code.Text = "";
                txtTel.Text = "";
                chkStatus.Checked = false;
            }
        }

        private bool CreateFields(Auctionhouses a)//מלוי ערכי העצם עפ הנתונים שהוקשו לפקדים

        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                a.Auctionhouse_code = Convert.ToInt32(txtAuctionhouse_code.Text);

            }

            catch (Exception ex)
            {

                errorProvider1.SetError(txtAuctionhouse_code, ex.Message);
                ok = false;

            }

            try
            {
                a.Auctionhouse_name = txtAuctionhouse_name.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtAuctionhouse_name, ex.Message);

            }
            
            a.Category_code = Convert.ToInt32(cmbCategory_code.SelectedValue);
        
            try
            {
                a.Tel = txtTel.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtTel, ex.Message);

            }

            a.Status = (chkStatus.Checked == true);
            return ok;

        }
   


        private void Possible()//בלחיצה על חדש ועדכן
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Visible = false;
            btnUpdate.Visible = false;
            txtAuctionhouse_code.ReadOnly = false;
            txtAuctionhouse_name.ReadOnly = false;
            //cmbCategory_code.Enabled=true;
            txtTel.ReadOnly = false;
            chkStatus.Enabled = false;
            btnSearch.Visible = false;
            btnPrev.Visible = false;
            btnFirst.Visible = false;
            btnNext.Visible = false;
            btnLast.Visible = false;
            btnRe.Visible = false;
            btnDel.Visible = false;
         
        }

        private void NotPossible()//בלחיצה על אשור ובטול
        {
            flagAdd = false;
            flagUpdate = false;
            btnSave.Visible = false;
            btnCancel.Visible =false;
            btnNew.Visible = true;
            btnUpdate.Visible = true;
            txtAuctionhouse_code.ReadOnly = true;
            txtAuctionhouse_name.ReadOnly = true;
            cmbCategory_code.Enabled = false;
            txtTel.ReadOnly = true;
            chkStatus.Enabled = false;
            btnSearch.Visible = true;
            btnPrev.Visible = true;
            btnFirst.Visible = true;
            btnNext.Visible = true;
            btnLast.Visible = true;
            if (chkStatus.Checked == true)
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



        private void AuctionhousesFRM_Load(object sender, EventArgs e)
        {

        }

        private void AuctionhousesFRM_Load_1(object sender, EventArgs e)
        {

        }

        private void txtAuctionhouse_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBegin_Click(object sender, EventArgs e)//לחזרה לתפריט ראשי
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

        private void btnFirst_Click(object sender, EventArgs e)//דפדופים, כאן לבית מכירות ראשון
        {
            tbla.GoToFirst();
            a = tbla.GetCurrentRow();
            Updatefields(a);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tbla.MovePrev();
            a = tbla.GetCurrentRow();
            Updatefields(a);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbla.MoveToNext();
            a = tbla.GetCurrentRow();
            Updatefields(a);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbla.GoToLast();
            a = tbla.GetCurrentRow();
            Updatefields(a);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmbCategory_code.Enabled = false;
            if (flagUpdate == true)
                
                if (CreateFields(a))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן בית מכירות זה", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tbla.UpdateRow(a);
                        NotPossible();
                    }
                }
            if (flagAdd == true)
            {
                Auctionhouses a = new Auctionhouses();
                DataRow[] arr = tbla.Filter("Auctionhouse_code='" + txtAuctionhouse_code.Text.ToString() + "'");
                if (arr.Length != 0)
                    MessageBox.Show("בית מכירות זה כבר קים", "שגיאת הוספה", MessageBoxButtons.OK);
                else
                    if (CreateFields(a))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף בית מכירות זה", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {

                        tbla.AddNew(a);
                        NotPossible();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            flagAdd = true;
            flagUpdate = false;
            tbla = new AuctionhousesDB();
            txtAuctionhouse_code.Text=tbla.GetKey().ToString();
            txtAuctionhouse_name.Text = "";
            cmbCategory_code.Text = "";
            txtTel.Text = "";
            chkStatus.Checked = true;
            Possible();
            cmbCategory_code.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            Auctionhouses a1= tbla.GetCurrentRow();
            SaleDB tbls = new SaleDB();
            DataTable dt1 = tbls.SelectMore("select s.* from sale s, show_place sp where s.show_place_code=sp.show_place_code and sp.auctionhouse_code=" +Convert.ToInt32(a.Auctionhouse_code) +"and datediff('d',cdate(deadline),cdate('" + DateTime.Today + "'))<0"+"");
            
            if (dt1.Rows.Count > 0)
                MessageBox.Show("לא ניתן למחק בית מכירות שמציע מכירה פעילה");
            else
            { 
                DialogResult r = MessageBox.Show("האם למחוק בית מכירות זה", "אשור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (r == DialogResult.Yes)
                {
                a = tbla.GetCurrentRow();
                a.Status = false;
                tbla.UpdateRow(a);
                NotPossible();
                a.Status = false;
                Updatefields(a);
                btnRe.Visible = true;

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchAuctionhouss dg = new FrmSearchAuctionhouss();
            dg.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            Possible();
            tblp = new ProductDB();
          
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRe_Click(object sender, EventArgs e)
        {

            Auctionhouses a2 = tbla.GetCurrentRow();
            if (a2.Status == false)
            {
                DialogResult r = MessageBox.Show("האם לשחזר בית מכירות זה מארכיון", "אשור שחזור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                a2.Status = true;
                    tbla.UpdateRow(a2);
                    Updatefields(a2);
                    btnRe.Visible = false;
                }
                
            }
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
