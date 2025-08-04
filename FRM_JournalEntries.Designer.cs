namespace MANGEMENT.PL
{
    partial class FRM_JournalEntries
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
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPrintCustomerLedger = new System.Windows.Forms.Button();
            this.btnShowCustomerLedger = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(350, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 27);
            this.label10.TabIndex = 53;
            this.label10.Text = "البحث";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox1.Location = new System.Drawing.Point(25, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 52;
            // 
            // btnPrintCustomerLedger
            // 
            this.btnPrintCustomerLedger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrintCustomerLedger.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCustomerLedger.ForeColor = System.Drawing.Color.White;
            this.btnPrintCustomerLedger.Location = new System.Drawing.Point(553, 705);
            this.btnPrintCustomerLedger.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintCustomerLedger.Name = "btnPrintCustomerLedger";
            this.btnPrintCustomerLedger.Size = new System.Drawing.Size(124, 47);
            this.btnPrintCustomerLedger.TabIndex = 51;
            this.btnPrintCustomerLedger.Text = "طباعة";
            this.btnPrintCustomerLedger.UseVisualStyleBackColor = false;
            // 
            // btnShowCustomerLedger
            // 
            this.btnShowCustomerLedger.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowCustomerLedger.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomerLedger.ForeColor = System.Drawing.Color.White;
            this.btnShowCustomerLedger.Location = new System.Drawing.Point(699, 705);
            this.btnShowCustomerLedger.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCustomerLedger.Name = "btnShowCustomerLedger";
            this.btnShowCustomerLedger.Size = new System.Drawing.Size(124, 47);
            this.btnShowCustomerLedger.TabIndex = 50;
            this.btnShowCustomerLedger.Text = "العرض";
            this.btnShowCustomerLedger.UseVisualStyleBackColor = false;
            this.btnShowCustomerLedger.Click += new System.EventHandler(this.btnShowCustomerLedger_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 639);
            this.dataGridView1.TabIndex = 49;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(1068, 752);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 1);
            this.textBox4.TabIndex = 87;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(995, 754);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 1);
            this.textBox3.TabIndex = 85;
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCredit.ForeColor = System.Drawing.Color.SlateGray;
            this.txtTotalCredit.Location = new System.Drawing.Point(989, 733);
            this.txtTotalCredit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.Size = new System.Drawing.Size(66, 20);
            this.txtTotalCredit.TabIndex = 80;
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDebit.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTotalDebit.Location = new System.Drawing.Point(1063, 732);
            this.txtTotalDebit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.Size = new System.Drawing.Size(66, 20);
            this.txtTotalDebit.TabIndex = 79;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(397, 705);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 47);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "الخروج";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRM_JournalEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 765);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtTotalCredit);
            this.Controls.Add(this.txtTotalDebit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPrintCustomerLedger);
            this.Controls.Add(this.btnShowCustomerLedger);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_JournalEntries";
            this.Text = "FRM_JournalEntries";
            this.Load += new System.EventHandler(this.FRM_JournalEntries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPrintCustomerLedger;
        private System.Windows.Forms.Button btnShowCustomerLedger;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtTotalDebit;
        private System.Windows.Forms.Button btnClose;
    }
}