namespace MANGEMENT.PL
{
    partial class FRM_DAILY_EXPENSES
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
            this.btnprint = new System.Windows.Forms.Button();
            this.btnPrints = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDailyTotal = new System.Windows.Forms.Label();
            this.dataGridViewExpenses = new System.Windows.Forms.DataGridView();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.txtExpenseID = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.cobUserName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSearchReturnId = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnprint);
            this.groupBox3.Controls.Add(this.btnPrints);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnDeleteExpense);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnAddExpense);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(609, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 135);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // btnprint
            // 
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = global::MANGEMENT.Properties.Resources.icons8_Print_48px;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(332, 83);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(143, 48);
            this.btnprint.TabIndex = 45;
            this.btnprint.Text = "طباعة قيد ";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click_1);
            // 
            // btnPrints
            // 
            this.btnPrints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrints.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrints.Image = global::MANGEMENT.Properties.Resources.icons8_Print_48px;
            this.btnPrints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrints.Location = new System.Drawing.Point(186, 83);
            this.btnPrints.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrints.Name = "btnPrints";
            this.btnPrints.Size = new System.Drawing.Size(142, 48);
            this.btnPrints.TabIndex = 44;
            this.btnPrints.Text = "طباعة الكل";
            this.btnPrints.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrints.UseVisualStyleBackColor = true;
            this.btnPrints.Click += new System.EventHandler(this.btnPrints_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = global::MANGEMENT.Properties.Resources.icons8_Shutdown_48px1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(28, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 50);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "خروج";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Trash_48px1;
            this.btnDeleteExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteExpense.FlatAppearance.BorderSize = 2;
            this.btnDeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExpense.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteExpense.ImageKey = "(none)";
            this.btnDeleteExpense.Location = new System.Drawing.Point(148, 23);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(109, 54);
            this.btnDeleteExpense.TabIndex = 13;
            this.btnDeleteExpense.Text = "حذف";
            this.btnDeleteExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Available_Updates_50px_2;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(28, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(111, 53);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Add_List_48px;
            this.btnAddExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddExpense.FlatAppearance.BorderSize = 2;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddExpense.Location = new System.Drawing.Point(263, 24);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(100, 53);
            this.btnAddExpense.TabIndex = 12;
            this.btnAddExpense.Text = "إضافة";
            this.btnAddExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::MANGEMENT.Properties.Resources.icons8_New_48px;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(369, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 53);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDailyTotal);
            this.groupBox2.Controls.Add(this.dataGridViewExpenses);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(587, 540);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لإئحة المصروفات اليومية";
            // 
            // labelDailyTotal
            // 
            this.labelDailyTotal.AutoSize = true;
            this.labelDailyTotal.BackColor = System.Drawing.SystemColors.Control;
            this.labelDailyTotal.Enabled = false;
            this.labelDailyTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDailyTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDailyTotal.Location = new System.Drawing.Point(1, 517);
            this.labelDailyTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDailyTotal.Name = "labelDailyTotal";
            this.labelDailyTotal.Size = new System.Drawing.Size(190, 23);
            this.labelDailyTotal.TabIndex = 40;
            this.labelDailyTotal.Text = "                                    ";
            // 
            // dataGridViewExpenses
            // 
            this.dataGridViewExpenses.AllowUserToAddRows = false;
            this.dataGridViewExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenses.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewExpenses.MultiSelect = false;
            this.dataGridViewExpenses.Name = "dataGridViewExpenses";
            this.dataGridViewExpenses.ReadOnly = true;
            this.dataGridViewExpenses.RowHeadersWidth = 51;
            this.dataGridViewExpenses.RowTemplate.Height = 26;
            this.dataGridViewExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExpenses.Size = new System.Drawing.Size(581, 493);
            this.dataGridViewExpenses.TabIndex = 21;
            this.dataGridViewExpenses.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpenses_CellContentDoubleClick);
            this.dataGridViewExpenses.DoubleClick += new System.EventHandler(this.dataGridViewExpenses_DoubleClick);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox8.Location = new System.Drawing.Point(691, 101);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(221, 1);
            this.textBox8.TabIndex = 29;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox7.Location = new System.Drawing.Point(655, 48);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(272, 1);
            this.textBox7.TabIndex = 28;
            // 
            // datetime
            // 
            this.datetime.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.datetime.Enabled = false;
            this.datetime.Location = new System.Drawing.Point(642, 185);
            this.datetime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(297, 24);
            this.datetime.TabIndex = 26;
            this.datetime.ValueChanged += new System.EventHandler(this.dateTimePickerExpenseDate_ValueChanged);
            this.datetime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datetime_KeyDown);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDescription.Location = new System.Drawing.Point(632, 83);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(296, 80);
            this.textBoxDescription.TabIndex = 25;
            this.textBoxDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDescription_KeyDown);
            // 
            // txtExpenseID
            // 
            this.txtExpenseID.BackColor = System.Drawing.SystemColors.Control;
            this.txtExpenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpenseID.Location = new System.Drawing.Point(655, 29);
            this.txtExpenseID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtExpenseID.Multiline = true;
            this.txtExpenseID.Name = "txtExpenseID";
            this.txtExpenseID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtExpenseID.Size = new System.Drawing.Size(273, 24);
            this.txtExpenseID.TabIndex = 27;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmount.Location = new System.Drawing.Point(641, 247);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAmount.Size = new System.Drawing.Size(297, 17);
            this.textBoxAmount.TabIndex = 31;
            this.textBoxAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAmount_KeyDown);
            // 
            // cobUserName
            // 
            this.cobUserName.BackColor = System.Drawing.SystemColors.Control;
            this.cobUserName.FormattingEnabled = true;
            this.cobUserName.Items.AddRange(new object[] {
            "نقد",
            "أجل"});
            this.cobUserName.Location = new System.Drawing.Point(647, 361);
            this.cobUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cobUserName.Name = "cobUserName";
            this.cobUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cobUserName.Size = new System.Drawing.Size(297, 24);
            this.cobUserName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(941, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "رقم المعرف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(941, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "نوع الصرفة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(960, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "التاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(960, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "المبلغ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(978, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "المستخدم";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNotes.Location = new System.Drawing.Point(642, 305);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNotes.Size = new System.Drawing.Size(297, 17);
            this.textBoxNotes.TabIndex = 33;
            this.textBoxNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNotes_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(960, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "الملاحضات";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(642, 264);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 1);
            this.textBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(643, 322);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 1);
            this.textBox2.TabIndex = 41;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(-4, 2);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1118, 1);
            this.textBox3.TabIndex = 109;
            // 
            // txtSearchReturnId
            // 
            this.txtSearchReturnId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchReturnId.Location = new System.Drawing.Point(-4, -19);
            this.txtSearchReturnId.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchReturnId.Multiline = true;
            this.txtSearchReturnId.Name = "txtSearchReturnId";
            this.txtSearchReturnId.Size = new System.Drawing.Size(1094, 24);
            this.txtSearchReturnId.TabIndex = 108;
            // 
            // FRM_DAILY_EXPENSES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1096, 550);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSearchReturnId);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.cobUserName);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.txtExpenseID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FRM_DAILY_EXPENSES";
            this.Text = "FRM_DAILY_EXPENSES";
            this.Load += new System.EventHandler(this.FRM_DAILY_EXPENSES_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_DAILY_EXPENSES_MouseDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewExpenses;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker datetime;
        public System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox txtExpenseID;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox cobUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDailyTotal;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrints;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtSearchReturnId;
    }
}