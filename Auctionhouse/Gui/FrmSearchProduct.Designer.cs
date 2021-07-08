namespace Auctionhouse.Gui
{
    partial class FrmSearchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchProduct));
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBegin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbyProduct_name = new System.Windows.Forms.TextBox();
            this.txtbyCategory_code = new System.Windows.Forms.TextBox();
            this.txtbyProduct_code = new System.Windows.Forms.TextBox();
            this.txtbyCreature_year = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBackSale = new System.Windows.Forms.Button();
            this.l5 = new System.Windows.Forms.Label();
            this.txtAuctionhouse_code = new System.Windows.Forms.TextBox();
            this.txtCreature = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCategory_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProduct
            // 
            this.dgProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column5});
            this.dgProduct.Location = new System.Drawing.Point(3, 3);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            this.dgProduct.Size = new System.Drawing.Size(545, 249);
            this.dgProduct.TabIndex = 0;
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_code";
            this.Column1.HeaderText = "קוד מוצר";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product_name";
            this.Column2.HeaderText = "שם מוצר";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "category_code";
            this.Column3.HeaderText = "שם קטגוריה";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "auctionhouse_code";
            this.Column6.HeaderText = "שם בית מכירות";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "creature_year";
            this.Column5.HeaderText = "תאריך יצור או מציאה";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.Location = new System.Drawing.Point(12, 13);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(80, 83);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "לחזרה לתפריט ראשי";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Visible = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(166, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "חפוש ע\'\'פ קוד מוצר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(169, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "חפוש ע\'\'פ שם מוצר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(169, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "חפוש ע\'\'פ  קטגוריה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(172, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "חפוש ע\'\'פ שנת יצור";
            // 
            // txtbyProduct_name
            // 
            this.txtbyProduct_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyProduct_name.Location = new System.Drawing.Point(12, 351);
            this.txtbyProduct_name.Name = "txtbyProduct_name";
            this.txtbyProduct_name.Size = new System.Drawing.Size(151, 29);
            this.txtbyProduct_name.TabIndex = 6;
            this.txtbyProduct_name.TextChanged += new System.EventHandler(this.txtbyProduct_name_TextChanged);
            // 
            // txtbyCategory_code
            // 
            this.txtbyCategory_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyCategory_code.Location = new System.Drawing.Point(581, 143);
            this.txtbyCategory_code.Name = "txtbyCategory_code";
            this.txtbyCategory_code.Size = new System.Drawing.Size(29, 29);
            this.txtbyCategory_code.TabIndex = 7;
            this.txtbyCategory_code.TextChanged += new System.EventHandler(this.txtbyCategory_code_TextChanged);
            // 
            // txtbyProduct_code
            // 
            this.txtbyProduct_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyProduct_code.Location = new System.Drawing.Point(12, 407);
            this.txtbyProduct_code.Name = "txtbyProduct_code";
            this.txtbyProduct_code.Size = new System.Drawing.Size(151, 29);
            this.txtbyProduct_code.TabIndex = 8;
            this.txtbyProduct_code.TextChanged += new System.EventHandler(this.txtbyProduct_code_TextChanged);
            // 
            // txtbyCreature_year
            // 
            this.txtbyCreature_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyCreature_year.Location = new System.Drawing.Point(12, 379);
            this.txtbyCreature_year.Name = "txtbyCreature_year";
            this.txtbyCreature_year.Size = new System.Drawing.Size(151, 29);
            this.txtbyCreature_year.TabIndex = 11;
            this.txtbyCreature_year.TextChanged += new System.EventHandler(this.txtbyCreature_year_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(99, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 82);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "לחזרה למוצרים";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBackSale
            // 
            this.btnBackSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackSale.Location = new System.Drawing.Point(189, 13);
            this.btnBackSale.Name = "btnBackSale";
            this.btnBackSale.Size = new System.Drawing.Size(83, 82);
            this.btnBackSale.TabIndex = 13;
            this.btnBackSale.Text = "לחזרה למכירה";
            this.btnBackSale.UseVisualStyleBackColor = true;
            this.btnBackSale.Click += new System.EventHandler(this.btnBackSale_Click);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.BackColor = System.Drawing.Color.Transparent;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.l5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l5.Location = new System.Drawing.Point(307, 31);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(350, 24);
            this.l5.TabIndex = 14;
            this.l5.Text = "הקש קוד בית מכירות כדי לבחור מוצר למכירה";
            this.l5.Visible = false;
            // 
            // txtAuctionhouse_code
            // 
            this.txtAuctionhouse_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAuctionhouse_code.Location = new System.Drawing.Point(345, 51);
            this.txtAuctionhouse_code.Name = "txtAuctionhouse_code";
            this.txtAuctionhouse_code.Size = new System.Drawing.Size(238, 29);
            this.txtAuctionhouse_code.TabIndex = 15;
            this.txtAuctionhouse_code.TextChanged += new System.EventHandler(this.txtAuctionhouse_code_TextChanged);
            // 
            // txtCreature
            // 
            this.txtCreature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCreature.Location = new System.Drawing.Point(437, 377);
            this.txtCreature.Name = "txtCreature";
            this.txtCreature.Size = new System.Drawing.Size(131, 29);
            this.txtCreature.TabIndex = 21;
            this.txtCreature.Visible = false;
            this.txtCreature.TextChanged += new System.EventHandler(this.txtCreature_TextChanged);
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtProductCode.Location = new System.Drawing.Point(437, 403);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(131, 29);
            this.txtProductCode.TabIndex = 20;
            this.txtProductCode.Visible = false;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtProductName.Location = new System.Drawing.Point(437, 351);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(131, 29);
            this.txtProductName.TabIndex = 19;
            this.txtProductName.Visible = false;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(577, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "חפוש ע\'\'פ שנת יצור";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(574, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "חפוש ע\'\'פ שם מוצר";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(571, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "חפוש ע\'\'פ קוד מוצר";
            this.label7.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgProduct);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(2, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 255);
            this.panel1.TabIndex = 22;
            // 
            // cmbCategory_name
            // 
            this.cmbCategory_name.FormattingEnabled = true;
            this.cmbCategory_name.Location = new System.Drawing.Point(13, 437);
            this.cmbCategory_name.Name = "cmbCategory_name";
            this.cmbCategory_name.Size = new System.Drawing.Size(150, 21);
            this.cmbCategory_name.TabIndex = 24;
            this.cmbCategory_name.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_name_SelectedIndexChanged);
            this.cmbCategory_name.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_name_SelectionChangeCommitted);
            this.cmbCategory_name.TextChanged += new System.EventHandler(this.cmbCategory_name_TextChanged);
            // 
            // FrmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.cmbCategory_name);
            this.Controls.Add(this.txtCreature);
            this.Controls.Add(this.btnBackSale);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAuctionhouse_code);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtbyCreature_year);
            this.Controls.Add(this.txtbyProduct_code);
            this.Controls.Add(this.txtbyCategory_code);
            this.Controls.Add(this.txtbyProduct_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchProduct";
            this.Text = "חפוש מוצר";
            this.Load += new System.EventHandler(this.dgProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbyProduct_name;
        private System.Windows.Forms.TextBox txtbyCategory_code;
        private System.Windows.Forms.TextBox txtbyProduct_code;
        private System.Windows.Forms.TextBox txtbyCreature_year;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackSale;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox txtAuctionhouse_code;
        private System.Windows.Forms.TextBox txtCreature;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbCategory_name;
    }
}