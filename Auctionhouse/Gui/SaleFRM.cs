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
    public partial class SaleFRM : Form
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





        public SaleFRM()//פעולה בונה א
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
            //so = tblso.GetCurrentRow(); האם גם את ההצעה למכירה לאתחל על הנוכחי שאולי קים
            panel1.Visible = true;
            panel2.Visible = false;
            btnSave.Visible = false;
            
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

        public SaleFRM(string key)//פעולה בונה ב עבור החזרה מהחפוש
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
            //so = tblso.GetCurrentRow(); האם גם את ההצעה למכירה לאתחל על הנוכחי שאולי קים
            panel1.Visible = true;
            panel2.Visible = false;
            btnSave.Visible = false;

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
                //cmbWin_client_id.Text = s.win////האם גם את הלקוח המנצח? להכניס, הוא לא תמיד הרי
                dgSale_offer.DataSource = tblso.SelectMore("select  so.Sale_code, so.id, so.Date_, FormatDateTime(tim, 4)as a, so.cost from sale_offer so where sale_code=" + txtSale_code.Text + "");

                

             
            }
            else
            {
                txtCost.Text = "";
                txtFirst_price.Text = "";
                txtSale_code.Text = "";
                cmbIdClient.Text = "";
                cmbShow_place_code.Text = "";
                cmbWin_client_id.Text = "";
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
            if(cmbProduct_code.Text !="")
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
                if (dtpDeadline.Value.DayOfYear >= d1.DayOfYear )
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
            Begin b = new Begin();
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

            btnSave.Visible = false;
            btnBegin.Visible = true;
            btnCancel.Visible = false;
            btnNew.Visible = true;

            panel1.Visible = true;
            cmbShow_place_code.Visible =true;
            btnSearchProduct.Visible = false;
            btnPutoff.Visible = true;
            btnOtherSP.Visible = true;
            cmbProduct_code.Enabled = false;
            cmbShow_place_code.Enabled = false;
            txtFirst_price.ReadOnly = true;
            txtLast_price.ReadOnly = true;
           
            //cmbWin_client_id.Enabled = false;
            dtpDeadline.Enabled = false;
            dtpStart_date.Enabled = false;
            btnSearch.Visible = true;
            btnNewOffer.Visible = true;
            flagAdd = false;
            flagPush = false;
            flagUpdate = false;
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
            //    cmbWin_client_id.Enabled = true;
            btnSearch.Visible = false;
            btnNewOffer.Visible = false;
            btnSearchProduct.Visible=true;
 btnSearchProduct.Enabled=true;
            btnSave.Visible = true;
            btnBegin.Visible = false;
            btnCancel.Visible = true;
            btnNew.Visible = false;
            btnPutoff.Visible = false;
            btnOtherSP.Visible = false;
            panel1.Visible = false;
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
          
            dgSale_offer.DataSource = tblso.SelectMore("select  so.Sale_code, so.id, so.Date_, FormatDateTime(tim, 4)as a, so.cost from sale_offer so where sale_code=" + txtSale_code.Text + "");



            dtpDate_.Text = DateTime.Today.ToLongDateString();//האם מביא לי רק את תאריך היום 
            dtpTim.Text = DateTime.Today.ToLongTimeString();//האם מביא לי רק את השעה 
            cmbProduct_code.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Sale s = new Sale();
            if (flagUpdate == true)
            {
                {
                    
                    if ((CreateFields(s) == true))
                       
                    {
                        DialogResult r = MessageBox.Show("?האם לשנות מכירה זו", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                           
                            tbls.UpdateRow(s);

                            NotPossible();


                        }
                    }
                    
                }
            }

            if (flagPush == true)
            {
                {

                    if ((CreateFields(s) == true)&&(d1.Date<s.Deadline.Date))

                    {
                        DialogResult r = MessageBox.Show("?האם לדחות מועד מכירה זו", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {

                            tbls.UpdateRow(s);
                            btnSave.Enabled = false;
                            panel1.Visible = true;
                            panel2.Visible = false;
                            NotPossible();
                            btnSearchClient.Enabled = true;
                            btnSearch.Visible = false;
                            btnSearch.Visible = true;
                            btnSave.Visible = false;
                            btnOtherSP.Visible = true;
                            btnNew.Visible = true;

                        }
                    }

                }
            }

            if (flagAdd == true)
            {
                if (CreateFields(s)
                {
                    DialogResult r = MessageBox.Show("האם להוסיף מכירה זו", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tbls.AddNew(s);
                        btnSave.Visible = false;
                        panel2.Visible = false;
                        panel1.Visible = true;
                        dtpDate_.Enabled = false;
                        dtpTim.Enabled = false;
                        dtpTim.Value = DateTime.Today;
                        btnSearchClient.Enabled = true;
                        btnSearch.Visible = true;
                        btnSave.Visible = false;
                        btnOtherSP.Visible = true;
                        btnNew.Visible = true;
                        tblp.Find(s.Product_code);
                        p = tblp.GetCurrentRow();
                        p.Status = false;
                        tblp.UpdateRow(p);
                    }

                }

            }
         
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
                    btnPutoff.Visible = true;
                    btnOtherSP.Visible = true;
                    txtCode.Text = "";
                    tbls.Find(txtSale_code.Text);
                    Sale sx = tbls.GetCurrentRow();
                    sx.LastPrice=so.Cost;
                    tbls.UpdateRow(sx);
                    panel2.Visible = false;
                    panel1.Visible = true;
                    btnSave.Visible = false;
                    btnSave.Enabled = true;
                    btnNew.Visible = true;
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
                dgSale_offer.DataSource = tblso.SelectWhere("sale_code=" + Convert.ToInt32(txtSale_code.Text) + "");
                cmbIdClient.DataSource = tblcl.GetTable();//???
                panel1.Visible = false;
                panel2.Visible = true;
                btnSave.Visible = true;
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
            FrmSearchProduct fspr = new FrmSearchProduct(this);
            fspr.Show();
          
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
            FrmSearchShow_place fssp = new FrmSearchShow_place(this);
            fssp.Show();
            this.Hide();
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
            tbls.MoveToNext();
            s = tbls.GetCurrentRow();
            Updatefields(s);
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
                dgSale_offer.DataSource = tblso.SelectWhere("sale_code=" + Convert.ToInt32(txtSale_code.Text) + "");
                cmbIdClient.DataSource = tblcl.GetTable();
                panel1.Visible = false;
                panel2.Visible = true;
                btnSave.Visible = false;
                txtCost.Visible = false;
                txtCost.Text = "";
                flagUpdate = true;
            }
        }

        private void btnOtherSP_Click(object sender, EventArgs e)
        {
           
         
            if (txtSale_code.Text != "")

            {

                dgSale_offer.DataSource = tblso.SelectWhere("sale_code=" + Convert.ToInt32(txtSale_code.Text) + "");
                cmbIdClient.DataSource = tblcl.GetTable();
                
                cmbShow_place_code.Enabled = true;
                
                flagAdd = false;
                flagUpdate = true;
                flagPush = false;
                Product p2 = new Product();
                tblp.Find(cmbProduct_code.SelectedValue);
                p2 = tblp.GetCurrentRow();
                cmbShow_place_code.DataSource = tblsp.SelectWhere("auctionhouse_code=" + Convert.ToInt32(p2.Auctionhouse_code) + "");
                cmbShow_place_code.Visible = true;

                btnSearchProduct.Visible = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnNew.Visible = false;
                btnPutoff.Visible = false;
                btnBegin.Visible = false;
                btnOtherSP.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;

            }
        }

        private void btnPutoff_Click(object sender, EventArgs e)
        {
          
            if (txtSale_code.Text != "" && Convert.ToDateTime(dtpDeadline.Value.ToShortDateString())>=Convert.ToDateTime(DateTime.Today.ToShortDateString()))

            {
                btnSearchProduct.Visible = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnNew.Visible = false;
                btnPutoff.Visible = false;
                btnBegin.Visible = false;
                btnOtherSP.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                d1 = dtpDeadline.Value;
                dgSale_offer.DataSource = tblso.SelectWhere("sale_code=" + Convert.ToInt32(txtSale_code.Text) + "");
                cmbIdClient.DataSource = tblcl.GetTable();
                panel1.Visible = false;
                label12.Visible = false;
                dtpDeadline.Enabled = true;
                btnSave.Enabled = true;
                flagAdd = false;
                flagUpdate = false;
                flagPush = true;
                Product p2 = new Product();
                tblp.Find(cmbProduct_code.ValueMember);
                p2 = tblp.GetCurrentRow();
                cmbShow_place_code.DataSource = tblsp.SelectWhere("auctionhouse_code=" + Convert.ToInt32(p2.Category_code) + "");
                cmbShow_place_code.Visible = true;

            }
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
    }
}