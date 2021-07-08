namespace Auctionhouse.Gui
{
    partial class FrmSearchSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchSale));
            this.dgSearchSale = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.txtbySale_code = new System.Windows.Forms.TextBox();
            this.txtbyProduct_code = new System.Windows.Forms.TextBox();
            this.txtbyFirst_price = new System.Windows.Forms.TextBox();
            this.txtbyLast_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbyWin_client_id = new System.Windows.Forms.TextBox();
            this.btnBackSale = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbShow_place_code = new System.Windows.Forms.ComboBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchSale)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSearchSale
            // 
            this.dgSearchSale.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSearchSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearchSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgSearchSale.Location = new System.Drawing.Point(-21, 3);
            this.dgSearchSale.Name = "dgSearchSale";
            this.dgSearchSale.ReadOnly = true;
            this.dgSearchSale.Size = new System.Drawing.Size(849, 185);
            this.dgSearchSale.TabIndex = 0;
            this.dgSearchSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "win_client_id";
            this.Column1.HeaderText = "תז לקוח זוכה";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "deadline";
            this.Column2.HeaderText = "תאריך אחרון";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "last_price";
            this.Column3.HeaderText = "מחיר אחרון";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "start_date";
            this.Column4.HeaderText = "תאריך ראשון";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "first_price";
            this.Column5.HeaderText = "מחיר ראשון";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "show_place_code";
            this.Column6.HeaderText = "קוד אולם תצוגה";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "product_code";
            this.Column7.HeaderText = "קוד מוצר";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sale_code";
            this.Column8.HeaderText = "קוד מכירה";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(351, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "קוד מכירה";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(351, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "קוד מוצר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(351, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "אולם תצוגה";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.Location = new System.Drawing.Point(1, 3);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(74, 74);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "לחזרה לתפריט ראשי";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Visible = false;
            this.btnBegin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbySale_code
            // 
            this.txtbySale_code.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbySale_code.Location = new System.Drawing.Point(243, 302);
            this.txtbySale_code.Name = "txtbySale_code";
            this.txtbySale_code.Size = new System.Drawing.Size(100, 28);
            this.txtbySale_code.TabIndex = 5;
            this.txtbySale_code.TextChanged += new System.EventHandler(this.txtbySale_code_TextChanged);
            // 
            // txtbyProduct_code
            // 
            this.txtbyProduct_code.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyProduct_code.Location = new System.Drawing.Point(243, 328);
            this.txtbyProduct_code.Name = "txtbyProduct_code";
            this.txtbyProduct_code.Size = new System.Drawing.Size(100, 28);
            this.txtbyProduct_code.TabIndex = 6;
            this.txtbyProduct_code.TextChanged += new System.EventHandler(this.txtbySale_code_TextChanged);
            // 
            // txtbyFirst_price
            // 
            this.txtbyFirst_price.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyFirst_price.Location = new System.Drawing.Point(243, 375);
            this.txtbyFirst_price.Name = "txtbyFirst_price";
            this.txtbyFirst_price.Size = new System.Drawing.Size(100, 28);
            this.txtbyFirst_price.TabIndex = 8;
            this.txtbyFirst_price.TextChanged += new System.EventHandler(this.txtbySale_code_TextChanged);
            // 
            // txtbyLast_price
            // 
            this.txtbyLast_price.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyLast_price.Location = new System.Drawing.Point(243, 401);
            this.txtbyLast_price.Name = "txtbyLast_price";
            this.txtbyLast_price.Size = new System.Drawing.Size(100, 28);
            this.txtbyLast_price.TabIndex = 10;
            this.txtbyLast_price.TextChanged += new System.EventHandler(this.txtbySale_code_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(354, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "מחיר ראשוני";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(353, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "תאריך סיום";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(351, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "מחיר סיום";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(119, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "לקוח זוכה";
            // 
            // txtbyWin_client_id
            // 
            this.txtbyWin_client_id.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyWin_client_id.Location = new System.Drawing.Point(1, 409);
            this.txtbyWin_client_id.Name = "txtbyWin_client_id";
            this.txtbyWin_client_id.Size = new System.Drawing.Size(100, 28);
            this.txtbyWin_client_id.TabIndex = 17;
            this.txtbyWin_client_id.TextChanged += new System.EventHandler(this.txtbySale_code_TextChanged);
            // 
            // btnBackSale
            // 
            this.btnBackSale.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackSale.Location = new System.Drawing.Point(81, 3);
            this.btnBackSale.Name = "btnBackSale";
            this.btnBackSale.Size = new System.Drawing.Size(73, 74);
            this.btnBackSale.TabIndex = 19;
            this.btnBackSale.Text = "לחזרה למכירה";
            this.btnBackSale.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBackSale.UseVisualStyleBackColor = true;
            this.btnBackSale.Click += new System.EventHandler(this.btnBackSale_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgSearchSale);
            this.panel1.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(1, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 211);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(559, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "חפש לפי";
            // 
            // cmbShow_place_code
            // 
            this.cmbShow_place_code.FormattingEnabled = true;
            this.cmbShow_place_code.Location = new System.Drawing.Point(243, 355);
            this.cmbShow_place_code.Name = "cmbShow_place_code";
            this.cmbShow_place_code.Size = new System.Drawing.Size(100, 21);
            this.cmbShow_place_code.TabIndex = 21;
            this.cmbShow_place_code.SelectedIndexChanged += new System.EventHandler(this.cmbShow_place_code_SelectedIndexChanged);
            this.cmbShow_place_code.SelectionChangeCommitted += new System.EventHandler(this.cmbShow_place_code_SelectionChangeCommitted);
            this.cmbShow_place_code.TextChanged += new System.EventHandler(this.cmbShow_place_code_TextChanged);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(243, 430);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(100, 20);
            this.dtpDeadline.TabIndex = 22;
            // 
            // FrmSearchSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.cmbShow_place_code);
            this.Controls.Add(this.btnBackSale);
            this.Controls.Add(this.txtbyWin_client_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbyLast_price);
            this.Controls.Add(this.txtbyFirst_price);
            this.Controls.Add(this.txtbyProduct_code);
            this.Controls.Add(this.txtbySale_code);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchSale";
            this.Text = " חפוש מכירה";
            this.Load += new System.EventHandler(this.txtBy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearchSale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSearchSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtbySale_code;
        private System.Windows.Forms.TextBox txtbyProduct_code;
        private System.Windows.Forms.TextBox txtbyFirst_price;
        private System.Windows.Forms.TextBox txtbyLast_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbyWin_client_id;
        private System.Windows.Forms.Button btnBackSale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbShow_place_code;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
    }
}