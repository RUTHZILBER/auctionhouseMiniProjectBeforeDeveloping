namespace Auctionhouse.Gui
{
    partial class ProductFRM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFRM));
            this.txtProduct_code = new System.Windows.Forms.TextBox();
            this.txtProduct_name = new System.Windows.Forms.TextBox();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCategory_code = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtCreature_year = new System.Windows.Forms.TextBox();
            this.cmbAuctionhouse_code = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnEr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduct_code
            // 
            this.txtProduct_code.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtProduct_code.Location = new System.Drawing.Point(276, 118);
            this.txtProduct_code.Name = "txtProduct_code";
            this.txtProduct_code.Size = new System.Drawing.Size(100, 25);
            this.txtProduct_code.TabIndex = 0;
            // 
            // txtProduct_name
            // 
            this.txtProduct_name.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtProduct_name.Location = new System.Drawing.Point(276, 146);
            this.txtProduct_name.Name = "txtProduct_name";
            this.txtProduct_name.Size = new System.Drawing.Size(100, 25);
            this.txtProduct_name.TabIndex = 1;
            // 
            // txtPicture
            // 
            this.txtPicture.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPicture.Location = new System.Drawing.Point(59, 289);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(133, 25);
            this.txtPicture.TabIndex = 3;
            this.txtPicture.Visible = false;
            this.txtPicture.TextChanged += new System.EventHandler(this.txtPicture_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(382, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "קוד מוצר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(382, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "שם מוצר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(165, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "שם קטגוריה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(136, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "תמונה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(164, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "שנת גלוי מוצר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(338, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "פרטי מוצר";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBegin.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBegin.Location = new System.Drawing.Point(316, 192);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 82);
            this.btnBegin.TabIndex = 11;
            this.btnBegin.Text = "לחזרה לתפריט ראשי";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Red;
            this.btnNew.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(84, 183);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(84, 212);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 25);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "מחק";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(84, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "חפש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(84, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCategory_code
            // 
            this.cmbCategory_code.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbCategory_code.FormattingEnabled = true;
            this.cmbCategory_code.Items.AddRange(new object[] {
            "category_code"});
            this.cmbCategory_code.Location = new System.Drawing.Point(58, 168);
            this.cmbCategory_code.Name = "cmbCategory_code";
            this.cmbCategory_code.Size = new System.Drawing.Size(101, 23);
            this.cmbCategory_code.TabIndex = 22;
            this.cmbCategory_code.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_code_SelectedIndexChanged);
            this.cmbCategory_code.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_code_SelectionChangeCommitted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.BackColor = System.Drawing.Color.Transparent;
            this.chkStatus.Enabled = false;
            this.chkStatus.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkStatus.Location = new System.Drawing.Point(79, 325);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(66, 19);
            this.chkStatus.TabIndex = 24;
            this.chkStatus.Text = "סטטוס";
            this.chkStatus.UseVisualStyleBackColor = false;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // txtCreature_year
            // 
            this.txtCreature_year.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCreature_year.Location = new System.Drawing.Point(58, 220);
            this.txtCreature_year.Name = "txtCreature_year";
            this.txtCreature_year.Size = new System.Drawing.Size(100, 25);
            this.txtCreature_year.TabIndex = 25;
            // 
            // cmbAuctionhouse_code
            // 
            this.cmbAuctionhouse_code.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbAuctionhouse_code.FormattingEnabled = true;
            this.cmbAuctionhouse_code.Items.AddRange(new object[] {
            "category_code"});
            this.cmbAuctionhouse_code.Location = new System.Drawing.Point(57, 194);
            this.cmbAuctionhouse_code.Name = "cmbAuctionhouse_code";
            this.cmbAuctionhouse_code.Size = new System.Drawing.Size(101, 23);
            this.cmbAuctionhouse_code.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(165, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "שם בית מכירות";
            // 
            // btnRe
            // 
            this.btnRe.BackColor = System.Drawing.Color.Red;
            this.btnRe.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRe.ForeColor = System.Drawing.Color.White;
            this.btnRe.Location = new System.Drawing.Point(84, 212);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(75, 26);
            this.btnRe.TabIndex = 26;
            this.btnRe.Text = "שחזר";
            this.btnRe.UseVisualStyleBackColor = false;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Red;
            this.btnP.Enabled = false;
            this.btnP.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnP.Location = new System.Drawing.Point(58, 280);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(133, 39);
            this.btnP.TabIndex = 27;
            this.btnP.Text = "לבחירת תמונה";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Visible = false;
            this.btnP.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNo.Location = new System.Drawing.Point(13, 192);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(65, 25);
            this.txtNo.TabIndex = 29;
            this.txtNo.Text = "אין תמונה";
            this.txtNo.Visible = false;
            // 
            // btnEr
            // 
            this.btnEr.BackColor = System.Drawing.Color.Red;
            this.btnEr.Font = new System.Drawing.Font("Fb Karnaf Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEr.Location = new System.Drawing.Point(276, 39);
            this.btnEr.Name = "btnEr";
            this.btnEr.Size = new System.Drawing.Size(133, 39);
            this.btnEr.TabIndex = 31;
            this.btnEr.Text = "להסטורית מוצר";
            this.btnEr.UseVisualStyleBackColor = false;
            this.btnEr.Click += new System.EventHandler(this.btnEr_Click);
            // 
            // ProductFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(455, 337);
            this.Controls.Add(this.btnEr);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.txtCreature_year);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.cmbAuctionhouse_code);
            this.Controls.Add(this.cmbCategory_code);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.txtProduct_name);
            this.Controls.Add(this.txtProduct_code);
            this.Name = "ProductFRM";
            this.Text = "מוצר";
            this.Load += new System.EventHandler(this.ProductFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct_code;
        private System.Windows.Forms.TextBox txtProduct_name;
        private System.Windows.Forms.TextBox txtPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbCategory_code;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtCreature_year;
        private System.Windows.Forms.ComboBox cmbAuctionhouse_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnEr;
    }
}