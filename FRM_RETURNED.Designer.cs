namespace MANGEMENT.PL
{
    partial class FRM_RETURNED
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
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnPrintReturn = new System.Windows.Forms.Button();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtProcessedBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrintSingle = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchReturnId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDISCOUNT = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtTotalReturns = new System.Windows.Forms.TextBox();
            this.CmdOrder = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearchOrder.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrder.ForeColor = System.Drawing.Color.White;
            this.btnSearchOrder.Location = new System.Drawing.Point(711, 599);
            this.btnSearchOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(127, 47);
            this.btnSearchOrder.TabIndex = 0;
            this.btnSearchOrder.Text = "الخروج";
            this.btnSearchOrder.UseVisualStyleBackColor = false;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnPrintReturn
            // 
            this.btnPrintReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrintReturn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReturn.ForeColor = System.Drawing.Color.White;
            this.btnPrintReturn.Location = new System.Drawing.Point(711, 535);
            this.btnPrintReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrintReturn.Name = "btnPrintReturn";
            this.btnPrintReturn.Size = new System.Drawing.Size(127, 47);
            this.btnPrintReturn.TabIndex = 1;
            this.btnPrintReturn.Text = "طباعة فاتورة العميل";
            this.btnPrintReturn.UseVisualStyleBackColor = false;
            this.btnPrintReturn.Click += new System.EventHandler(this.btnPrintReturn_Click);
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddReturn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReturn.ForeColor = System.Drawing.Color.White;
            this.btnAddReturn.Location = new System.Drawing.Point(864, 535);
            this.btnAddReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(118, 46);
            this.btnAddReturn.TabIndex = 2;
            this.btnAddReturn.Text = "الإضافة";
            this.btnAddReturn.UseVisualStyleBackColor = false;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 22);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(631, 659);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Location = new System.Drawing.Point(661, 215);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(271, 17);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReason.Location = new System.Drawing.Point(654, 426);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(271, 17);
            this.txtReason.TabIndex = 7;
            this.txtReason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReason_KeyDown);
            // 
            // txtProcessedBy
            // 
            this.txtProcessedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcessedBy.Location = new System.Drawing.Point(661, 469);
            this.txtProcessedBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtProcessedBy.Name = "txtProcessedBy";
            this.txtProcessedBy.Size = new System.Drawing.Size(271, 17);
            this.txtProcessedBy.TabIndex = 8;
            this.txtProcessedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProcessedBy_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(952, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "الكمية المرتجعة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(946, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "سبب الإرجاع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(946, 466);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "المسؤول";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(952, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "نوع المنتج";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(951, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "رقم الفاتورة";
            // 
            // btnPrintSingle
            // 
            this.btnPrintSingle.BackColor = System.Drawing.Color.Teal;
            this.btnPrintSingle.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSingle.ForeColor = System.Drawing.Color.White;
            this.btnPrintSingle.Location = new System.Drawing.Point(864, 599);
            this.btnPrintSingle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrintSingle.Name = "btnPrintSingle";
            this.btnPrintSingle.Size = new System.Drawing.Size(118, 46);
            this.btnPrintSingle.TabIndex = 15;
            this.btnPrintSingle.Text = "الطباعة";
            this.btnPrintSingle.UseVisualStyleBackColor = false;
            this.btnPrintSingle.Click += new System.EventHandler(this.btnPrintSingle_Click_1);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(667, 104);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(272, 24);
            this.cmbCustomer.TabIndex = 16;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            this.cmbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomer_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(952, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "العميل";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Location = new System.Drawing.Point(657, 264);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(271, 17);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(667, 158);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(272, 24);
            this.cmbProduct.TabIndex = 19;
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            this.cmbProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProduct_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(952, 259);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "المبلغ";
            // 
            // txtSearchReturnId
            // 
            this.txtSearchReturnId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchReturnId.Location = new System.Drawing.Point(16, -8);
            this.txtSearchReturnId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchReturnId.Multiline = true;
            this.txtSearchReturnId.Name = "txtSearchReturnId";
            this.txtSearchReturnId.Size = new System.Drawing.Size(1119, 18);
            this.txtSearchReturnId.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-1, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1119, 1);
            this.textBox1.TabIndex = 81;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(661, 230);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 1);
            this.textBox3.TabIndex = 83;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(657, 280);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 1);
            this.textBox4.TabIndex = 84;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(654, 442);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(271, 1);
            this.textBox5.TabIndex = 85;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(661, 486);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(271, 1);
            this.textBox6.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(847, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 88;
            this.label8.Text = "نسبة الخصم";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDISCOUNT
            // 
            this.txtDISCOUNT.Location = new System.Drawing.Point(661, 351);
            this.txtDISCOUNT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDISCOUNT.Name = "txtDISCOUNT";
            this.txtDISCOUNT.Size = new System.Drawing.Size(139, 24);
            this.txtDISCOUNT.TabIndex = 89;
            this.txtDISCOUNT.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.txtDISCOUNT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            this.txtDISCOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDISCOUNT_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(655, 300);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(276, 17);
            this.txtAmount.TabIndex = 124;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox8.Location = new System.Drawing.Point(655, 317);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(277, 1);
            this.textBox8.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(951, 297);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 22);
            this.label9.TabIndex = 122;
            this.label9.Text = "الإجمالي قبل الخصم";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(946, 385);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(127, 22);
            this.label10.TabIndex = 127;
            this.label10.Text = "الإجمالي بعد الخصم ";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Black;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox11.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox11.Location = new System.Drawing.Point(657, 406);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(275, 1);
            this.textBox11.TabIndex = 126;
            // 
            // txtTotalReturns
            // 
            this.txtTotalReturns.BackColor = System.Drawing.Color.White;
            this.txtTotalReturns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalReturns.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTotalReturns.ForeColor = System.Drawing.Color.Black;
            this.txtTotalReturns.Location = new System.Drawing.Point(655, 389);
            this.txtTotalReturns.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotalReturns.Name = "txtTotalReturns";
            this.txtTotalReturns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalReturns.Size = new System.Drawing.Size(279, 20);
            this.txtTotalReturns.TabIndex = 125;
            this.txtTotalReturns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalReturns_KeyDown);
            // 
            // CmdOrder
            // 
            this.CmdOrder.FormattingEnabled = true;
            this.CmdOrder.Location = new System.Drawing.Point(667, 45);
            this.CmdOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CmdOrder.Name = "CmdOrder";
            this.CmdOrder.Size = new System.Drawing.Size(272, 24);
            this.CmdOrder.TabIndex = 128;
            this.CmdOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmdOrder_KeyDown);
            this.CmdOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmdOrder_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(-2, 671);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(1130, 38);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1095, -10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(29, 690);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(-25, 20);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1119, 1);
            this.textBox2.TabIndex = 132;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(-8, 10);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(1119, 18);
            this.textBox7.TabIndex = 131;
            // 
            // FRM_RETURNED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 706);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CmdOrder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.txtTotalReturns);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDISCOUNT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSearchReturnId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnPrintSingle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcessedBy);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.btnPrintReturn);
            this.Controls.Add(this.btnSearchOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FRM_RETURNED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_RETURNED";
            this.Load += new System.EventHandler(this.FRM_RETURNED_Load);
            this.Shown += new System.EventHandler(this.FRM_RETURNED_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_RETURNED_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Button btnPrintReturn;
        private System.Windows.Forms.Button btnAddReturn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtProcessedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrintSingle;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchReturnId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDISCOUNT;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtTotalReturns;
        private System.Windows.Forms.ComboBox CmdOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
    }
}