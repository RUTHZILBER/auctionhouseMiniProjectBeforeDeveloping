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
    public partial class BeginB : Form
    {
        public BeginB()
        {
            InitializeComponent();
        }

        private void לסוגיימיםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void למכירותפעילותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale3FRM s3 = new Sale3FRM();
            this.Hide();
            s3.Show();
        }

        private void למכירותשהסתימוToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleFRM2 s2 = new SaleFRM2();
            s2.Show();
            this.Hide();
        }

        private void לפרטיךToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ללקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientFRMC f = new ClientFRMC(Program.cd, false);
            f.Show();
            Program.ab = 1;
            
            this.Hide();
           
        }

        private void btnBegining_Click(object sender, EventArgs e)
        {
            Begin b = new Begin();
            this.Hide();
            b.Show();
        }

        private void BeginB_Load(object sender, EventArgs e)
        {

        }
    }
}
