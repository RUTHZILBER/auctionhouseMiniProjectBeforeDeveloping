namespace Auctionhouse.Gui
{
    partial class FrmSearchAuctionhouses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchAuctionhouses));
            this.dgAuctionhouse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbyAuctionhouse_code = new System.Windows.Forms.TextBox();
            this.txtbyAuctionhouse_name = new System.Windows.Forms.TextBox();
            this.txtbyCategory_code = new System.Windows.Forms.TextBox();
            this.txtbyTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategoryy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuctionhouse)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAuctionhouse
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Fb Karnaf Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dgAuctionhouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAuctionhouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAuctionhouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgAuctionhouse.Location = new System.Drawing.Point(5, 3);
            this.dgAuctionhouse.Name = "dgAuctionhouse";
            this.dgAuctionhouse.ReadOnly = true;
            this.dgAuctionhouse.Size = new System.Drawing.Size(443, 276);
            this.dgAuctionhouse.TabIndex = 0;
            this.dgAuctionhouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAuctionhouse_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "auctionhouse_code";
            this.Column1.HeaderText = "קוד בית מכירות";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "auctionhouse_name";
            this.Column2.HeaderText = "שם בית מכירות";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "category_code";
            this.Column3.HeaderText = "קוד קטגוריה";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tel";
            this.Column4.HeaderText = "טלפון";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtbyAuctionhouse_code
            // 
            this.txtbyAuctionhouse_code.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyAuctionhouse_code.Location = new System.Drawing.Point(691, 87);
            this.txtbyAuctionhouse_code.Name = "txtbyAuctionhouse_code";
            this.txtbyAuctionhouse_code.Size = new System.Drawing.Size(121, 28);
            this.txtbyAuctionhouse_code.TabIndex = 1;
            this.txtbyAuctionhouse_code.TextChanged += new System.EventHandler(this.txtbyAuctionhouse_code_TextChanged);
            // 
            // txtbyAuctionhouse_name
            // 
            this.txtbyAuctionhouse_name.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyAuctionhouse_name.Location = new System.Drawing.Point(691, 114);
            this.txtbyAuctionhouse_name.Name = "txtbyAuctionhouse_name";
            this.txtbyAuctionhouse_name.Size = new System.Drawing.Size(121, 28);
            this.txtbyAuctionhouse_name.TabIndex = 2;
            this.txtbyAuctionhouse_name.TextChanged += new System.EventHandler(this.txtbyAuctionhouse_name_TextChanged);
            // 
            // txtbyCategory_code
            // 
            this.txtbyCategory_code.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyCategory_code.Location = new System.Drawing.Point(158, 359);
            this.txtbyCategory_code.Name = "txtbyCategory_code";
            this.txtbyCategory_code.Size = new System.Drawing.Size(10, 28);
            this.txtbyCategory_code.TabIndex = 3;
            this.txtbyCategory_code.TextChanged += new System.EventHandler(this.txtbyCategory_code_TextChanged);
            // 
            // txtbyTel
            // 
            this.txtbyTel.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyTel.Location = new System.Drawing.Point(691, 168);
            this.txtbyTel.Name = "txtbyTel";
            this.txtbyTel.Size = new System.Drawing.Size(121, 28);
            this.txtbyTel.TabIndex = 4;
            this.txtbyTel.TextChanged += new System.EventHandler(this.txtbyTel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(553, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "לפי קוד בית מכירות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(554, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "לפי שם בית מכירות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(572, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "לפי שם קטגוריה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(615, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "לפי טלפון";
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBegin.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.Location = new System.Drawing.Point(12, 312);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 75);
            this.btnBegin.TabIndex = 9;
            this.btnBegin.Text = "לחזרה לתפריט ראשי";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Visible = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Fb Karnaf Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 78);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "לחזרה לבתי מכירות";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgAuctionhouse);
            this.panel1.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(99, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 279);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Fb Karnaf", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(569, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "אפשרויות חפוש:";
            // 
            // cmbCategoryy
            // 
            this.cmbCategoryy.FormattingEnabled = true;
            this.cmbCategoryy.Location = new System.Drawing.Point(691, 144);
            this.cmbCategoryy.Name = "cmbCategoryy";
            this.cmbCategoryy.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoryy.TabIndex = 12;
            this.cmbCategoryy.UseWaitCursor = true;
            this.cmbCategoryy.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged_1);
            this.cmbCategoryy.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoryy_SelectionChangeCommitted);
            this.cmbCategoryy.SelectedValueChanged += new System.EventHandler(this.cmbCategoryy_SelectedValueChanged);
            // 
            // FrmSearchAuctionhouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(839, 399);
            this.Controls.Add(this.cmbCategoryy);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbyTel);
            this.Controls.Add(this.txtbyCategory_code);
            this.Controls.Add(this.txtbyAuctionhouse_name);
            this.Controls.Add(this.txtbyAuctionhouse_code);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FrmSearchAuctionhouses";
            this.Text = "חפוש בית מכירות";
            this.Load += new System.EventHandler(this.FrmSearchAuctionhouses_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgAuctionhouse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAuctionhouse;
        private System.Windows.Forms.TextBox txtbyAuctionhouse_code;
        private System.Windows.Forms.TextBox txtbyAuctionhouse_name;
        private System.Windows.Forms.TextBox txtbyCategory_code;
        private System.Windows.Forms.TextBox txtbyTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategoryy;
    }
}