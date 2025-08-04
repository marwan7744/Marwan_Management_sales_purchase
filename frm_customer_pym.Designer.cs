namespace MANGEMENT.PL
{
    partial class frm_customer_pym
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
            System.Windows.Forms.GroupBox groupBox33;
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnAddOrUpdateDebt = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.btnNEW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateT = new System.Windows.Forms.DateTimePicker();
            this.btnPrevious2 = new System.Windows.Forms.Button();
            this.btnFirst2 = new System.Windows.Forms.Button();
            this.btnLast2 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.lblPosition1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewDebts = new System.Windows.Forms.DataGridView();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtSearch11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxPaymentAmount = new System.Windows.Forms.TextBox();
            groupBox33 = new System.Windows.Forms.GroupBox();
            groupBox33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebts)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox33
            // 
            groupBox33.Controls.Add(this.btnprint);
            groupBox33.Controls.Add(this.btnclose2);
            groupBox33.Controls.Add(this.btnDELETE);
            groupBox33.Controls.Add(this.btnAddOrUpdateDebt);
            groupBox33.Controls.Add(this.buttonPay);
            groupBox33.Controls.Add(this.btnNEW);
            groupBox33.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            groupBox33.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox33.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox33.ImeMode = System.Windows.Forms.ImeMode.On;
            groupBox33.Location = new System.Drawing.Point(3, 339);
            groupBox33.Name = "groupBox33";
            groupBox33.Size = new System.Drawing.Size(423, 88);
            groupBox33.TabIndex = 41;
            groupBox33.TabStop = false;
            groupBox33.Text = "العمليات المتاحة";
            groupBox33.UseWaitCursor = true;
            // 
            // btnprint
            // 
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnprint.FlatAppearance.BorderSize = 2;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(314, 50);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(86, 32);
            this.btnprint.TabIndex = 19;
            this.btnprint.Text = "طباعة الديون";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.UseWaitCursor = true;
            // 
            // btnclose2
            // 
            this.btnclose2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnclose2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnclose2.FlatAppearance.BorderSize = 2;
            this.btnclose2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose2.Image = global::MANGEMENT.Properties.Resources.icons8_Delete_48px;
            this.btnclose2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose2.Location = new System.Drawing.Point(204, 51);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(92, 30);
            this.btnclose2.TabIndex = 18;
            this.btnclose2.Text = "خروج";
            this.btnclose2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose2.UseVisualStyleBackColor = false;
            this.btnclose2.UseWaitCursor = true;
            this.btnclose2.Click += new System.EventHandler(this.btnclose2_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Trash_48px1;
            this.btnDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDELETE.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnDELETE.FlatAppearance.BorderSize = 2;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.ImageKey = "(none)";
            this.btnDELETE.Location = new System.Drawing.Point(164, 14);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(80, 29);
            this.btnDELETE.TabIndex = 13;
            this.btnDELETE.Text = "حذف";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.UseWaitCursor = true;
            // 
            // btnAddOrUpdateDebt
            // 
            this.btnAddOrUpdateDebt.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Available_Updates_50px_2;
            this.btnAddOrUpdateDebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddOrUpdateDebt.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddOrUpdateDebt.FlatAppearance.BorderSize = 2;
            this.btnAddOrUpdateDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrUpdateDebt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrUpdateDebt.Location = new System.Drawing.Point(78, 16);
            this.btnAddOrUpdateDebt.Name = "btnAddOrUpdateDebt";
            this.btnAddOrUpdateDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddOrUpdateDebt.Size = new System.Drawing.Size(82, 29);
            this.btnAddOrUpdateDebt.TabIndex = 14;
            this.btnAddOrUpdateDebt.Text = "تعديل";
            this.btnAddOrUpdateDebt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddOrUpdateDebt.UseVisualStyleBackColor = true;
            this.btnAddOrUpdateDebt.UseWaitCursor = true;
            // 
            // buttonPay
            // 
            this.buttonPay.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Add_List_48px;
            this.buttonPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPay.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonPay.FlatAppearance.BorderSize = 2;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Location = new System.Drawing.Point(249, 14);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(73, 29);
            this.buttonPay.TabIndex = 12;
            this.buttonPay.Text = "إضافة";
            this.buttonPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.UseWaitCursor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click_1);
            // 
            // btnNEW
            // 
            this.btnNEW.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNEW.FlatAppearance.BorderSize = 2;
            this.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNEW.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNEW.Image = global::MANGEMENT.Properties.Resources.icons8_New_48px;
            this.btnNEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNEW.Location = new System.Drawing.Point(327, 14);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(74, 29);
            this.btnNEW.TabIndex = 15;
            this.btnNEW.Text = "جديد";
            this.btnNEW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNEW.UseVisualStyleBackColor = true;
            this.btnNEW.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "التاريخ";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "رقم المعرف";
            this.label3.UseWaitCursor = true;
            // 
            // DateT
            // 
            this.DateT.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DateT.Location = new System.Drawing.Point(169, 171);
            this.DateT.Name = "DateT";
            this.DateT.Size = new System.Drawing.Size(164, 23);
            this.DateT.TabIndex = 31;
            this.DateT.UseWaitCursor = true;
            // 
            // btnPrevious2
            // 
            this.btnPrevious2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPrevious2.Image = global::MANGEMENT.Properties.Resources.icons8_Back_50px;
            this.btnPrevious2.Location = new System.Drawing.Point(269, 222);
            this.btnPrevious2.Name = "btnPrevious2";
            this.btnPrevious2.Size = new System.Drawing.Size(57, 25);
            this.btnPrevious2.TabIndex = 30;
            this.btnPrevious2.UseVisualStyleBackColor = true;
            this.btnPrevious2.UseWaitCursor = true;
            // 
            // btnFirst2
            // 
            this.btnFirst2.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_End_40px_1;
            this.btnFirst2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnFirst2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst2.Image = global::MANGEMENT.Properties.Resources.icons8_End_48px;
            this.btnFirst2.Location = new System.Drawing.Point(337, 222);
            this.btnFirst2.Name = "btnFirst2";
            this.btnFirst2.Size = new System.Drawing.Size(41, 25);
            this.btnFirst2.TabIndex = 29;
            this.btnFirst2.UseVisualStyleBackColor = true;
            this.btnFirst2.UseWaitCursor = true;
            // 
            // btnLast2
            // 
            this.btnLast2.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Skip_to_Start_48px1;
            this.btnLast2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnLast2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast2.Image = global::MANGEMENT.Properties.Resources.icons8_Skip_to_Start_48px2;
            this.btnLast2.Location = new System.Drawing.Point(121, 222);
            this.btnLast2.Name = "btnLast2";
            this.btnLast2.Size = new System.Drawing.Size(40, 25);
            this.btnLast2.TabIndex = 28;
            this.btnLast2.UseVisualStyleBackColor = true;
            this.btnLast2.UseWaitCursor = true;
            // 
            // btnNext1
            // 
            this.btnNext1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNext1.Image = global::MANGEMENT.Properties.Resources.icons8_Forward_50px;
            this.btnNext1.Location = new System.Drawing.Point(168, 222);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(57, 27);
            this.btnNext1.TabIndex = 26;
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.UseWaitCursor = true;
            // 
            // lblPosition1
            // 
            this.lblPosition1.AutoSize = true;
            this.lblPosition1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblPosition1.Location = new System.Drawing.Point(238, 228);
            this.lblPosition1.Name = "lblPosition1";
            this.lblPosition1.Size = new System.Drawing.Size(26, 17);
            this.lblPosition1.TabIndex = 27;
            this.lblPosition1.Text = "7/6";
            this.lblPosition1.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "مبلغ الدفع";
            this.label7.UseWaitCursor = true;
            // 
            // dataGridViewDebts
            // 
            this.dataGridViewDebts.AllowUserToAddRows = false;
            this.dataGridViewDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebts.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridViewDebts.Location = new System.Drawing.Point(9, 47);
            this.dataGridViewDebts.MultiSelect = false;
            this.dataGridViewDebts.Name = "dataGridViewDebts";
            this.dataGridViewDebts.ReadOnly = true;
            this.dataGridViewDebts.RowHeadersWidth = 51;
            this.dataGridViewDebts.RowTemplate.Height = 26;
            this.dataGridViewDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDebts.Size = new System.Drawing.Size(494, 379);
            this.dataGridViewDebts.TabIndex = 21;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch2.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Approval_48px1;
            this.btnSearch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch2.CausesValidation = false;
            this.btnSearch2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnSearch2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.btnSearch2.FlatAppearance.BorderSize = 0;
            this.btnSearch2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch2.Location = new System.Drawing.Point(9, 13);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(103, 25);
            this.btnSearch2.TabIndex = 19;
            this.btnSearch2.Text = "موافق                                                \r\n        موافق   ";
            this.btnSearch2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch2.UseMnemonic = false;
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.UseWaitCursor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dataGridViewDebts);
            this.groupBox11.Controls.Add(this.btnSearch2);
            this.groupBox11.Controls.Add(this.txtSearch11);
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox11.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(509, 433);
            this.groupBox11.TabIndex = 48;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "لإئحة الموظفين";
            // 
            // txtSearch11
            // 
            this.txtSearch11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch11.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSearch11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch11.Location = new System.Drawing.Point(121, 25);
            this.txtSearch11.Name = "txtSearch11";
            this.txtSearch11.Size = new System.Drawing.Size(246, 18);
            this.txtSearch11.TabIndex = 20;
            this.txtSearch11.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Location = new System.Drawing.Point(371, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ابحث هنا:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.UseWaitCursor = true;
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(166, 40);
            this.comboBoxCustomers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(167, 23);
            this.comboBoxCustomers.TabIndex = 45;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.textBoxCustomerID);
            this.groupBox22.Controls.Add(this.textBoxPaymentAmount);
            this.groupBox22.Controls.Add(this.comboBoxCustomers);
            this.groupBox22.Controls.Add(this.label4);
            this.groupBox22.Controls.Add(this.label3);
            this.groupBox22.Controls.Add(groupBox33);
            this.groupBox22.Controls.Add(this.DateT);
            this.groupBox22.Controls.Add(this.btnPrevious2);
            this.groupBox22.Controls.Add(this.btnFirst2);
            this.groupBox22.Controls.Add(this.btnLast2);
            this.groupBox22.Controls.Add(this.btnNext1);
            this.groupBox22.Controls.Add(this.lblPosition1);
            this.groupBox22.Controls.Add(this.label7);
            this.groupBox22.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox22.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox22.Location = new System.Drawing.Point(499, 0);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(429, 430);
            this.groupBox22.TabIndex = 49;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "بيانات المورد";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomerID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(167, 86);
            this.textBoxCustomerID.Multiline = true;
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ShortcutsEnabled = false;
            this.textBoxCustomerID.Size = new System.Drawing.Size(166, 25);
            this.textBoxCustomerID.TabIndex = 47;
            this.textBoxCustomerID.Tag = "";
            this.textBoxCustomerID.UseWaitCursor = true;
            // 
            // textBoxPaymentAmount
            // 
            this.textBoxPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPaymentAmount.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxPaymentAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaymentAmount.Location = new System.Drawing.Point(160, 127);
            this.textBoxPaymentAmount.Multiline = true;
            this.textBoxPaymentAmount.Name = "textBoxPaymentAmount";
            this.textBoxPaymentAmount.ShortcutsEnabled = false;
            this.textBoxPaymentAmount.Size = new System.Drawing.Size(166, 25);
            this.textBoxPaymentAmount.TabIndex = 46;
            this.textBoxPaymentAmount.Tag = "";
            this.textBoxPaymentAmount.UseWaitCursor = true;
            // 
            // frm_customer_pym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 433);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_customer_pym";
            this.Text = "frm_customer_pym";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_customer_pym_MouseDown);
            groupBox33.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebts)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateT;
        private System.Windows.Forms.Button btnPrevious2;
        private System.Windows.Forms.Button btnFirst2;
        private System.Windows.Forms.Button btnLast2;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Label lblPosition1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewDebts;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtSearch11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnAddOrUpdateDebt;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button btnNEW;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox textBoxPaymentAmount;
        private System.Windows.Forms.TextBox textBoxCustomerID;
    }
}