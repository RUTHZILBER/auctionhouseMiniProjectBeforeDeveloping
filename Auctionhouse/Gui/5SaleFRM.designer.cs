namespace Auctionhouse.Gui
{
    partial class Sale5FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale5FRM));
            this.txtSale_code = new System.Windows.Forms.TextBox();
            this.cmbProduct_code = new System.Windows.Forms.ComboBox();
            this.cmbShow_place_code = new System.Windows.Forms.ComboBox();
            this.txtFirst_price = new System.Windows.Forms.TextBox();
            this.txtLast_price = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgSale_offer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpStart_date = new System.Windows.Forms.DateTimePicker();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPutoff = new System.Windows.Forms.Button();
            this.btnOtherSP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale_offer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSale_code
            // 
            this.txtSale_code.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSale_code.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSale_code.Location = new System.Drawing.Point(32, 40);
            this.txtSale_code.Name = "txtSale_code";
            this.txtSale_code.ReadOnly = true;
            this.txtSale_code.Size = new System.Drawing.Size(75, 28);
            this.txtSale_code.TabIndex = 0;
            // 
            // cmbProduct_code
            // 
            this.cmbProduct_code.Enabled = false;
            this.cmbProduct_code.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbProduct_code.FormattingEnabled = true;
            this.cmbProduct_code.Location = new System.Drawing.Point(561, 97);
            this.cmbProduct_code.Name = "cmbProduct_code";
            this.cmbProduct_code.Size = new System.Drawing.Size(166, 25);
            this.cmbProduct_code.TabIndex = 1;
            this.cmbProduct_code.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_code_SelectedIndexChanged);
            this.cmbProduct_code.SelectionChangeCommitted += new System.EventHandler(this.cmbProduct_code_SelectionChangeCommitted);
            this.cmbProduct_code.ValueMemberChanged += new System.EventHandler(this.cmbProduct_code_SelectionChangeCommitted);
            // 
            // cmbShow_place_code
            // 
            this.cmbShow_place_code.Enabled = false;
            this.cmbShow_place_code.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbShow_place_code.FormattingEnabled = true;
            this.cmbShow_place_code.Location = new System.Drawing.Point(408, 96);
            this.cmbShow_place_code.Name = "cmbShow_place_code";
            this.cmbShow_place_code.Size = new System.Drawing.Size(147, 25);
            this.cmbShow_place_code.TabIndex = 2;
            this.cmbShow_place_code.SelectedIndexChanged += new System.EventHandler(this.cmbShow_place_code_SelectedIndexChanged);
            // 
            // txtFirst_price
            // 
            this.txtFirst_price.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFirst_price.Location = new System.Drawing.Point(255, 20);
            this.txtFirst_price.Name = "txtFirst_price";
            this.txtFirst_price.ReadOnly = true;
            this.txtFirst_price.Size = new System.Drawing.Size(69, 28);
            this.txtFirst_price.TabIndex = 3;
            this.txtFirst_price.TextChanged += new System.EventHandler(this.txtFirst_price_TextChanged);
            // 
            // txtLast_price
            // 
            this.txtLast_price.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLast_price.Location = new System.Drawing.Point(121, 20);
            this.txtLast_price.Name = "txtLast_price";
            this.txtLast_price.ReadOnly = true;
            this.txtLast_price.Size = new System.Drawing.Size(68, 28);
            this.txtLast_price.TabIndex = 5;
            this.txtLast_price.TextChanged += new System.EventHandler(this.txtLast_price_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.dgSale_offer);
            this.panel1.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(183, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 257);
            this.panel1.TabIndex = 8;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Red;
            this.btnLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLast.Location = new System.Drawing.Point(3, 212);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 42);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "<<";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Red;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(84, 212);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 42);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "<";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Red;
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrev.Location = new System.Drawing.Point(386, 212);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 42);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = ">";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Red;
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFirst.Location = new System.Drawing.Point(466, 212);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 42);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = ">>";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dgSale_offer
            // 
            this.dgSale_offer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale_offer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgSale_offer.Location = new System.Drawing.Point(-3, 0);
            this.dgSale_offer.Name = "dgSale_offer";
            this.dgSale_offer.ReadOnly = true;
            this.dgSale_offer.Size = new System.Drawing.Size(544, 206);
            this.dgSale_offer.TabIndex = 0;
            this.dgSale_offer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSale_offer_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sale_code";
            this.Column1.HeaderText = "קוד מכירה";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "id";
            this.Column2.HeaderText = "מספר זהוי";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date_";
            this.Column3.HeaderText = "תאריך";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "a";
            this.Column4.HeaderText = "שעה";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cost";
            this.Column5.HeaderText = "מחיר";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(32, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "חפש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Red;
            this.btnNew.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(32, 186);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "אשור";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBegin.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBegin.Location = new System.Drawing.Point(-2, 325);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 72);
            this.btnBegin.TabIndex = 15;
            this.btnBegin.Text = "לחזרה לתפריט ראשי";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(227, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "מחיר התחלתי";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(325, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "תאריך פתיחה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(119, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "מחיר סופי";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(323, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "תאריך סיום";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(31, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "קוד מכירה";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(650, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "שם מוצר";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(429, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "שם אולם תצוגה";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dtpStart_date
            // 
            this.dtpStart_date.Enabled = false;
            this.dtpStart_date.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpStart_date.Location = new System.Drawing.Point(122, 51);
            this.dtpStart_date.Name = "dtpStart_date";
            this.dtpStart_date.Size = new System.Drawing.Size(203, 28);
            this.dtpStart_date.TabIndex = 24;
            this.dtpStart_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Enabled = false;
            this.dtpDeadline.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpDeadline.Location = new System.Drawing.Point(122, 83);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(202, 28);
            this.dtpDeadline.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Fb Karnaf", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(448, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "מכירות לעדכוני מנהל";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchProduct.Enabled = false;
            this.btnSearchProduct.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearchProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchProduct.Location = new System.Drawing.Point(555, 70);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(97, 23);
            this.btnSearchProduct.TabIndex = 27;
            this.btnSearchProduct.Text = "לחפוש מוצר";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(9, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 29;
            this.label14.Visible = false;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(32, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "בטול";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPutoff
            // 
            this.btnPutoff.BackColor = System.Drawing.Color.Red;
            this.btnPutoff.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPutoff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPutoff.Location = new System.Drawing.Point(-2, 264);
            this.btnPutoff.Name = "btnPutoff";
            this.btnPutoff.Size = new System.Drawing.Size(134, 23);
            this.btnPutoff.TabIndex = 33;
            this.btnPutoff.Text = "לדחית מועד המכירה";
            this.btnPutoff.UseVisualStyleBackColor = false;
            this.btnPutoff.Click += new System.EventHandler(this.btnPutoff_Click);
            // 
            // btnOtherSP
            // 
            this.btnOtherSP.BackColor = System.Drawing.Color.Red;
            this.btnOtherSP.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOtherSP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOtherSP.Location = new System.Drawing.Point(-2, 283);
            this.btnOtherSP.Name = "btnOtherSP";
            this.btnOtherSP.Size = new System.Drawing.Size(134, 23);
            this.btnOtherSP.TabIndex = 34;
            this.btnOtherSP.Text = "לשנוי אולם תצוגה";
            this.btnOtherSP.UseVisualStyleBackColor = false;
            this.btnOtherSP.Click += new System.EventHandler(this.btnOtherSP_Click);
            // 
            // Sale5FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 393);
            this.Controls.Add(this.btnOtherSP);
            this.Controls.Add(this.btnPutoff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.dtpStart_date);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLast_price);
            this.Controls.Add(this.txtFirst_price);
            this.Controls.Add(this.cmbShow_place_code);
            this.Controls.Add(this.cmbProduct_code);
            this.Controls.Add(this.txtSale_code);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Sale5FRM";
            this.Text = "מכירה";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSale_offer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSale_code;
        private System.Windows.Forms.ComboBox cmbProduct_code;
        private System.Windows.Forms.ComboBox cmbShow_place_code;
        private System.Windows.Forms.TextBox txtFirst_price;
        private System.Windows.Forms.TextBox txtLast_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgSale_offer;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpStart_date;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOtherSP;
        private System.Windows.Forms.Button btnPutoff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}