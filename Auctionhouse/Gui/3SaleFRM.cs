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
    public partial class Sale3FRM : Form
    {
        private SaleDB tbls;
        private Sale s;
        private DateTime d1;
        private Sale_offerDB tblso;
        private Sale_offer so;

        private ProductDB tblp;
        private Product p;
        private Show_placeDB tblsp;

        private ClientDB tblcl;

        private CategoryDB tblca;

        private AuctionhousesDB tbla;

        private bool flagAdd;
        private bool flagUpdate;
        private bool flagPush;





        public Sale3FRM()//פעולה בונה א
        {
            InitializeComponent();
            tbls = new SaleDB();
            tblso = new Sale_offerDB();
            tblp = new ProductDB();
            tblsp = new Show_placeDB();
            tblcl = new ClientDB();
            tblca = new CategoryDB();
            tbla = new AuctionhousesDB();
            s = new Sale();
            s = tbls.GetCurrentRow();
            so = new Sale_offer();

            panel2.Visible = false;


            //מה עם לקוח זוכה מקומבובוקס? האם גם לו ליצור שאיבה של שלש שורות או רק אח""כ
            cmbShow_place_code.DataSource = tblsp.GetTable();
            cmbShow_place_code.DisplayMember = "Show_place_name";
            cmbShow_place_code.ValueMember = "Show_place_code";

            cmbProduct_code.DataSource = tblp.SelectWhere("status=" + true + "");
            cmbProduct_code.DisplayMember = "product_name";
            cmbProduct_code.ValueMember = "product_code";

            cmbIdClient.DataSource = tblcl.GetTable();
            cmbIdClient.DisplayMember = "id";
            cmbIdClient.ValueMember = "id";

            Updatefields(s);

        }

        public Sale3FRM(string key)//פעולה בונה ב עבור החזרה מהחפוש
        {
            InitializeComponent();
            tbls = new SaleDB();
            tblso = new Sale_offerDB();
            tblp = new ProductDB();
            tblsp = new Show_placeDB();
            tblcl = new ClientDB();
            tblca = new CategoryDB();
            tbla = new AuctionhousesDB();
            s = new Sale();
            tbls.Find(key);
            s = tbls.GetCurrentRow();
            so = new Sale_offer();
            panel2.Visible = false;

            //מה עם לקוח זוכה מקומבובוקס? האם גם לו ליצור שאיבה של שלש שורות או רק אח""כ
            cmbShow_place_code.DataSource = tblsp.GetTable();
            cmbShow_place_code.DisplayMember = "Show_place_name";
            cmbShow_place_code.ValueMember = "Show_place_code";

            cmbProduct_code.DataSource = tblp.GetTable();
            cmbProduct_code.DisplayMember = "product_name";
            cmbProduct_code.ValueMember = "product_code";

            cmbIdClient.DataSource = tblcl.GetTable();
            cmbIdClient.DisplayMember = "id";
            cmbIdClient.ValueMember = "id";
            Updatefields(s);

        }

        public void Updatefields(Sale s)
        {
           
            if (tbls.Size() > 0)
            {
               
                    txtSale_code.Text = s.Sale_code.ToString();
                    cmbProduct_code.SelectedValue = s.Product_code.ToString();
                    cmbShow_place_code.SelectedValue = s.Show_place_code.ToString();
                    txtFirst_price.Text = s.FirstPrice.ToString();
                    dtpStart_date.Text = s.Start_date.ToString();
                    txtLast_price.Text = s.LastPrice.ToString();
                    dtpDeadline.Text = s.Deadline.ToString();
               



            }
            else
            {
                txtCost.Text = "";
                txtFirst_price.Text = "";
                txtSale_code.Text = "";
                cmbIdClient.Text = "";
                cmbShow_place_code.Text = "";

            }


        }

        private bool CreateFields(Sale s)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                s.Sale_code = Convert.ToInt32(txtSale_code.Text.ToString());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSale_code, ex.Message);
                ok = false;
            }

            s.Product_code = Convert.ToInt32(cmbProduct_code.SelectedValue);
            if (cmbProduct_code.Text != "")
                s.Show_place_code = Convert.ToInt32(cmbShow_place_code.SelectedValue);

            else
            {
                errorProvider1.SetError(cmbProduct_code, "בחר מוצר");
                ok = false;
            }
            try
            {
                s.FirstPrice = Convert.ToDouble(txtFirst_price.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFirst_price, ex.Message);
                ok = false;
            }

            try
            {
                s.Start_date = dtpStart_date.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpStart_date, ex.Message);
                ok = false;
            }

            try
            {
                s.LastPrice = Convert.ToDouble(txtLast_price.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLast_price, ex.Message);
                ok = false;
            }

            try
            {
                if (flagPush == true)
                {
                    if (dtpDeadline.Value.DayOfYear >= d1.DayOfYear)
                    {
                        s.Deadline = dtpDeadline.Value;
                    }
                    else
                    {
                        errorProvider1.SetError(dtpDeadline, "לא נתן להקדים מועד סיום מכירה");
                        ok = false;
                    }
                }
                else
                    s.Deadline = dtpDeadline.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpDeadline, ex.Message);
                ok = false;
            }

            return ok;
        }
        private bool CreateFields(Sale_offer so)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                so.Sale_code = Convert.ToInt32(txtSale_code.Text.ToString());
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSale_code, ex.Message);
                ok = false;
            }

            so.Id = cmbIdClient.SelectedValue.ToString();

            try
            {
                so.Date_ = (dtpDate_.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpDate_, ex.Message);
                ok = false;
            }

            try
            {
                so.Tim = dtpTim.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dtpTim, ex.Message);
                ok = false;
            }

            try
            {
                so.Cost = Convert.ToInt32(txtCost.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCost, ex.Message);
                ok = false;
            }


            return ok;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbls.GoToFirst();
            s = tbls.GetCurrentRow();
            Updatefields(s);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            BeginB b = new BeginB();
            b.Show();
            this.Hide();
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSale_code.Text) != 0)
            {
                tbls.Find(txtSale_code.Text);
                s = tbls.GetCurrentRow();
                if (s.Deadline < DateTime.Today.Date && s.LastPrice.ToString() == "")
                {
                    //אפשור מחיקה אם התאריך עבר ואין אפילו הצעה אחת

                    DialogResult r = MessageBox.Show("האם לבטל מכירה זו", "אשור בטול", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (r == DialogResult.Yes)
                    {
                    }
                }

            }
        }

        private void dgSale_offer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tbls.MovePrev();
            s = tbls.GetCurrentRow();
            Updatefields(s);
        }
        private void PossibleHour()
        {

        }
        private void NotPossible()//לאחר לחיצה על אשור או בטול
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbls.MoveToNext();
            s = tbls.GetCurrentRow();
            Updatefields(s);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbls.GoToLast();
            s = tbls.GetCurrentRow();
            Updatefields(s);
        }

        private void btnNew_Click(object sender, EventArgs e)//בלחיצה על מקש "חדש" של מכירה:

        {

            cmbProduct_code.Enabled = true;
            cmbShow_place_code.Enabled = true;
            txtLast_price.ReadOnly = true;
            txtFirst_price.ReadOnly = false;
            dtpDate_.Enabled = true;
            dtpTim.Enabled = true;

            btnSearch.Visible = false;
            btnNewOffer.Visible = false;

            btnBegin.Visible = false;
            panel2.Visible = false;
            cmbShow_place_code.Visible = false;
            //Possible();
            //cmbShow_place_code.DataSource = tblsp.GetTable();
            //cmbShow_place_code.DisplayMember = "Show_place_name";
            //cmbShow_place_code.ValueMember = "Show_place_code";
            flagAdd = true;
            flagUpdate = false;
            txtFirst_price.Text = "";
            //cmbProduct_code.DataSource = tblp.GetTable();
            //cmbProduct_code.DisplayMember = "product_name";
            //cmbProduct_code.ValueMember = "product_code";
            txtFirst_price.Enabled = true;
            dtpDeadline.Enabled = true;
            txtSale_code.Text = tbls.GetKey().ToString();
            dtpStart_date.Text = DateTime.Today.ToString();
            dtpDeadline.Text = DateTime.Today.ToString();
            txtLast_price.Text = "";//איך עושים שתאריך אחרון הוא מחר
                                    /*cmbWin_client_id.DataSource = tblcl.GetTable();*///האם לתת בחירה ללקוח זוכה? הרי בשלב מאוחר יותר, בעדכן

            dtpDate_.Text = DateTime.Today.ToLongDateString();//האם מביא לי רק את תאריך היום 
            dtpTim.Text = DateTime.Today.ToLongTimeString();//האם מביא לי רק את השעה 
            cmbProduct_code.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


        }
    








        

        private bool isCamut(string st)
        {
            if (st != null && ValidateUtilities.IsNum(st) && Convert.ToInt32(st) > Convert.ToInt32(txtLast_price.Text))
                return true;
            return false;
        }

        private bool isok(string st)
        {
            Client c1 = new Client();
            tblcl.Find(cmbIdClient.SelectedValue);
            c1 = tblcl.GetCurrentRow();
            if ((st != "") && (Convert.ToInt32(st) == c1.Code)&&(c1.Status==true)&&((c1.Yffect>dtpDeadline.Value.Year))|| ((c1.Yffect== dtpDeadline.Value.Year)&&(c1.Yffect>dtpDeadline.Value.Month)))
                return true;
            else
            return false;


        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            if (isCamut(txtCost.Text))
            {
                btnOk.Visible = true;
            }
            else
            {
                btnOk.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool x = true;

            if (isCamut(txtCost.Text) == false)
            {

                errorProvider1.SetError(txtCost, "הקש מחיר שטרם הוצע ותקין");
                x = false;
                txtCost.Text = "";


            }

            if (txtCost.Text == "")
            {

            }
            else
            {
                if ((isok(txtCode.Text) == false))
                {

                    errorProvider1.SetError(txtCode, "הקש ססמת משתמש תקינה");
                    x = false;
                    txtCode.Text = "";

                }

            }

            if (x == true)
            {
                DialogResult r = MessageBox.Show("?האם להוסיף הצעה זו", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    Sale_offer so = new Sale_offer();
                    CreateFields(so);
                    tblso.AddNew(so);
                    
                    txtCode.Text = "";
                    tbls.Find(txtSale_code.Text);
                    Sale sx = tbls.GetCurrentRow();
                    sx.LastPrice=so.Cost;
                    tbls.UpdateRow(sx);
                    panel2.Visible = false;
                    Updatefields(sx);
                   
                   
                    //txtLast_price.Text = txtCost.Text;
                    txtCost.Visible = false;
                    btnOk.Visible = false;
                }





            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Sale s = new Sale();
            if (txtSale_code.Text != "")

            {
                //Possible();
               
                cmbIdClient.DataSource = tblcl.GetTable();//???
                
                panel2.Visible = true;
                
                txtCost.Text = "";


                flagAdd = false;
                flagUpdate = true;

            }

        }




        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalOk_Click(object sender, EventArgs e)
        {
            //tbls.Find(txtSale_code.Text);
            //Sale s = tbls.GetCurrentRow();
            //tbls.UpdateRow(s);
            //panel2.Visible = false;
            //panel1.Visible = true;
            //btnSave.Visible = false;
            //btnSave.Enabled = true;
            //btnNew.Visible = true;
            //Updatefields(s);
            //btnUpdate.Visible = true;
        }

        private void btnLast_Click_1(object sender, EventArgs e)
        {
            tbls.GoToLast();
            s = tbls.GetCurrentRow();
            Updatefields(s);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchSale fs = new FrmSearchSale();
            fs.Show();
            this.Hide();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            FrmSearchClient fscl = new FrmSearchClient(this);
            fscl.Show();
            this.Hide();

        }

        public void miluyClient(string x)
        {
            cmbIdClient.SelectedValue = x;
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //FrmSearchProduct fspr = new FrmSearchProduct(this);
            //fspr.Show();

        }

        public void miluyProduct(string x)
        {
            cmbProduct_code.SelectedValue = x;
            Product p2 = new Product();
            tblp.Find(cmbProduct_code.SelectedValue);
            p2 = tblp.GetCurrentRow();
            cmbShow_place_code.DataSource = tblsp.SelectWhere("auctionhouse_code=" + Convert.ToInt32(p2.Auctionhouse_code) + "");
            cmbShow_place_code.Visible = true;
        }

        public void miluyShow_place(string x)
        {
            cmbShow_place_code.SelectedValue = x;
        }

        private void btnSearchShow_place_Click(object sender, EventArgs e)
        {
            //FrmSearchShow_place fssp = new FrmSearchShow_place(this);
            //fssp.Show();
            //this.Hide();
        }

        private void cmbProduct_code_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Product p2 = new Product();
            tblp.Find(cmbProduct_code.SelectedValue);
            p2 = tblp.GetCurrentRow();

            cmbShow_place_code.DataSource = tblsp.SelectWhere("auctionhouse_code=" + Convert.ToInt32(p2.Auctionhouse_code) + "");
            cmbShow_place_code.Visible = true;
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            tbls.MovePrev();
            s = tbls.GetCurrentRow();
            Updatefields(s);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            DataTable dt = tbls.SelectWhere("isnull(Win_client_id)");
            if (dt.Rows.Count > 0)
            {
                tbls.MoveToNext();
                Sale se = tbls.GetCurrentRow();

                while (se.Win_client_id != "")
                {
                    tbls.MoveToNext();
                    se = tbls.GetCurrentRow();
                }



                Updatefields(se);
            }


            else
                MessageBox.Show("אין מכירות שהסתימו");
        }

        private void cmbCodeClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchClient_Click_1(object sender, EventArgs e)
        {
            FrmSearchClient fscl = new FrmSearchClient(this);
            fscl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotPossible();
            Updatefields(s);
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (isok(txtCode.Text))
            {
                txtCost.Visible = true;
            }
            else
                txtCost.Text = "הקש מחיר";
        }

        private void txtLast_price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbShow_place_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduct_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnNewOffer_Click(object sender, EventArgs e)
        {

            if (txtSale_code.Text != "")

            {
                PossibleHour();
               
                cmbIdClient.DataSource = tblcl.GetTable();
                
                panel2.Visible = true;
                txtCost.Visible = false;
                txtCost.Text = "";
                flagUpdate = true;
            }
        }

        private void btnOtherSP_Click(object sender, EventArgs e)
        {
           
         
        }

        private void btnPutoff_Click(object sender, EventArgs e)
        {
          
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtFirst_price_TextChanged(object sender, EventArgs e)
        {
            txtLast_price.Text = txtFirst_price.Text;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Dal.DealWithReport("er", "product_code=" + Convert.ToInt32(cmbProduct_code.SelectedValue) + "");
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            tblp.Find("product_code=" + cmbProduct_code.SelectedValue+"");
            Product uu = tblp.GetCurrentRow();
            string b = uu.Product_code.ToString() ;
            ProductFRM pp = new ProductFRM(b);
            pp.Show();
        }
    }
}