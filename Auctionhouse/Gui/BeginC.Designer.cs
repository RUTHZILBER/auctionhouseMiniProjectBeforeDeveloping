namespace Auctionhouse.Gui
{
    partial class BeginC
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
            this.לאולמותהתצוגהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.למוצריםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ללקוחותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBegining = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.למכירותToolStripMenuItem,
            this.לאולמותהתצוגהToolStripMenuItem,
            this.למוצריםToolStripMenuItem,
            this.ללקוחותToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(652, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // למכירותToolStripMenuItem
            // 
            this.למכירותToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.למכירותפעילותToolStripMenuItem,
            this.למכירותשהסתימוToolStripMenuItem});
            this.למכירותToolStripMenuItem.Name = "למכירותToolStripMenuItem";
            this.למכירותToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.למכירותToolStripMenuItem.Text = "למכירות";
            this.למכירותToolStripMenuItem.Click += new System.EventHandler(this.למכירותToolStripMenuItem_Click);
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
            // לאולמותהתצוגהToolStripMenuItem
            // 
            this.לאולמותהתצוגהToolStripMenuItem.Name = "לאולמותהתצוגהToolStripMenuItem";
            this.לאולמותהתצוגהToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.לאולמותהתצוגהToolStripMenuItem.Text = "לאולמות התצוגה";
            this.לאולמותהתצוגהToolStripMenuItem.Click += new System.EventHandler(this.לאולמותהתצוגהToolStripMenuItem_Click);
            // 
            // למוצריםToolStripMenuItem
            // 
            this.למוצריםToolStripMenuItem.Name = "למוצריםToolStripMenuItem";
            this.למוצריםToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.למוצריםToolStripMenuItem.Text = "למוצרים";
            this.למוצריםToolStripMenuItem.Click += new System.EventHandler(this.למוצריםToolStripMenuItem_Click);
            // 
            // ללקוחותToolStripMenuItem
            // 
            this.ללקוחותToolStripMenuItem.Name = "ללקוחותToolStripMenuItem";
            this.ללקוחותToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ללקוחותToolStripMenuItem.Text = "ללקוחות";
            this.ללקוחותToolStripMenuItem.Click += new System.EventHandler(this.ללקוחותToolStripMenuItem_Click);
            // 
            // btnBegining
            // 
            this.btnBegining.BackColor = System.Drawing.Color.Red;
            this.btnBegining.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBegining.Location = new System.Drawing.Point(272, 137);
            this.btnBegining.Name = "btnBegining";
            this.btnBegining.Size = new System.Drawing.Size(75, 23);
            this.btnBegining.TabIndex = 4;
            this.btnBegining.Text = "לפתיחה";
            this.btnBegining.UseVisualStyleBackColor = false;
            this.btnBegining.Click += new System.EventHandler(this.btnBegining_Click);
            // 
            // BeginC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 357);
            this.Controls.Add(this.btnBegining);
            this.Controls.Add(this.menuStrip2);
            this.Name = "BeginC";
            this.Text = "BeginC";
            this.Load += new System.EventHandler(this.BeginA_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem למכירותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem לאולמותהתצוגהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem למוצריםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ללקוחותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem למכירותפעילותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem למכירותשהסתימוToolStripMenuItem;
        private System.Windows.Forms.Button btnBegining;
    }
}