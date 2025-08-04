namespace MANGEMENT.PL
{
    partial class CashBoxForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTotalRetailSales = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txtTotalReceipts = new System.Windows.Forms.TextBox();
            this.dgvCashBox = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbDocType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoRevenue = new System.Windows.Forms.RadioButton();
            this.rdoRetailSales = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(710, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 153);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::MANGEMENT.Properties.Resources.icons8_Print_48px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(164, 64);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 53);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "طباعة  ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::MANGEMENT.Properties.Resources.icons8_Downloading_Updates_48px1;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.Location = new System.Drawing.Point(316, 62);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(130, 53);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "عرض البيانات";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = global::MANGEMENT.Properties.Resources.icons8_Shutdown_48px1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(30, 65);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 52);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "خروج";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.txtTotalRetailSales);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.txtTotalRevenue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.txtTotalSales);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.txtTotalReceipts);
            this.groupBox2.Controls.Add(this.dgvCashBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(699, 698);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الصندوق";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(169, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(324, 1);
            this.textBox1.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 670);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "إجمالي البيع بالتجزئة ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(60, 686);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 1);
            this.textBox3.TabIndex = 100;
            // 
            // txtTotalRetailSales
            // 
            this.txtTotalRetailSales.BackColor = System.Drawing.Color.Silver;
            this.txtTotalRetailSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalRetailSales.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTotalRetailSales.ForeColor = System.Drawing.Color.Black;
            this.txtTotalRetailSales.Location = new System.Drawing.Point(57, 668);
            this.txtTotalRetailSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalRetailSales.Name = "txtTotalRetailSales";
            this.txtTotalRetailSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalRetailSales.Size = new System.Drawing.Size(137, 20);
            this.txtTotalRetailSales.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(205, 636);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(110, 21);
            this.label14.TabIndex = 97;
            this.label14.Text = "  إجمالي القبض   ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 669);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(102, 21);
            this.label11.TabIndex = 94;
            this.label11.Text = "إجمالي الإيرادات";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(470, 636);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 92;
            this.label9.Text = "إجمالي المبيعات";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Black;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox9.Location = new System.Drawing.Point(330, 686);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(131, 1);
            this.textBox9.TabIndex = 81;
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.BackColor = System.Drawing.Color.Silver;
            this.txtTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalRevenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTotalRevenue.ForeColor = System.Drawing.Color.Black;
            this.txtTotalRevenue.Location = new System.Drawing.Point(329, 670);
            this.txtTotalRevenue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalRevenue.Size = new System.Drawing.Size(135, 20);
            this.txtTotalRevenue.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(498, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "البحث";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(161, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 24);
            this.txtSearch.TabIndex = 85;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(331, 654);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 1);
            this.textBox5.TabIndex = 79;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.BackColor = System.Drawing.Color.Silver;
            this.txtTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalSales.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTotalSales.ForeColor = System.Drawing.Color.Black;
            this.txtTotalSales.Location = new System.Drawing.Point(330, 636);
            this.txtTotalSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalSales.Size = new System.Drawing.Size(134, 20);
            this.txtTotalSales.TabIndex = 78;
            this.txtTotalSales.TextChanged += new System.EventHandler(this.txtTotalSales_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.Black;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox15.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox15.Location = new System.Drawing.Point(60, 654);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(131, 1);
            this.textBox15.TabIndex = 77;
            // 
            // txtTotalReceipts
            // 
            this.txtTotalReceipts.BackColor = System.Drawing.Color.Silver;
            this.txtTotalReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalReceipts.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTotalReceipts.ForeColor = System.Drawing.Color.Black;
            this.txtTotalReceipts.Location = new System.Drawing.Point(58, 637);
            this.txtTotalReceipts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalReceipts.Name = "txtTotalReceipts";
            this.txtTotalReceipts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalReceipts.Size = new System.Drawing.Size(134, 20);
            this.txtTotalReceipts.TabIndex = 76;
            // 
            // dgvCashBox
            // 
            this.dgvCashBox.AllowUserToAddRows = false;
            this.dgvCashBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashBox.Location = new System.Drawing.Point(2, 44);
            this.dgvCashBox.MultiSelect = false;
            this.dgvCashBox.Name = "dgvCashBox";
            this.dgvCashBox.ReadOnly = true;
            this.dgvCashBox.RowHeadersWidth = 51;
            this.dgvCashBox.RowTemplate.Height = 26;
            this.dgvCashBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashBox.Size = new System.Drawing.Size(691, 573);
            this.dgvCashBox.TabIndex = 21;
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.dtpTo.Location = new System.Drawing.Point(720, 178);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(268, 24);
            this.dtpTo.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1019, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "إلى تاريخ";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Items.AddRange(new object[] {
            ""});
            this.cmbCustomer.Location = new System.Drawing.Point(726, 243);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCustomer.Size = new System.Drawing.Size(263, 28);
            this.cmbCustomer.TabIndex = 78;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(638, 723);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(538, 1);
            this.textBox2.TabIndex = 81;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.dtpFrom.Location = new System.Drawing.Point(721, 123);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(268, 24);
            this.dtpFrom.TabIndex = 87;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(638, 702);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 20);
            this.lblTotal.TabIndex = 88;
            this.lblTotal.Text = "lblTotal";
            // 
            // cmbDocType
            // 
            this.cmbDocType.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.Location = new System.Drawing.Point(721, 43);
            this.cmbDocType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(203, 28);
            this.cmbDocType.TabIndex = 89;
            this.cmbDocType.SelectedIndexChanged += new System.EventHandler(this.cmbDocType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1023, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 92;
            this.label4.Text = "من تاريخ";
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.AutoSize = true;
            this.rdoCustomer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCustomer.Location = new System.Drawing.Point(1022, 244);
            this.rdoCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(68, 23);
            this.rdoCustomer.TabIndex = 107;
            this.rdoCustomer.TabStop = true;
            this.rdoCustomer.Text = "العملاء";
            this.rdoCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAll.Location = new System.Drawing.Point(1001, 376);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(90, 23);
            this.rdoAll.TabIndex = 110;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "إختيار الكل";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoRevenue
            // 
            this.rdoRevenue.AutoSize = true;
            this.rdoRevenue.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRevenue.Location = new System.Drawing.Point(1026, 298);
            this.rdoRevenue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoRevenue.Name = "rdoRevenue";
            this.rdoRevenue.Size = new System.Drawing.Size(64, 23);
            this.rdoRevenue.TabIndex = 113;
            this.rdoRevenue.TabStop = true;
            this.rdoRevenue.Text = "الإيراد";
            this.rdoRevenue.UseVisualStyleBackColor = true;
            // 
            // rdoRetailSales
            // 
            this.rdoRetailSales.AutoSize = true;
            this.rdoRetailSales.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRetailSales.Location = new System.Drawing.Point(985, 327);
            this.rdoRetailSales.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoRetailSales.Name = "rdoRetailSales";
            this.rdoRetailSales.Size = new System.Drawing.Size(106, 23);
            this.rdoRetailSales.TabIndex = 114;
            this.rdoRetailSales.TabStop = true;
            this.rdoRetailSales.Text = "البيع بالتجزئة";
            this.rdoRetailSales.UseVisualStyleBackColor = true;
            // 
            // CashBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 729);
            this.Controls.Add(this.rdoRetailSales);
            this.Controls.Add(this.rdoRevenue);
            this.Controls.Add(this.rdoAll);
            this.Controls.Add(this.rdoCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDocType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "CashBoxForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashBoxForm";
            this.Load += new System.EventHandler(this.CashBoxForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CashBoxForm_MouseDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCashBox;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbDocType;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox txtTotalReceipts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTotalRetailSales;
        private System.Windows.Forms.RadioButton rdoRevenue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdoRetailSales;
    }
}