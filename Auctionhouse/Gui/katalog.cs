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
    public partial class katalog : Form
    {
        private Show_placeDB tblsp;
        private Show_place sp;
        private SaleDB tbls;
        private Sale s;
        private Sale_offerDB tblso;
        private Sale_offer so;
        private Product p;
        private ProductDB tblp;
        DataTable dtproduct;
        PictureBox[] pb;
        Label[] lb;
        GroupBox[] gp;
        //Panel panelcolor;
        Panel p1;
        Panel p2;
        Panel p3;
        Panel p4;
        int count1 = 0;
        int count2 = 0;
        //DataTable dtColors;
        private Panel[] panels;
        private Label[] lables;

        public katalog()
        {
            InitializeComponent();
           

            InitializeComponent();
            tblp = new ProductDB();
            dtproduct = tblp.SelectWhere("status=true");
            p = new Product();
            p = tblp.GetCurrentRow();
           //למי ניו
            
            pb = new PictureBox[dtproduct.Rows.Count];
            lb = new Label[dtproduct.Rows.Count];
            panels = new Panel[dtproduct.Rows.Count];
            gp = new GroupBox[dtproduct.Rows.Count];
            lables = new Label[dtproduct.Rows.Count];
            
            
            //ShowProduct();
        }
        public katalog(SaleFRM1 s)
        {
            InitializeComponent();
            //ShowProduct();
        }
        //public void ShowProduct()
        //{
        //    int f = 50;
        //    int r = 50;
        //    int f1 = 50;
        //    int r1 = 100;
        //    int y = 5;
        //    int l = dtproduct.Rows.Count / 5;

        //    for (int i = 1; i < 2 + l; i++)
        //    {


        //        for (int j = 0; j < y; j++)
        //        {
        //            if (((dtproduct.Rows.Count) == count1 + 1))
        //            {
        //                y = dtproduct.Rows.Count % 5;
        //                i = 1 + dtproduct.Rows.Count / 5;
        //                j = y;
        //            }


        //            tblp.Find(dtMozarim.Rows[count][0]);

        //            p = tblp.GetCurrentRow();
        //            //dtColors = tblcp.SelectMore(" select  cr.Kodcolor from ColorProduct cr, color c where c.Kodcolor=cr.Kodcolor and cr.kodproduct =" + p.Kodproduct);
        //            dtColors = tblcp.SelectMore(" select  cr.Kodcolor from ColorProduct cr where cr.kodproduct =" + p.Kodproduct);
        //            int countcol = dtColors.Rows.Count;
        //            pc[count2] = new PictureBox();
        //            try
        //            {
        //                string path = System.IO.Directory.GetCurrentDirectory();
        //                int x = path.IndexOf("\\bin");
        //                path = path.Substring(0, x) + p.Picutre;

        //                pc[count2].Image = Image.FromFile(path);
        //            }
        //            catch
        //            {
        //                //pc[count2].Image = global::afect.Properties.Resources.n;
        //            }


        //            pc[count2].Location = new System.Drawing.Point(0, -20);
        //            pc[count2].Name = "pictureBox1";
        //            pc[count2].Size = new System.Drawing.Size(200, 300);
        //            pc[count2].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        //            pc[count2].TabIndex = 1;
        //            pc[count2].TabStop = false;
        //            pc[count2].Tag = p.Kodproduct;
        //            pc[count2].Click += new System.EventHandler(this.button3_Click);

        //            Controls.Add(pc[count2]);



        //            lb[count2] = new Label();
        //            lb[count2].AutoSize = true;
        //            lb[count2].Location = new System.Drawing.Point(70, 280);
        //            //lb[count].Location = new System.Drawing.Point(f, r + 320);
        //            lb[count2].Name = "label1";
        //            lb[count2].Size = new System.Drawing.Size(125, 24);
        //            lb[count2].TabIndex = 1;
        //            lb[count2].TabStop = false;
        //            lb[count2].Text = p.Namep.ToString();
        //            Controls.Add(lb[count2]);

        //            lbm[count2] = new Label();
        //            lbm[count2].AutoSize = true;
        //            lbm[count2].Location = new System.Drawing.Point(70, 300);
        //            //lb[count].Location = new System.Drawing.Point(f, r + 320);
        //            lbm[count2].Name = "label2";
        //            lbm[count2].Size = new System.Drawing.Size(125, 24);
        //            lbm[count2].TabIndex = 1;
        //            lbm[count2].TabStop = false;
        //            lbm[count2].Text = "₪ " + p.Price.ToString();
        //            Controls.Add(lbm[count2]);


        //            this.p4 = new Panel();
        //            this.p4.BackColor = System.Drawing.Color.Gray;
        //            this.p4.Location = new System.Drawing.Point(150, 74);
        //            this.p4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        //            this.p4.Name = "p4";
        //            this.p4.Size = new System.Drawing.Size(25, 25);
        //            this.p4.TabIndex = 0;

        //            if (countcol > 0)
        //            {
        //                tblcr.Find(dtColors.Rows[countcol - 1][0]);
        //                cr = tblcr.GetCurrentRow();
        //                this.p4.BackColor = System.Drawing.Color.FromArgb(cr.Col);
        //                countcol--;
        //            }
        //            else
        //                this.p4.Visible = false;
        //            Controls.Add(p4);


        //            this.p3 = new Panel();
        //            this.p3.BackColor = System.Drawing.Color.Gray;
        //            this.p3.Location = new System.Drawing.Point(112, 74);
        //            this.p3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        //            this.p3.Name = "p3";
        //            this.p3.Size = new System.Drawing.Size(25, 25);
        //            this.p3.TabIndex = 1;
        //            if (countcol > 0)
        //            {
        //                tblcr.Find(dtColors.Rows[countcol - 1][0]);
        //                cr = tblcr.GetCurrentRow();
        //                this.p3.BackColor = System.Drawing.Color.FromArgb(cr.Col);
        //                countcol--;
        //            }
        //            else
        //                this.p3.Visible = false;
        //            Controls.Add(p3);


        //            this.p2 = new Panel();
        //            this.p2.BackColor = System.Drawing.Color.Blue;
        //            this.p2.Location = new System.Drawing.Point(76, 74);
        //            this.p2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        //            this.p2.Name = "p2";
        //            this.p2.Size = new System.Drawing.Size(25, 25);
        //            this.p2.TabIndex = 2;
        //            if (countcol > 0)
        //            {
        //                tblcr.Find(dtColors.Rows[countcol - 1][0]);
        //                cr = tblcr.GetCurrentRow();
        //                this.p2.BackColor = System.Drawing.Color.FromArgb(cr.Col);
        //                countcol--;
        //            }
        //            else
        //                this.p2.Visible = false;
        //            Controls.Add(p2);


        //            this.p1 = new Panel();
        //            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        //            this.p1.Location = new System.Drawing.Point(38, 74);
        //            this.p1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        //            this.p1.Name = "p1";
        //            this.p1.Size = new System.Drawing.Size(25, 25);
        //            this.p1.TabIndex = 2;
        //            if (countcol > 0)
        //            {
        //                tblcr.Find(dtColors.Rows[countcol - 1][0]);
        //                cr = tblcr.GetCurrentRow();
        //                this.p1.BackColor = System.Drawing.Color.FromArgb(cr.Col);
        //                countcol--;
        //            }
        //            else
        //                this.p1.Visible = false;
        //            Controls.Add(p1);

        //            panelcolor = new Panel();
        //            this.panelcolor.Controls.Add(this.p1);
        //            this.panelcolor.Controls.Add(this.p2);
        //            this.panelcolor.Controls.Add(this.p3);
        //            this.panelcolor.Controls.Add(this.p4);

        //            this.panelcolor.Location = new System.Drawing.Point(10, 250);
        //            this.panelcolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        //            this.panelcolor.Name = "panelcolor";
        //            this.panelcolor.Size = new System.Drawing.Size(207, 115);
        //            this.panelcolor.TabIndex = 10;
        //            this.panelcolor.BackColor = Color.AliceBlue;
        //            this.panelcolor.Tag = p.Kodproduct;
        //            //this.panelcolor.Click += new System.EventHandler(this.button5_Click);

        //            Controls.Add(panelcolor);


        //            panel[count2] = new Panel();
        //            panel[count2].Controls.Add(this.lb[count2]);
        //            panel[count2].Controls.Add(this.pc[count2]);
        //            panel[count2].Controls.Add(this.panelcolor);

        //            panel[count2].Location = new System.Drawing.Point(f, r);
        //            panel[count2].Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        //            panel[count2].Name = "panel";
        //            panel[count2].Size = new System.Drawing.Size(200, 370);
        //            panel[count2].Tag = p.Kodproduct;
        //            panel[count2].TabIndex = 10;
        //            panel[count2].BackColor = System.Drawing.Color.AliceBlue;


        //            Controls.Add(panel[count2]);
        //            //this.panel[count2].Click += new System.EventHandler(this.button5_Click);
        //            panel3.Controls.Add(panel[count]);
        //            f = f + 300;
        //            f1 = f1 + 260;
        //            count++;
        //            count2++;
        //            //panel9.ControlAdded(panel[count]);
        //            //}
        //            //catch
        //            //{
        //            //    j = y;
        //            //    //i = 1 + dtMozarim.Rows.Count / 5;
        //            //    i++;
        //            //    button5.Visible = false;
        //            //}

        //        }

        //        f = 50;
        //        r = r + 380;
        //        f1 = 100;
        //        r1 = r1 + 380;
        //    }

        //}

        private void katalog_Load(object sender, EventArgs e)
        {

        }
    }
}
