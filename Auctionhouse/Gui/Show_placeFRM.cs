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
    public partial class Show_placeFRM : Form
    {
        private Show_placeDB tblsp;
        private HoursDB tblh;
        private Day_kindDB tbld;
        private AuctionhousesDB tbla;
        private Show_place sp;
        private Hours h;
        private bool FlagUpdate;
        private bool FlagAdd;

        public Show_placeFRM()
        {
            InitializeComponent();
            tbla = new AuctionhousesDB();
            tbld = new Day_kindDB();
            tblh = new HoursDB();
            tblsp = new Show_placeDB();
            sp = new Show_place();
            h = new Hours();
            sp = tblsp.GetCurrentRow();
            h = tblh.GetCurrentRow();
            panel1.Visible = true;
            panel2.Visible = false;
            btnSave.Visible = false;
            cmbAuctionhouse_code.DataSource = tbla.GetTable();
            cmbAuctionhouse_code.DisplayMember = "Auctionhouse_name";
            cmbAuctionhouse_code.ValueMember = "Auctionhouse_code";
            UpdateFields(sp);
        }

        public Show_placeFRM(string key)
        {
            InitializeComponent();
            tbla = new AuctionhousesDB();
            tbld = new Day_kindDB();
            tblh = new HoursDB();
            tblsp = new Show_placeDB();
            tblsp.Find(key);
            sp = new Show_place();
            h = new Hours();
            panel1.Visible = true;
            panel2.Visible = false;
            btnSave.Visible = false;
            cmbAuctionhouse_code.DataSource = tbla.GetTable();
            cmbAuctionhouse_code.DisplayMember = "Auctionhouse_name";
            cmbAuctionhouse_code.ValueMember = "Auctionhouse_code";
            UpdateFields(sp);

            
        }

        private void UpdateFields(Show_place sp)
        {
            if(tblsp.Size()>0)
            {
                txtAddress.Text = sp.Address;
                txtShow_place_name.Text = sp.Show_place_name;
                chkStatus.Checked = sp.Status;
                txtCity.Text = sp.City;
                txtShow_place_code.Text = sp.Show_place_code.ToString();
                cmbAuctionhouse_code.SelectedValue = sp.Auctionhouse_code.ToString();
                dgShow_place.DataSource = tblsp.SelectMore("select sp.Show_place_code,d.name_day, FormatDateTime(h.o_hour,4) as a, FormatDateTime(h.s_hour,4) as b from day_kind d, hours h, show_place sp where sp.Show_place_code=h.Show_place_code and d.day_kind_code=h.day_kind_code and sp.Show_place_code=" + Convert.ToInt32( sp.Show_place_code)+" order by d.day_kind_code"+"");
                chkStatus.Checked = (sp.Status.Equals(true));

                if (sp.Status == true)
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
                txtAddress.Text = "";
                txtShow_place_name.Text = "";
                txtCity.Text = "";
                txtShow_place_code.Text = "";
                cmbAuctionhouse_code.Text = "";
                chkStatus.Checked = false;
            }

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
        private void Show_placeFRM_Load(object sender, EventArgs e)
        {
            
        }

        
        private void Possible() //בלחיצה על חדש ועדכן
        {
            btnBegin.Visible = false;
            btnUpdate.Visible = false;
            btnCancel.Visible = true;
            btnSearch.Visible =false;
            btnSave.Visible = true;
            btnDel.Visible = true;
            btnNew.Visible = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            chkStatus.Enabled = false;
            cmbAuctionhouse_code.Enabled = true;
            txtShow_place_name.ReadOnly = false;
            btnPrev.Visible = false;
            btnFirst.Visible = false;
            btnNext.Visible = false;
            btnLast.Visible = false;
            btnRe.Visible = false;
            btnDel.Visible = false;

        }
       
      
       
     
      
        
        private void NotPossible()//הטופס במצב דפדוף בלחיצה על אשור ובטול
        {   FlagAdd= false;
            FlagUpdate = false;
            btnNew.Visible = true;
            btnCancel.Visible = false;
            btnBegin.Visible = true;
            btnUpdate.Visible= true;
            btnSearch.Visible = false;
            btnSave.Visible = false;
            btnDel.Visible = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtShow_place_code.ReadOnly = true;
            cmbAuctionhouse_code.Enabled = false;
            txtShow_place_name.ReadOnly = true;
            chkStatus.Enabled = false;
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

      




       
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool y = true;

            if (cmbName_day.Text == ""||(Convert.ToInt32(dtpS_hour.Value.Hour) <= Convert.ToInt32(dtpO_hour.Value.Hour)))
                {
                y = false;
                cmbName_day.Text = "";
                dtpO_hour.Text = "";
                dtpS_hour.Text = "";
                errorProvider1.SetError(dtpS_hour, "");
                }
            if(tblh.Find(txtShow_place_code.Text,cmbName_day.SelectedValue)==true)
            {
                errorProvider1.SetError(cmbName_day, "זמני פתיחת יום זה רשומים כבר לגבי אולם התצוגה הנוכחי");
                y = false;
                dtpO_hour.Text = "";
                dtpS_hour.Text = "";
                cmbName_day.Text = "";

            }

            if(y==true)
            {
                Hours h = new Hours();
                if(CreatFields(h))
                { 
                tblh.AddNew(h);
                
                

                dg.DataSource = tblsp.SelectMore("select sp.Show_place_code,d.name_day, FormatDateTime(h.o_hour,4) as a, FormatDateTime(h.s_hour,4) as b from day_kind d, hours h, show_place sp where sp.Show_place_code=h.Show_place_code and d.day_kind_code=h.day_kind_code and sp.Show_place_code=" + Convert.ToInt32(sp.Show_place_code) + " order by d.day_kind_code"  + "");
                cmbName_day.Text = "";
                dtpO_hour.Text = "";
                dtpS_hour.Text = "";
                }

            }



            }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblsp.GoToFirst();
            sp = tblsp.GetCurrentRow();
            UpdateFields(sp);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblsp.MovePrev();
            sp = tblsp.GetCurrentRow();
            UpdateFields(sp);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblsp.MoveToNext();
            sp = tblsp.GetCurrentRow();
            UpdateFields(sp);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblsp.GoToLast();
            sp = tblsp.GetCurrentRow();
            UpdateFields(sp);
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtShow_place_code.Text = tblsp.GetKey().ToString();
            btnCancel.Visible = true;
            chkStatus.Checked = true;
            txtShow_place_name.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            dg.DataSource = tblh.SelectWhere("show_place_code="+txtShow_place_code.Text+"");
            cmbAuctionhouse_code.DataSource = tbla.GetTable();
            cmbAuctionhouse_code.DisplayMember = "auctionhouse_name";
            cmbAuctionhouse_code.ValueMember = "auctionhouse_code";
            cmbAuctionhouse_code.Text = "";
            dgShow_place.DataSource = tblsp.SelectMore("select sp.Show_place_code,d.name_day, FormatDateTime(h.o_hour,4) as a, FormatDateTime(h.s_hour,4) as b from day_kind d, hours h, show_place sp where sp.Show_place_code=h.Show_place_code and d.day_kind_code=h.day_kind_code and sp.Show_place_code=" + Convert.ToInt32(sp.Show_place_code) + " order by d.day_kind_code");
            cmbName_day.DataSource = tbld.GetTable();
            cmbName_day.DisplayMember = "name_day";
            cmbName_day.ValueMember = "day_kind_code";
            panel1.Visible = false;
            Possible();
            btnSave.Visible = true;
            FlagAdd =true ;
            FlagUpdate = false;
            btnSave.Visible = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Show_place xsp = new Show_place();
           
            
            if(FlagUpdate==true)
            {
                if (CreatFields(xsp) == true)
                {
                    DialogResult r = MessageBox.Show("?האם לעדכן אולם תצוגה זה", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (r == DialogResult.Yes)
                    {
                        tblsp.UpdateRow(sp);           
                        btnSave.Enabled = false;
                        btnFinalOk.Enabled = true;
                        panel2.Visible = true;
                        NotPossible();
                        btnUpdate.Visible = false;
                        btnSearch.Visible = true;

                    }
                }
            }

            if(FlagAdd==true)
            {
                if (CreatFields(sp) == true)
                {
                    DialogResult r = MessageBox.Show("?האם להוסיף אולם תצוגה זה", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (r == DialogResult.Yes)
                    {


                        tblsp.AddNew(sp);
                        btnSave.Enabled = false;
                        btnFinalOk.Enabled = true;
                        panel2.Visible = true;
                        NotPossible();
                        btnUpdate.Visible = false;
                        btnSearch.Visible =true;
                    }
                }
            }
            

            
            
                   
                   

        }
        private bool CreatFields(Show_place sp)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                sp.City = txtCity.Text;
            }
            catch(Exception e)
            {
                errorProvider1.SetError(txtCity, e.Message);
                ok = false;
            }

            try
            {
                sp.Address = txtAddress.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(txtAddress, e.Message);
                ok = false;
            }

            sp.Auctionhouse_code = Convert.ToInt32(cmbAuctionhouse_code.SelectedValue);

            try
            {
                sp.Show_place_code = Convert.ToInt32(txtShow_place_code.Text);
            }
            catch (Exception e)
            {
                errorProvider1.SetError(txtShow_place_code, e.Message);
                ok = false;
            }
            try
            {
                sp.Show_place_name= txtShow_place_name.Text;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(txtShow_place_name, e.Message);
                ok = false;
            }

            sp.Status = (chkStatus.Checked == true);
            return ok;

        }

        private bool CreatFields(Hours h)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                h.Show_place_code= Convert.ToInt32(txtShow_place_code.Text);
            }
            catch (Exception e)
            {
                errorProvider1.SetError(txtShow_place_code, e.Message);
                ok = false;
            }
            h.Day_kind_code = Convert.ToInt32(cmbName_day.SelectedValue);
            try
            {
                h.O_hour = dtpO_hour.Value;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(dtpO_hour, e.Message);
                ok = false;
            }
            try
            {
                h.S_hour = dtpS_hour.Value;
            }
            catch (Exception e)
            {
                errorProvider1.SetError(dtpS_hour, e.Message);
                ok = false;
            }

            if (chkStatus.Checked == true)
                sp.Status = true;
            else
                sp.Status = false;
           
            return ok;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchShow_place fsp = new FrmSearchShow_place();
            fsp.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tblh.Find(dg.CurrentRow.Cells["column5"], dg.CurrentRow.Cells["column6"]);
            Hours h = tblh.GetCurrentRow();
            tblh.DeleteCurrentRow();
            dg.DataSource = tblh.SelectMore("select sp.Show_place_code,d.name_day, FormatDateTime(h.o_hour,4) as a, FormatDateTime(h.s_hour,4) as b from day_kind d, hours h, show_place sp where sp.Show_place_code=h.Show_place_code and d.day_kind_code=h.day_kind_code and sp.Show_place_code=" + Convert.ToInt32(sp.Show_place_code) + " order by d.day_kind_code"+"");
            cmbName_day.Text = "";
            dtpO_hour.Text = "";
            dtpS_hour.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtShow_place_code.Text!="")
            {
                dg.DataSource = tblh.SelectMore("select sp.Show_place_code,d.name_day, FormatDateTime(h.o_hour,4) as a, FormatDateTime(h.s_hour,4) as b from day_kind d, hours h, show_place sp where sp.Show_place_code=h.Show_place_code and d.day_kind_code=h.day_kind_code and sp.Show_place_code=" + Convert.ToInt32(sp.Show_place_code) + " order by d.day_kind_code"+"");

                cmbAuctionhouse_code.DataSource = tbla.GetTable();//האם יתכן לעדכן לאולם תצוגה בית מכירות אחר, אם לא מחיקת 3 שורות אלה
                cmbAuctionhouse_code.DisplayMember = "Auctionhouse_name";
                cmbAuctionhouse_code.ValueMember = "Auctionhouse_code";

                cmbName_day.DataSource = tbld.GetTable();
                cmbName_day.DisplayMember = "name_day";
                cmbName_day.ValueMember = "day_kind_code";
                panel1.Visible = false;
                panel2.Visible = true;

                cmbName_day.Text = "";
                dtpO_hour.Text = "";
                dtpS_hour.Text = "";
                Possible();
                FlagAdd = false;
                FlagUpdate = true;
                cmbAuctionhouse_code.Enabled = false;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtShow_place_code.Text != "")
            {
                tblsp.Find(txtShow_place_code.Text);
                Show_place sp = tblsp.GetCurrentRow();
                int a = sp.Show_place_code;
                SaleDB tbls = new SaleDB();
                DataTable dt1 = tbls.SelectWhere("datediff('d',cdate(deadline),cdate('" + DateTime.Today + "'))<0 and show_place_code="+a+"");
                if (dt1.Rows.Count>0)
                    MessageBox.Show("לא ניתן למחק אולם תצוגה בו מוצעים למכירה מוצרים כרגע");
                else
                { 
                  if (sp.Status == true)
                  {
                    DialogResult r = MessageBox.Show("האם למחוק אולם תצוגה זה", "אשור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        sp = tblsp.GetCurrentRow();
                        sp.Status = false;
                        tblsp.GetCurrentRow();
                        tblsp.UpdateRow(sp);
                        UpdateFields(sp);
                        NotPossible();
                        btnRe.Visible = true;
                        btnDel.Visible = false;
                    }
                  }
                }

            }
        }

        private void btnFinalOk_Click(object sender, EventArgs e)
        {
            tblsp.Find(txtShow_place_code.Text);
            Show_place sp = tblsp.GetCurrentRow();
            tblsp.UpdateRow(sp);
            panel2.Visible = false;
            panel1.Visible = true;
            btnSave.Visible = true; ;
            btnSave.Enabled = true;
            btnNew.Visible = true;
            UpdateFields(sp);
            btnUpdate.Visible = true;
        }

        private void cmbAuctionhouse_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            NotPossible();
            panel1.Visible = true;
            btnNew.Visible = true;
            btnUpdate.Visible = true;
            UpdateFields(sp);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgShow_place_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            Show_place sp1 = tblsp.GetCurrentRow();
            if (sp1.Status == false)
            {
                DialogResult r = MessageBox.Show("האם לשחזר אולם תצוגה זה מארכיון", "אשור שחזור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    sp1.Status = true;
                    tblsp.UpdateRow(sp1);
                    btnRe.Visible = false;
                    btnDel.Visible = true;
                    UpdateFields(sp1);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dal.DealWithReport("op", "show_place_code=" + Convert.ToInt32(txtShow_place_code.Text) + "");
        }
    }
}