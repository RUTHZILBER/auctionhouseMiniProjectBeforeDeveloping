namespace Auctionhouse.Gui
{
    partial class BeginB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.למכירותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.למכירותפעילותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.למכירותשהסתימוToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.לפרטיךToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBegining = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.למכירותToolStripMenuItem,
            this.לפרטיךToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(494, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // למכירותToolStripMenuItem
            // 
            this.למכירותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.למכירותפעילותToolStripMenuItem,
            this.למכירותשהסתימוToolStripMenuItem});
            this.למכירותToolStripMenuItem.Name = "למכירותToolStripMenuItem";
            this.למכירותToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.למכירותToolStripMenuItem.Text = "למכירות";
            // 
            // למכירותפעילותToolStripMenuItem
            // 
            this.למכירותפעילותToolStripMenuItem.Name = "למכירותפעילותToolStripMenuItem";
            this.למכירותפעילותToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.למכירותפעילותToolStripMenuItem.Text = "למכירות פעילות";
            this.למכירותפעילותToolStripMenuItem.Click += new System.EventHandler(this.למכירותפעילותToolStripMenuItem_Click);
            // 
            // למכירותשהסתימוToolStripMenuItem
            // 
            this.למכירותשהסתימוToolStripMenuItem.Name = "למכירותשהסתימוToolStripMenuItem";
            this.למכירותשהסתימוToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.למכירותשהסתימוToolStripMenuItem.Text = "למכירות שהסתימו";
            this.למכירותשהסתימוToolStripMenuItem.Click += new System.EventHandler(this.למכירותשהסתימוToolStripMenuItem_Click);
            // 
            // לפרטיךToolStripMenuItem
            // 
            this.לפרטיךToolStripMenuItem.Name = "לפרטיךToolStripMenuItem";
            this.לפרטיךToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.לפרטיךToolStripMenuItem.Text = "לפרטיך";
            this.לפרטיךToolStripMenuItem.Click += new System.EventHandler(this.ללקוחותToolStripMenuItem_Click);
            // 
            // btnBegining
            // 
            this.btnBegining.BackColor = System.Drawing.Color.Red;
            this.btnBegining.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBegining.Location = new System.Drawing.Point(210, 201);
            this.btnBegining.Name = "btnBegining";
            this.btnBegining.Size = new System.Drawing.Size(75, 23);
            this.btnBegining.TabIndex = 4;
            this.btnBegining.Text = "לפתיחה";
            this.btnBegining.UseVisualStyleBackColor = false;
            this.btnBegining.Click += new System.EventHandler(this.btnBegining_Click);
            // 
            // BeginB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 425);
            this.Controls.Add(this.btnBegining);
            this.Controls.Add(this.menuStrip2);
            this.Name = "BeginB";
            this.Text = "BeginB";
            this.Load += new System.EventHandler(this.BeginB_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem למכירותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem לפרטיךToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem למכירותפעילותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem למכירותשהסתימוToolStripMenuItem;
        private System.Windows.Forms.Button btnBegining;
    }
}