namespace Auctionhouse.Gui
{
    partial class FrmSearchClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchClient));
            this.dgClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBegin = new System.Windows.Forms.Button();
            this.txtbyId = new System.Windows.Forms.TextBox();
            this.txtbyFname = new System.Windows.Forms.TextBox();
            this.txtbyLname = new System.Windows.Forms.TextBox();
            this.txtbyPel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackClient = new System.Windows.Forms.Button();
            this.btnBackSale_offer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClient
            // 
            this.dgClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column8,
            this.Column10});
            this.dgClient.EnableHeadersVisualStyles = false;
            this.dgClient.Location = new System.Drawing.Point(-251, 3);
            this.dgClient.Name = "dgClient";
            this.dgClient.ReadOnly = true;
            this.dgClient.Size = new System.Drawing.Size(957, 279);
            this.dgClient.TabIndex = 0;
            this.dgClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "מספר זהוי";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fname";
            this.Column2.HeaderText = "שם פרטי";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "lname";
            this.Column3.HeaderText = "שם משפחה";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "address";
            this.Column4.HeaderText = "כתבת";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "credit";
            this.Column5.HeaderText = "מספר כ. אשרא";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Meffect";
            this.Column6.HeaderText = "חדש תוקף";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Yeffect";
            this.Column9.HeaderText = "שנת תוקף";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pel";
            this.Column8.HeaderText = "פלאפון";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "status";
            this.Column10.HeaderText = "סטטוס";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.Location = new System.Drawing.Point(516, 337);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 73);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "לחזרה לתפריט ראשי";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Visible = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // txtbyId
            // 
            this.txtbyId.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyId.Location = new System.Drawing.Point(-2, 329);
            this.txtbyId.Name = "txtbyId";
            this.txtbyId.Size = new System.Drawing.Size(100, 28);
            this.txtbyId.TabIndex = 2;
            this.txtbyId.TextChanged += new System.EventHandler(this.txtbyId_TextChanged);
            // 
            // txtbyFname
            // 
            this.txtbyFname.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyFname.Location = new System.Drawing.Point(-2, 355);
            this.txtbyFname.Name = "txtbyFname";
            this.txtbyFname.Size = new System.Drawing.Size(100, 28);
            this.txtbyFname.TabIndex = 3;
            this.txtbyFname.TextChanged += new System.EventHandler(this.txtbyFname_TextChanged);
            // 
            // txtbyLname
            // 
            this.txtbyLname.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyLname.Location = new System.Drawing.Point(-2, 382);
            this.txtbyLname.Name = "txtbyLname";
            this.txtbyLname.Size = new System.Drawing.Size(100, 28);
            this.txtbyLname.TabIndex = 4;
            this.txtbyLname.TextChanged += new System.EventHandler(this.txtbyLname_TextChanged);
            // 
            // txtbyPel
            // 
            this.txtbyPel.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyPel.Location = new System.Drawing.Point(-2, 409);
            this.txtbyPel.Name = "txtbyPel";
            this.txtbyPel.Size = new System.Drawing.Size(100, 28);
            this.txtbyPel.TabIndex = 5;
            this.txtbyPel.TextChanged += new System.EventHandler(this.txtbyPel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "חפוש ע\'\'פ מספר זהות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(108, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "חפוש ע\'\'פ שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(105, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "חפוש ע\'\'פ שם משפחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(108, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "חפוש ע\'\'פ טלפון";
            // 
            // btnBackClient
            // 
            this.btnBackClient.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackClient.Location = new System.Drawing.Point(437, 337);
            this.btnBackClient.Name = "btnBackClient";
            this.btnBackClient.Size = new System.Drawing.Size(73, 73);
            this.btnBackClient.TabIndex = 10;
            this.btnBackClient.Text = "לחזרה ללקוחות";
            this.btnBackClient.UseVisualStyleBackColor = true;
            this.btnBackClient.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBackSale_offer
            // 
            this.btnBackSale_offer.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackSale_offer.Location = new System.Drawing.Point(356, 337);
            this.btnBackSale_offer.Name = "btnBackSale_offer";
            this.btnBackSale_offer.Size = new System.Drawing.Size(75, 73);
            this.btnBackSale_offer.TabIndex = 11;
            this.btnBackSale_offer.Text = "לחזרה למכירות";
            this.btnBackSale_offer.UseVisualStyleBackColor = true;
            this.btnBackSale_offer.Click += new System.EventHandler(this.btnBackSale_offer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgClient);
            this.panel1.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(-2, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 282);
            this.panel1.TabIndex = 12;
            // 
            // FrmSearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.btnBackSale_offer);
            this.Controls.Add(this.btnBackClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbyPel);
            this.Controls.Add(this.txtbyLname);
            this.Controls.Add(this.txtbyFname);
            this.Controls.Add(this.txtbyId);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchClient";
            this.Text = "חפוש לקוח";
            this.Load += new System.EventHandler(this.FrmSearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox txtbyId;
        private System.Windows.Forms.TextBox txtbyFname;
        private System.Windows.Forms.TextBox txtbyLname;
        private System.Windows.Forms.TextBox txtbyPel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBackClient;
        private System.Windows.Forms.Button btnBackSale_offer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgClient;
    }
}