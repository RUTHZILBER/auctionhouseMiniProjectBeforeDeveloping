namespace Auctionhouse.Gui
{
    partial class Sale3FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale3FRM));
            this.txtSale_code = new System.Windows.Forms.TextBox();
            this.cmbProduct_code = new System.Windows.Forms.ComboBox();
            this.cmbShow_place_code = new System.Windows.Forms.ComboBox();
            this.txtFirst_price = new System.Windows.Forms.TextBox();
            this.txtLast_price = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbIdClient = new System.Windows.Forms.ComboBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dtpDate_ = new System.Windows.Forms.DateTimePicker();
            this.dtpTim = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNewOffer = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnOp = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cmbIdClient);
            this.panel2.Controls.Add(this.btnSearchClient);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.dtpDate_);
            this.panel2.Controls.Add(this.dtpTim);
            this.panel2.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel2.Location = new System.Drawing.Point(41, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 52);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbIdClient
            // 
            this.cmbIdClient.FormattingEnabled = true;
            this.cmbIdClient.Location = new System.Drawing.Point(516, 22);
            this.cmbIdClient.Name = "cmbIdClient";
            this.cmbIdClient.Size = new System.Drawing.Size(121, 25);
            this.cmbIdClient.TabIndex = 31;
            this.cmbIdClient.SelectedIndexChanged += new System.EventHandler(this.cmbCodeClient_SelectedIndexChanged);
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.BackColor = System.Drawing.Color.Black;
            this.btnSearchClient.Font = new System.Drawing.Font("Gisha", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchClient.Location = new System.Drawing.Point(516, 0);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(121, 25);
            this.btnSearchClient.TabIndex = 32;
            this.btnSearchClient.Text = "לחפוש לקוח";
            this.btnSearchClient.UseVisualStyleBackColor = false;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click_1);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(410, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 28);
            this.txtCode.TabIndex = 12;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(435, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "קוד לקוח";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(313, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(184, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "שעה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "מחיר";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Red;
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(10, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(38, 42);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(68, 21);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(78, 28);
            this.txtCost.TabIndex = 4;
            this.txtCost.Visible = false;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // dtpDate_
            // 
            this.dtpDate_.Enabled = false;
            this.dtpDate_.Location = new System.Drawing.Point(247, 21);
            this.dtpDate_.Name = "dtpDate_";
            this.dtpDate_.Size = new System.Drawing.Size(157, 28);
            this.dtpDate_.TabIndex = 2;
            // 
            // dtpTim
            // 
            this.dtpTim.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.dtpTim.Enabled = false;
            this.dtpTim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTim.Location = new System.Drawing.Point(152, 21);
            this.dtpTim.Name = "dtpTim";
            this.dtpTim.Size = new System.Drawing.Size(89, 28);
            this.dtpTim.TabIndex = 1;
            this.dtpTim.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(119, 514);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "62345678";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(32, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "חפש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBegin.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBegin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBegin.Location = new System.Drawing.Point(207, 144);
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
            this.label11.Location = new System.Drawing.Point(612, 71);
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
            this.label13.Location = new System.Drawing.Point(446, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "לקוח מציע הצעות";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // btnNewOffer
            // 
            this.btnNewOffer.BackColor = System.Drawing.Color.Red;
            this.btnNewOffer.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNewOffer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewOffer.Location = new System.Drawing.Point(-1, 175);
            this.btnNewOffer.Name = "btnNewOffer";
            this.btnNewOffer.Size = new System.Drawing.Size(148, 29);
            this.btnNewOffer.TabIndex = 32;
            this.btnNewOffer.Text = "להצעה חדשה";
            this.btnNewOffer.UseVisualStyleBackColor = false;
            this.btnNewOffer.Click += new System.EventHandler(this.btnNewOffer_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Fb Karnaf Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(253, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(436, 30);
            this.label16.TabIndex = 35;
            this.label16.Text = "כדי להציע הצעה יש להקיש/לבחור מספר ת.ז. של לקוח קים שתקף האשראי יהיה תקין \r\nעד מו" +
    "עד המכירה, קוד תקין ללקוח ומחיר הצעה גבוה ממחיר אחרון שהוצע";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Red;
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFirst.Location = new System.Drawing.Point(617, 149);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(72, 42);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = ">>";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Red;
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrev.Location = new System.Drawing.Point(537, 149);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(72, 42);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = ">";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Red;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(452, 149);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 42);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "<";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Red;
            this.btnLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLast.Location = new System.Drawing.Point(371, 149);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 42);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "<<";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click_1);
            // 
            // btnOp
            // 
            this.btnOp.BackColor = System.Drawing.Color.Red;
            this.btnOp.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOp.Location = new System.Drawing.Point(7, 313);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(85, 65);
            this.btnOp.TabIndex = 36;
            this.btnOp.Text = "להסטורית מוצר";
            this.btnOp.UseVisualStyleBackColor = false;
            this.btnOp.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.Color.Red;
            this.btnLook.Font = new System.Drawing.Font("Fb Karnaf Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLook.Location = new System.Drawing.Point(94, 310);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(106, 65);
            this.btnLook.TabIndex = 37;
            this.btnLook.Text = "לאפשרויות צפיה במוצר";
            this.btnLook.UseVisualStyleBackColor = false;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // Sale3FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 387);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.btnOp);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnNewOffer);
            this.Controls.Add(this.label14);
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
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtLast_price);
            this.Controls.Add(this.txtFirst_price);
            this.Controls.Add(this.cmbShow_place_code);
            this.Controls.Add(this.cmbProduct_code);
            this.Controls.Add(this.txtSale_code);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Sale3FRM";
            this.Text = "מכירה";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker dtpTim;
        private System.Windows.Forms.DateTimePicker dtpDate_;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.ComboBox cmbIdClient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnNewOffer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Button btnLook;
    }
}