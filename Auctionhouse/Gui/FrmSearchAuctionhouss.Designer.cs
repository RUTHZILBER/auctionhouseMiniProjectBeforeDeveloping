namespace Auctionhouse.Gui
{
    partial class FrmSearchAuctionhouss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchAuctionhouss));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbyTel = new System.Windows.Forms.TextBox();
            this.txtbyAuctionhouse_name = new System.Windows.Forms.TextBox();
            this.txtbyAuctionhouse_code = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgAuctionhouse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCategoryy = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuctionhouse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(98, 342);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 78);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "לחזרה לבתי מכירות";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBegin.Location = new System.Drawing.Point(5, 342);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 75);
            this.btnBegin.TabIndex = 22;
            this.btnBegin.Text = "לחזרה לתפריט ראשי";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Visible = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(608, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "לפי טלפון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(565, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "לפי שם קטגוריה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(547, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "לפי שם בית מכירות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(562, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "אפשרויות חפוש:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(546, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "לפי קוד בית מכירות";
            // 
            // txtbyTel
            // 
            this.txtbyTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyTel.Location = new System.Drawing.Point(684, 198);
            this.txtbyTel.Name = "txtbyTel";
            this.txtbyTel.Size = new System.Drawing.Size(121, 29);
            this.txtbyTel.TabIndex = 16;
            this.txtbyTel.TextChanged += new System.EventHandler(this.txtbyTel_TextChanged);
            // 
            // txtbyAuctionhouse_name
            // 
            this.txtbyAuctionhouse_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyAuctionhouse_name.Location = new System.Drawing.Point(684, 144);
            this.txtbyAuctionhouse_name.Name = "txtbyAuctionhouse_name";
            this.txtbyAuctionhouse_name.Size = new System.Drawing.Size(121, 29);
            this.txtbyAuctionhouse_name.TabIndex = 14;
            this.txtbyAuctionhouse_name.TextChanged += new System.EventHandler(this.txtbyAuctionhouse_name_TextChanged);
            // 
            // txtbyAuctionhouse_code
            // 
            this.txtbyAuctionhouse_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbyAuctionhouse_code.Location = new System.Drawing.Point(684, 117);
            this.txtbyAuctionhouse_code.Name = "txtbyAuctionhouse_code";
            this.txtbyAuctionhouse_code.Size = new System.Drawing.Size(121, 29);
            this.txtbyAuctionhouse_code.TabIndex = 13;
            this.txtbyAuctionhouse_code.TextChanged += new System.EventHandler(this.txtbyAuctionhouse_code_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgAuctionhouse);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(39, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 289);
            this.panel1.TabIndex = 24;
            // 
            // dgAuctionhouse
            // 
            this.dgAuctionhouse.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgAuctionhouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAuctionhouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgAuctionhouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAuctionhouse.Location = new System.Drawing.Point(0, 0);
            this.dgAuctionhouse.Name = "dgAuctionhouse";
            this.dgAuctionhouse.ReadOnly = true;
            this.dgAuctionhouse.Size = new System.Drawing.Size(502, 289);
            this.dgAuctionhouse.TabIndex = 0;
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
            this.Column3.HeaderText = "שם קטגוריה";
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
            // Column5
            // 
            this.Column5.DataPropertyName = "status";
            this.Column5.HeaderText = "סטטוס";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmbCategoryy
            // 
            this.cmbCategoryy.FormattingEnabled = true;
            this.cmbCategoryy.Location = new System.Drawing.Point(684, 173);
            this.cmbCategoryy.Name = "cmbCategoryy";
            this.cmbCategoryy.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoryy.TabIndex = 26;
            this.cmbCategoryy.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryy_SelectedIndexChanged);
            this.cmbCategoryy.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmSearchAuctionhouss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCategoryy);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbyTel);
            this.Controls.Add(this.txtbyAuctionhouse_name);
            this.Controls.Add(this.txtbyAuctionhouse_code);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearchAuctionhouss";
            this.Text = "FrmSearchAuctionhouss";
            this.Load += new System.EventHandler(this.FrmSearchAuctionhouss_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAuctionhouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbyTel;
        private System.Windows.Forms.TextBox txtbyAuctionhouse_name;
        private System.Windows.Forms.TextBox txtbyAuctionhouse_code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgAuctionhouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbCategoryy;
    }
}