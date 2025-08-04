namespace MANGEMENT.PL
{
    partial class FRM_SHOW_ACCOUNTRY
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowCashLedger = new System.Windows.Forms.Button();
            this.btnPrintCashledger = new System.Windows.Forms.Button();
            this.btnShowCustomerLedger = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnPrintCustomerLedger = new System.Windows.Forms.Button();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.txtTotalBalance = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(810, 597);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnShowCashLedger
            // 
            this.btnShowCashLedger.BackColor = System.Drawing.Color.White;
            this.btnShowCashLedger.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCashLedger.Location = new System.Drawing.Point(780, 739);
            this.btnShowCashLedger.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCashLedger.Name = "btnShowCashLedger";
            this.btnShowCashLedger.Size = new System.Drawing.Size(124, 44);
            this.btnShowCashLedger.TabIndex = 1;
            this.btnShowCashLedger.Text = "عرض الكل";
            this.btnShowCashLedger.UseVisualStyleBackColor = false;
            this.btnShowCashLedger.Click += new System.EventHandler(this.btnShowCashLedger_Click);
            // 
            // btnPrintCashledger
            // 
            this.btnPrintCashledger.BackColor = System.Drawing.Color.White;
            this.btnPrintCashledger.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCashledger.Location = new System.Drawing.Point(648, 739);
            this.btnPrintCashledger.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintCashledger.Name = "btnPrintCashledger";
            this.btnPrintCashledger.Size = new System.Drawing.Size(124, 44);
            this.btnPrintCashledger.TabIndex = 2;
            this.btnPrintCashledger.Text = "طباعة الكل";
            this.btnPrintCashledger.UseVisualStyleBackColor = false;
            this.btnPrintCashledger.Click += new System.EventHandler(this.btnPrintCashledger_Click);
            // 
            // btnShowCustomerLedger
            // 
            this.btnShowCustomerLedger.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowCustomerLedger.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomerLedger.ForeColor = System.Drawing.Color.White;
            this.btnShowCustomerLedger.Location = new System.Drawing.Point(1003, 581);
            this.btnShowCustomerLedger.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCustomerLedger.Name = "btnShowCustomerLedger";
            this.btnShowCustomerLedger.Size = new System.Drawing.Size(124, 59);
            this.btnShowCustomerLedger.TabIndex = 3;
            this.btnShowCustomerLedger.Text = "العرض";
            this.btnShowCustomerLedger.UseVisualStyleBackColor = false;
            this.btnShowCustomerLedger.Click += new System.EventHandler(this.btnShowCustomerLedger_Click_1);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(818, 443);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(229, 27);
            this.cmbCustomer.TabIndex = 4;
            // 
            // btnPrintCustomerLedger
            // 
            this.btnPrintCustomerLedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrintCustomerLedger.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCustomerLedger.ForeColor = System.Drawing.Color.White;
            this.btnPrintCustomerLedger.Location = new System.Drawing.Point(841, 581);
            this.btnPrintCustomerLedger.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintCustomerLedger.Name = "btnPrintCustomerLedger";
            this.btnPrintCustomerLedger.Size = new System.Drawing.Size(124, 59);
            this.btnPrintCustomerLedger.TabIndex = 5;
            this.btnPrintCustomerLedger.Text = "طباعة";
            this.btnPrintCustomerLedger.UseVisualStyleBackColor = false;
            this.btnPrintCustomerLedger.Click += new System.EventHandler(this.btnPrintCustomerLedger_Click);
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDebit.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTotalDebit.Location = new System.Drawing.Point(822, 71);
            this.txtTotalDebit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.Size = new System.Drawing.Size(194, 20);
            this.txtTotalDebit.TabIndex = 6;
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCredit.ForeColor = System.Drawing.Color.SlateGray;
            this.txtTotalCredit.Location = new System.Drawing.Point(823, 111);
            this.txtTotalCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.Size = new System.Drawing.Size(194, 20);
            this.txtTotalCredit.TabIndex = 7;
            // 
            // txtTotalBalance
            // 
            this.txtTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBalance.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTotalBalance.Location = new System.Drawing.Point(821, 154);
            this.txtTotalBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalBalance.Name = "txtTotalBalance";
            this.txtTotalBalance.Size = new System.Drawing.Size(194, 20);
            this.txtTotalBalance.TabIndex = 8;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(823, 293);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(229, 27);
            this.dtpFrom.TabIndex = 13;
            this.dtpFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFrom_KeyDown);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(823, 342);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(229, 27);
            this.dtpTo.TabIndex = 14;
            this.dtpTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1025, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "إجمالي المدين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1025, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "إجمالي الدائن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1025, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "الرصيد الحالي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1061, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "من تاريح";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1061, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "إلى تاريح";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1055, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "إسم العميل";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(345, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 48;
            this.label10.Text = "البحث";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(526, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 31);
            this.label11.TabIndex = 49;
            this.label11.Text = "كشف حساب العملاء";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Shutdown_48px2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1066, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 48);
            this.button1.TabIndex = 46;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(829, 132);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 1);
            this.textBox3.TabIndex = 76;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(827, 174);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 1);
            this.textBox2.TabIndex = 77;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(827, 91);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 1);
            this.textBox4.TabIndex = 78;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(45, 39);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(295, 1);
            this.textBox5.TabIndex = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1195, 68);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1170, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(21, 645);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(-4, 687);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(1200, 24);
            this.groupBox3.TabIndex = 128;
            this.groupBox3.TabStop = false;
            // 
            // FRM_SHOW_ACCOUNTRY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 714);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtTotalBalance);
            this.Controls.Add(this.txtTotalCredit);
            this.Controls.Add(this.txtTotalDebit);
            this.Controls.Add(this.btnPrintCustomerLedger);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnShowCustomerLedger);
            this.Controls.Add(this.btnPrintCashledger);
            this.Controls.Add(this.btnShowCashLedger);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_SHOW_ACCOUNTRY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_SHOW_ACCOUNTRY";
            this.Load += new System.EventHandler(this.FRM_SHOW_ACCOUNTRY_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_SHOW_ACCOUNTRY_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_SHOW_ACCOUNTRY_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowCashLedger;
        private System.Windows.Forms.Button btnPrintCashledger;
        private System.Windows.Forms.Button btnShowCustomerLedger;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnPrintCustomerLedger;
        private System.Windows.Forms.TextBox txtTotalDebit;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtTotalBalance;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}