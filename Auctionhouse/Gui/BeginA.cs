using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auctionhouse.Gui
{
    public partial class BeginA : Form
    {
        public BeginA()
        {
            InitializeComponent();
        }

        private void לסוגיימיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Day_kindFRN d = new Day_kindFRN();
            d.Show();
            this.Hide();

        }

        private void לקטגוריותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryFRM ca = new CategoryFRM();
            ca.Show();
            this.Hide();
        }

        private void ללקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientFRM cl = new ClientFRM();
            cl.Show();
            this.Hide();
        }

        private void למוצריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product1FRM p = new Product1FRM();
            p.Show();
            this.Hide();
        }

        private void לבתיהמכירותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuctionhousesFRM a = new AuctionhousesFRM();
            a.Show();
            this.Hide();
        }

        private void לאולמותהתצוגהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_placeFRM sp = new Show_placeFRM();
            sp.Show();
            this.Hide();
        }

        private void למכירותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaleFRM1 s = new SaleFRM1();
            //s.Show();
            //this.Hide();
        }

        private void BeginA_Load(object sender, EventArgs e)
        {

        }

        private void למכירותפעילותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale5FRM s5 = new Sale5FRM();
            s5.Show();
            this.Hide();
        }

        private void למכירותשהסתימוToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sale4FRM s4 = new Sale4FRM();
            //s4.Show();
            //this.Hide();
        }

        private void למכירותשהסתימוToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Sale4FRM s4 = new Sale4FRM();
            s4.Show();
            this.Hide();
        }

        private void btnBegining_Click(object sender, EventArgs e)
        {
            Begin b = new Begin();
            this.Hide();
            b.Show();
        }
    }
}
