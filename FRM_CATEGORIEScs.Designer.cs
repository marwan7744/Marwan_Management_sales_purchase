namespace MANGEMENT.PL
{
    partial class FRM_CATEGORIEScs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExportToPdfCurrent = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintCurrent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.exportToPdfAll = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgList);
            this.groupBox3.Location = new System.Drawing.Point(6, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 298);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لائحة الأصناف";
            // 
            // dgList
            // 
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(18, 21);
            this.dgList.Name = "dgList";
            this.dgList.RowHeadersWidth = 51;
            this.dgList.RowTemplate.Height = 26;
            this.dgList.Size = new System.Drawing.Size(477, 277);
            this.dgList.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::MANGEMENT.Properties.Resources.icons8_Back_50px;
            this.btnPrevious.Location = new System.Drawing.Point(761, 292);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 32);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_End_40px_1;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = global::MANGEMENT.Properties.Resources.icons8_End_48px;
            this.btnFirst.Location = new System.Drawing.Point(842, 292);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(68, 32);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Skip_to_Start_48px1;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = global::MANGEMENT.Properties.Resources.icons8_Skip_to_Start_48px2;
            this.btnLast.Location = new System.Drawing.Point(517, 292);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(56, 32);
            this.btnLast.TabIndex = 10;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::MANGEMENT.Properties.Resources.icons8_Forward_50px;
            this.btnNext.Location = new System.Drawing.Point(579, 292);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(687, 300);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(34, 19);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "7/6";
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(529, 108);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDes.Size = new System.Drawing.Size(318, 118);
            this.txtDes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(859, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "إسم المجموعة";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(673, 59);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(174, 27);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(865, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم المجموعة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExportToPdfCurrent);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnPrintAll);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnPrintCurrent);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.exportToPdfAll);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 137);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // ExportToPdfCurrent
            // 
            this.ExportToPdfCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToPdfCurrent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToPdfCurrent.Image = global::MANGEMENT.Properties.Resources.icons8_PDF_50px;
            this.ExportToPdfCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportToPdfCurrent.Location = new System.Drawing.Point(381, 78);
            this.ExportToPdfCurrent.Name = "ExportToPdfCurrent";
            this.ExportToPdfCurrent.Size = new System.Drawing.Size(302, 37);
            this.ExportToPdfCurrent.TabIndex = 14;
            this.ExportToPdfCurrent.Text = "حفظ الصنف الحالي بمنتجاته في ملف PDF";
            this.ExportToPdfCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportToPdfCurrent.UseVisualStyleBackColor = true;
            this.ExportToPdfCurrent.Click += new System.EventHandler(this.ExportToPdfCurrent_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::MANGEMENT.Properties.Resources.icons8_New_48px;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(853, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 37);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.Image = global::MANGEMENT.Properties.Resources.icons8_Print_48px;
            this.btnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintAll.Location = new System.Drawing.Point(268, 20);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(192, 37);
            this.btnPrintAll.TabIndex = 10;
            this.btnPrintAll.Text = "طباعة كل  الأصناف";
            this.btnPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Available_Updates_50px_2;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(475, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEdit.Size = new System.Drawing.Size(110, 37);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Add_List_48px;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(724, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::MANGEMENT.Properties.Resources.icons8_Trash_48px1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageKey = "(none)";
            this.btnDelete.Location = new System.Drawing.Point(605, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintCurrent
            // 
            this.btnPrintCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCurrent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCurrent.Image = global::MANGEMENT.Properties.Resources.icons8_Print_50px_1;
            this.btnPrintCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintCurrent.Location = new System.Drawing.Point(59, 21);
            this.btnPrintCurrent.Name = "btnPrintCurrent";
            this.btnPrintCurrent.Size = new System.Drawing.Size(186, 37);
            this.btnPrintCurrent.TabIndex = 12;
            this.btnPrintCurrent.Text = "طباعة الصنف الحالي";
            this.btnPrintCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCurrent.UseVisualStyleBackColor = true;
            this.btnPrintCurrent.Click += new System.EventHandler(this.btnPrintCurrent_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::MANGEMENT.Properties.Resources.icons8_Delete_48px;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(235, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "خروج";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // exportToPdfAll
            // 
            this.exportToPdfAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportToPdfAll.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToPdfAll.Image = global::MANGEMENT.Properties.Resources.icons8_PDF_48px;
            this.exportToPdfAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportToPdfAll.Location = new System.Drawing.Point(712, 78);
            this.exportToPdfAll.Name = "exportToPdfAll";
            this.exportToPdfAll.Size = new System.Drawing.Size(250, 37);
            this.exportToPdfAll.TabIndex = 13;
            this.exportToPdfAll.Text = "حفظ لائحة الأصناف في ملف PDF";
            this.exportToPdfAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportToPdfAll.UseVisualStyleBackColor = true;
            this.exportToPdfAll.Click += new System.EventHandler(this.exportToPdfAll_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(0, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1009, 59);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "إدارة المجموعة";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox5.Location = new System.Drawing.Point(0, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(12, 607);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox6.Location = new System.Drawing.Point(997, 50);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(12, 622);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox7.Location = new System.Drawing.Point(0, 640);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1009, 28);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            // 
            // FRM_CATEGORIEScs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 669);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CATEGORIEScs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الاصناف";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_CATEGORIEScs_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrintCurrent;
        private System.Windows.Forms.Button exportToPdfAll;
        private System.Windows.Forms.Button ExportToPdfCurrent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}