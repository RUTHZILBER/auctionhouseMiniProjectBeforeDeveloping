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




namespace Auctionhouse
{
    public partial class Begin : Form
    {
        private ClientDB tblcl;
        private Client cl;
        private SaleDB tbls;
        private Sale s;
        private ProductDB tblp;
        private Product p;
        private ClientFRMC clcf;
        private ClientFRM clf;
        private Product pp;
        public Begin()
        {
            tblcl = new ClientDB();
            tblp = new ProductDB();
            tbls = new SaleDB();
            
            InitializeComponent();
            DataTable dt = tblcl.SelectWhere("(meffect<" + DateTime.Today.Month + " and yeffect <=" + DateTime.Today.Year + ")  or(meffect>" + DateTime.Today.Month + " and yeffect <" + DateTime.Today.Year + ")  and status=true");
            foreach(DataRow dr in dt.Rows)
           {

                tblcl.Find(dr[0]);
                cl = tblcl.GetCurrentRow();
                cl.Status = false;
                tblcl.UpdateRow(cl);
            }





        }

        private void begin_Load(object sender, EventArgs e)
        {

        }

        private void למכירותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gui.SaleFRM1 sz = new Gui.SaleFRM1();
            sz.Show();
            this.Hide();
        }

        private void לאולמותהתצוגהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_placeFRM sp = new Show_placeFRM();
            sp.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void לבתיהמכירותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuctionhousesFRM a = new AuctionhousesFRM();
            a.Show();
            this.Hide();
        }

        private void למוצריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product1FRM p = new Product1FRM();
            p.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void ללקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientFRM cl = new ClientFRM();
            cl.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void לקטגוריותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryFRM ca = new CategoryFRM();
            ca.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void לסוגיימיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Day_kindFRN d = new Day_kindFRN();
            d.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //DataTable dt1 = tbls.SelectWhere("datediff('d',cdate(deadline),cdate('" + DateTime.Today + "'))>=0 and isnull(win_client_id)");
            //foreach (DataRow dr in dt1.Rows)
            //{

            // DataTable dt=tbls.SelectMore("select s.sale_code,so.id from sale s,sale_offer so where s.sale_code=so.sale_code and s.sale_code=" + Convert.ToInt32(dr[0].ToString()) + " order by so.cost desc");
            //    if (dt.Rows.Count > 0)
            //    {
            //        if (tbls.Find(dr[0]))
            //        {
            //            s = tbls.GetCurrentRow();
            //            s.Win_client_id = dt.Rows[0][1].ToString();
            //            MessageBox.Show("מכירה הסתימה ויש זוכה" + s.Win_client_id);


            //            tbls.UpdateRow(s);

            //        }
            //    }
            //    else
            //    {
            //        if (tbls.Find(dr[0]))
            //        {

            //            s = tbls.GetCurrentRow();
            //            tblp.Find(s.Product_code);
            //            s.Win_client_id = "000000000";
            //            tbls.UpdateRow(s);
            //            p = tblp.GetCurrentRow();
            //            p.Status = true;
            //            tblp.UpdateRow(p);
            //        }
            //        MessageBox.Show("מכירה הסתימה ואין זוכה");
            //    }
            //}

        }

    private void btnOk_Click(object sender, EventArgs e)
        {
            if (tblcl.Find(txtId.Text))
            {
                cl = tblcl.GetCurrentRow();
                if (cl.Code == Convert.ToInt32(txtCode.Text))
                {
                    Program.ab = 1;
                    BeginB bb = new BeginB();
                    bb.Show();
                    this.Hide();
                    Program.cd= txtId.Text;
                }
                else
                    MessageBox.Show("הוקש קוד שגוי");
            }
            else
            {
                DialogResult r = MessageBox.Show("האם ברצונך להצטרף ללקוחותינו", "אשור הצטרפות", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    clcf = new ClientFRMC(txtId.Text, txtCode.Text,true );
                    clcf.Show();
                    Program.ab = 1;
                    Program.cd = txtId.Text;

                }
            }
        }

     

        private void btnAuctionhouses_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCodeA.Text)==222)
            {
                BeginC bb = new BeginC();
                bb.Show();
                this.Hide();
                Program.ab = 2;

            }
            else
                MessageBox.Show("אינך מנהל בית מכירות");
               
        


        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != "")
                txtCode.Visible = true;
            else
                txtCode.Visible = false;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            btnOk.Visible = true;
        }

        private void btnForClient_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void txtCodeA_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            if (txtBase.Text != "")
                btnBase.Visible = true;
            else
                btnBase.Visible = true;
        }

        private void btnForBase_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
           panel2.Visible = false;
            panel3.Visible =false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
panel1.Visible = false;
        
        panel2.Visible =false;
}
        private void btnBase_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtBase.Text) == 000)
            {
                BeginA ba = new BeginA();
                ba.Show();
                this.Hide();
                Program.ab = 0;
            }
            else
                MessageBox.Show("אינך מנהל אתר");

        }
    }
    }

