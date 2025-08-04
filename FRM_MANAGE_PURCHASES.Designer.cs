namespace MANGEMENT.PL
{
    partial class FRM_MANAGE_PURCHASES
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
            System.Windows.Forms.GroupBox groupBox2;
            this.button1 = new System.Windows.Forms.Button();
            this.btnprintInvoice = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPurchasesItems = new System.Windows.Forms.DataGridView();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInvoiceType = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearchReturnId = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasesItems)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.button1);
            groupBox2.Controls.Add(this.btnprintInvoice);
            groupBox2.Controls.Add(this.btnSaveInvoice);
            groupBox2.Controls.Add(this.button2);
            groupBox2.Controls.Add(this.button6);
            groupBox2.Controls.Add(this.button3);
            groupBox2.Controls.Add(this.button4);
            groupBox2.Controls.Add(this.btnAddProduct);
            groupBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            groupBox2.Location = new System.Drawing.Point(3, 418);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(591, 121);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "العمليات المتاحة";
            groupBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "طباعة المشتريات الحالية";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprintInvoice
            // 
            this.btnprintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprintInvoice.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnprintInvoice.FlatAppearance.BorderSize = 2;
            this.btnprintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintInvoice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintInvoice.Location = new System.Drawing.Point(351, 56);
            this.btnprintInvoice.Name = "btnprintInvoice";
            this.btnprintInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnprintInvoice.Size = new System.Drawing.Size(120, 32);
            this.btnprintInvoice.TabIndex = 20;
            this.btnprintInvoice.Text = "طباعة كل المشتريات";
            this.btnprintInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprintInvoice.UseVisualStyleBackColor = true;
            this.btnprintInvoice.UseWaitCursor = true;
            this.btnprintInvoice.Click += new System.EventHandler(this.btnprintInvoice_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveInvoice.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnSaveInvoice.FlatAppearance.BorderSize = 2;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.Location = new System.Drawing.Point(53, 19);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(76, 32);
            this.btnSaveInvoice.TabIndex = 19;
            this.btnSaveInvoice.Text = "حفظ";
            this.btnSaveInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.UseWaitCursor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::MANGEMENT.Properties.Resources.icons8_Delete_48px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(96, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::MANGEMENT.Properties.Resources.icons8_New_48px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(394, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 29);
            this.button6.TabIndex = 15;
            this.button6.Text = "جديد";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Trash_48px1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImageKey = "(none)";
            this.button3.Location = new System.Drawing.Point(222, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Available_Updates_50px_2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(135, 20);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(82, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "تعديل";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Add_List_48px;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddProduct.FlatAppearance.BorderSize = 2;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(309, 23);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(73, 29);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "إضافة";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.UseWaitCursor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalAmount.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(350, 506);
            this.textBoxTotalAmount.Multiline = true;
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ShortcutsEnabled = false;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(87, 29);
            this.textBoxTotalAmount.TabIndex = 56;
            this.textBoxTotalAmount.Tag = "";
            this.textBoxTotalAmount.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "التاريخ";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "نوع المنتج";
            // 
            // DateT
            // 
            this.DateT.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DateT.Location = new System.Drawing.Point(124, 60);
            this.DateT.Name = "DateT";
            this.DateT.Size = new System.Drawing.Size(251, 23);
            this.DateT.TabIndex = 31;
            this.DateT.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "معرف المورد";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "الكمية";
            // 
            // dataGridViewPurchasesItems
            // 
            this.dataGridViewPurchasesItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchasesItems.Location = new System.Drawing.Point(5, 44);
            this.dataGridViewPurchasesItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewPurchasesItems.Name = "dataGridViewPurchasesItems";
            this.dataGridViewPurchasesItems.RowHeadersWidth = 62;
            this.dataGridViewPurchasesItems.RowTemplate.Height = 29;
            this.dataGridViewPurchasesItems.Size = new System.Drawing.Size(440, 397);
            this.dataGridViewPurchasesItems.TabIndex = 8;
            this.dataGridViewPurchasesItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchasesItems_CellClick);
            this.dataGridViewPurchasesItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchasesItems_CellContentClick);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.txtSearch);
            this.groupBox22.Controls.Add(this.btnSearch);
            this.groupBox22.Controls.Add(this.dataGridViewPurchasesItems);
            this.groupBox22.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox22.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox22.Location = new System.Drawing.Point(2, 23);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(441, 441);
            this.groupBox22.TabIndex = 55;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "بيانات ";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(119, 13);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShortcutsEnabled = false;
            this.txtSearch.Size = new System.Drawing.Size(253, 25);
            this.txtSearch.TabIndex = 47;
            this.txtSearch.Tag = "";
            this.txtSearch.UseWaitCursor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(377, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 27);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "البحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(124, 22);
            this.cmbSuppliers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(250, 23);
            this.cmbSuppliers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "السعر";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(124, 104);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(248, 23);
            this.cmbProducts.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtUnitPrice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(124, 211);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ShortcutsEnabled = false;
            this.txtUnitPrice.Size = new System.Drawing.Size(247, 25);
            this.txtUnitPrice.TabIndex = 26;
            this.txtUnitPrice.Tag = "";
            this.txtUnitPrice.UseWaitCursor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(124, 155);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ShortcutsEnabled = false;
            this.txtQuantity.Size = new System.Drawing.Size(247, 25);
            this.txtQuantity.TabIndex = 25;
            this.txtQuantity.Tag = "";
            this.txtQuantity.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInvoiceType);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPurchaseID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DateT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSuppliers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(groupBox2);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.cmbProducts);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(449, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 542);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات";
            // 
            // txtInvoiceType
            // 
            this.txtInvoiceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceType.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtInvoiceType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceType.Location = new System.Drawing.Point(124, 297);
            this.txtInvoiceType.Multiline = true;
            this.txtInvoiceType.Name = "txtInvoiceType";
            this.txtInvoiceType.ShortcutsEnabled = false;
            this.txtInvoiceType.Size = new System.Drawing.Size(247, 25);
            this.txtInvoiceType.TabIndex = 49;
            this.txtInvoiceType.Tag = "";
            this.txtInvoiceType.UseWaitCursor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(124, 256);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ShortcutsEnabled = false;
            this.txtTotal.Size = new System.Drawing.Size(247, 25);
            this.txtTotal.TabIndex = 48;
            this.txtTotal.Tag = "";
            this.txtTotal.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "معرف الشراء";
            this.label6.UseWaitCursor = true;
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurchaseID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtPurchaseID.Enabled = false;
            this.txtPurchaseID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseID.Location = new System.Drawing.Point(152, 339);
            this.txtPurchaseID.Multiline = true;
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.ShortcutsEnabled = false;
            this.txtPurchaseID.Size = new System.Drawing.Size(219, 21);
            this.txtPurchaseID.TabIndex = 46;
            this.txtPurchaseID.Tag = "";
            this.txtPurchaseID.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-8, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1070, 1);
            this.textBox1.TabIndex = 109;
            // 
            // txtSearchReturnId
            // 
            this.txtSearchReturnId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchReturnId.Location = new System.Drawing.Point(-8, -10);
            this.txtSearchReturnId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchReturnId.Multiline = true;
            this.txtSearchReturnId.Name = "txtSearchReturnId";
            this.txtSearchReturnId.Size = new System.Drawing.Size(1070, 18);
            this.txtSearchReturnId.TabIndex = 108;
            // 
            // FRM_MANAGE_PURCHASES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 570);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.txtSearchReturnId);
            this.Controls.Add(this.groupBox22);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FRM_MANAGE_PURCHASES";
            this.Text = "FRM_MANAGE_PURCHASES";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_MANAGE_PURCHASES_MouseDown);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasesItems)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPurchasesItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnprintInvoice;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.GroupBox groupBox22;
        public System.Windows.Forms.ComboBox cmbSuppliers;
        public System.Windows.Forms.ComboBox cmbProducts;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvoiceType;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearchReturnId;
    }
}