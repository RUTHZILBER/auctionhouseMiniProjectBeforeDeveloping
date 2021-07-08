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
    public partial class Product1FRM : Form
    {


        private Product p;
        private ProductDB tblp;
        private CategoryDB tblca;
        private AuctionhousesDB tbla;
        private bool flagAdd;
        private bool flagUpdate;
        private bool flagAgain;



        public Product1FRM()
        {
            InitializeComponent();
            tblp = new ProductDB();
            tblca = new CategoryDB();
            tbla = new AuctionhousesDB();
            cmbCategory_code.DataSource = tblca.GetTable();
            cmbCategory_code.DisplayMember = "category_name";
            cmbCategory_code.ValueMember = "category_code";
            cmbAuctionhouse_code.DataSource = tbla.GetTable();
            cmbAuctionhouse_code.DisplayMember = "auctionhouse_name";
            cmbAuctionhouse_code.ValueMember = "auctionhouse_code";
            p = tblp.GetCurrentRow();
            flagAdd = false;
            flagUpdate = false;
            flagAgain = false;
            Updatefields(p);
        }

        public Product1FRM(string key)
        {
            tblp = new ProductDB();
            tblp.Find(key);
            tblca = new CategoryDB();
            tbla = new AuctionhousesDB();
            p = tblp.GetCurrentRow();
            flagAdd = false;
            flagAgain = false;
            flagUpdate = false;
            InitializeComponent();
            Updatefields(p);
            cmbCategory_code.DataSource = tblca.GetTable();
            cmbCategory_code.DisplayMember = "category_name";
            cmbCategory_code.ValueMember = "category_code";
            cmbAuctionhouse_code.DataSource = tbla.GetTable();
            cmbAuctionhouse_code.DisplayMember = "auctionhouse_name";
            cmbAuctionhouse_code.ValueMember = "auctionhouse_code";


        }

        private void Updatefields(Product p)
        {
            if (tblp.Size() > 0)
            {
                txtProduct_code.Text = p.Product_code.ToString();
                txtProduct_name.Text = p.Product_name.ToString();
                cmbCategory_code.SelectedValue = p.Category_code.ToString();
                cmbAuctionhouse_code.SelectedValue = p.Auctionhouse_code.ToString();
                txtPicture.Text = p.Picture.ToString();
                txtCreature_year.Text = p.Creature_year.ToString();
                chkStatus.Checked = (p.Status.Equals(true));
                if (p.Status == true)
                {
                    btnRe.Visible = false;
                    btnDel.Visible = true;
                    btnAgain.Visible = false;
                    btnUpdate.Visible = true;

                }


                else
                {
                    btnRe.Visible = true;
                    btnDel.Visible = false;
                    btnAgain.Visible = true;
                    btnUpdate.Visible = false;
                }
                try
                {
                    txtNo.Visible = false;
                    string path = System.IO.Directory.GetCurrentDirectory();
                    int x = path.IndexOf("\\bin");
                    path = path.Substring(0, x) + p.Picture;
                    pictureBox1.Image = Image.FromFile(path);
                    pictureBox1.Visible = true;
                }
                catch
                {
                    txtNo.Visible = true;
                    pictureBox1.Visible = false;
                }
            }

            else
            {
                txtProduct_code.Text = "";
                txtProduct_name.Text = "";
                cmbCategory_code.Text = "";
                cmbAuctionhouse_code.Text = "";
                //txtPicture.Text = "";
                txtCreature_year.Text = "";

            }
        }

        private void Possible()//בלחיצה על חדש ועדכן
        {
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnNew.Visible = false;
            btnUpdate.Visible = false;
            txtProduct_code.ReadOnly = false;
            txtProduct_name.ReadOnly = false;
            cmbCategory_code.Enabled = false;
            cmbAuctionhouse_code.Enabled = false;
            txtPicture.ReadOnly = false;
            txtCreature_year.ReadOnly = false;
            btnP.Enabled = true;
            chkStatus.Enabled = false;
            btnSearch.Visible = false;
            btnPrev.Visible = false;
            btnFirst.Visible = false;
            btnNext.Visible = false;
            btnLast.Visible = false;
            btnRe.Visible = false;
            btnDel.Visible = false;
            btnAgain.Visible = false;
            btnP.Visible = true;
        }







        private void NotPossible()//בלחיצה על אשור ובטול
        {
            flagAdd = false;
            btnAgain.Visible = true;
            btnP.Visible = false;
            flagAgain = false;
            flagUpdate = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnP.Enabled = false;
            btnNew.Visible = true;
            btnUpdate.Visible = true;
            txtProduct_code.ReadOnly = true;
            txtProduct_name.ReadOnly = false;
            cmbCategory_code.Enabled = false;
            cmbAuctionhouse_code.Enabled = false;
            txtPicture.ReadOnly = true;
            txtCreature_year.ReadOnly = true;
            chkStatus.Enabled = false;
            btnPrev.Visible = true;
            btnFirst.Visible = true;
            btnNext.Visible = true;
            btnLast.Visible = true;
            btnSearch.Visible = true;
            if (p.Status == true)
            {
                btnRe.Visible = false;
                btnDel.Visible = true;
                btnAgain.Visible = false;
                btnUpdate.Visible = true;

            }


            else
            {
                btnRe.Visible = true;
                btnDel.Visible = false;
                btnAgain.Visible = true;
                btnUpdate.Visible = false;
            }




        }




        private bool CreateFields(Product p)

        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                p.Product_code = Convert.ToInt32(txtProduct_code.Text);


            }



            catch (Exception ex)
            {

                errorProvider1.SetError(txtProduct_code, ex.Message);
                ok = false;

            }

            try
            {
                p.Product_name = txtProduct_name.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtProduct_name, ex.Message);

            }
            p.Auctionhouse_code = Convert.ToInt32(cmbAuctionhouse_code.SelectedValue);
            p.Category_code = Convert.ToInt32(cmbCategory_code.SelectedValue);


            try
            {
                p.Picture = txtPicture.Text;

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtPicture, ex.Message);

            }

            try
            {
                p.Creature_year = Convert.ToInt32(txtCreature_year.Text);

            }

            catch (Exception ex)
            {
                ok = false;
                errorProvider1.SetError(txtCreature_year, ex.Message);

            }
            p.Status = (chkStatus.Checked == true);

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

        private void ProductFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (flagUpdate == true)
                if (CreateFields(p))
                {
                    DialogResult r = MessageBox.Show("האם לעדכן מוצר זה", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblp.UpdateRow(p);
                        Updatefields(p);
                        NotPossible();
                    }
                }
            if (flagAdd == true)
            {
                Product p = new Product();
                DataRow[] arr = tblp.Filter("product_code='" + txtProduct_code.Text.ToString() + "'");
                if (arr.Length != 0)
                    MessageBox.Show("מוצר זה כבר קים", "שגיאת הוספה", MessageBoxButtons.OK);
                else
                    if (CreateFields(p))
                {
                    DialogResult r = MessageBox.Show("האם להוסיף מוצר זה", "אשור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {

                        tblp.AddNew(p);
                        NotPossible();
                        Updatefields(p);
                    }
                }
            }

            //if (flagUpdate == true)

            //    if (CreateFields(a))
            //    {
            //        DialogResult r = MessageBox.Show("האם לעדכן בית מכירות זה", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //        if (r == DialogResult.Yes)
            //        {
            //            tbla.UpdateRow(a);
            //            NotPossible();
            //        }
            //    }
            if (flagAgain == true)
            {
                if (p.Status == true)
                    MessageBox.Show("לא ניתן להכניס שנית למערכת מוצר קים");
                else
                {
                    if (CreateFields(p))
                    {
                        ///*Product1*/ p = tblp.GetCurrentRow();
                        DialogResult r = MessageBox.Show("לשחזר מוצר זה מארכיון ולהכניסו שנית למערכת עם הפרטים הנל", "אשור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            Product p1 = tblp.GetCurrentRow();
                            p1.Status = true;
                            tblp.UpdateRow(p1);
                            Updatefields(p1);
                            btnRe.Visible = false;
                            btnDel.Visible = true;
                            NotPossible();
                        }
                    }
                }

            }
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblp.GoToFirst();
            p = tblp.GetCurrentRow();
            Updatefields(p);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblp.MovePrev();
            p = tblp.GetCurrentRow();
            Updatefields(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblp.MoveToNext();
            p = tblp.GetCurrentRow();
            Updatefields(p);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblp.GoToLast();
            p = tblp.GetCurrentRow();
            Updatefields(p);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NotPossible();
            errorProvider1.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Possible();
            flagAdd = true;
            flagUpdate = false;
            txtProduct_code.Text = tblp.GetKey().ToString();
            txtProduct_name.Text = "";
            cmbCategory_code.Text = "";
            cmbAuctionhouse_code.Text = "";
            cmbCategory_code.Enabled = true;
            txtPicture.Text = "";
            txtCreature_year.Text = "";
            chkStatus.Checked = true;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchProduct dg = new FrmSearchProduct();
            dg.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            flagAgain = false;
            Possible();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("האם למחוק מוצר זה", "אשור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                p = tblp.GetCurrentRow();
                p.Status = false;
                tblp.UpdateRow(p);
                Updatefields(p);
                NotPossible();
                p.Status = false;
                btnRe.Visible = true;
                btnDel.Visible = false;

            }
        }

        private void cmbCategory_code_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category ca = new Category();
            tblca.Find(cmbCategory_code.SelectedValue);
            ca = tblca.GetCurrentRow();
            cmbAuctionhouse_code.DataSource = tblca.SelectMore("select a.* from auctionhouses a, category ca where ca.category_code=a.category_code and a.category_code=" + Convert.ToInt32(ca.Category_code) + "");
            cmbAuctionhouse_code.Enabled = true;
        }

        private void cmbCategory_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPicture_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            Product p1 = tblp.GetCurrentRow();
            if (p1.Status == false)
            {
                DialogResult r = MessageBox.Show("האם לשחזר מוצר זה מארכיון", "אשור שחזור", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    p1.Status = true;
                    tblp.UpdateRow(p1);
                    Updatefields(p1);
                    btnRe.Visible = false;
                    btnDel.Visible = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image Files|*.jpg";
                openFileDialog1.ShowDialog();
                string r = openFileDialog1.FileName;


                string mikum;
                int x = r.IndexOf("\\pictures");
                int y = r.Length - x;
                mikum = r.Substring(x, y);


                pictureBox1.Image = Image.FromFile(r);

                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                txtPicture.Text = mikum;
            }
            catch
            {
                MessageBox.Show("לא ניתן לפתוח קובץ זה");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            flagUpdate = false;
            flagAdd = false;
            flagAgain = true;
            Possible();

            cmbAuctionhouse_code.DataSource = tblca.SelectMore("select a.* from auctionhouses a, category ca where ca.category_code=a.category_code and a.category_code=" + Convert.ToInt32(cmbCategory_code.SelectedValue) + "");
            cmbAuctionhouse_code.Enabled = true;
        }

        private void btnEr_Click(object sender, EventArgs e)
        {
            Dal.DealWithReport("er", "product_code=" + Convert.ToInt32(txtProduct_code.Text) + "");
        }
    }
}
