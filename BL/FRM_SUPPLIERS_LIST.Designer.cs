namespace MANGEMENT.BL
{
    partial class FRM_SUPPLIERS_LIST
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
            this.datSUPPLIER = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datSUPPLIER)).BeginInit();
            this.SuspendLayout();
            // 
            // datSUPPLIER
            // 
            this.datSUPPLIER.AllowUserToAddRows = false;
            this.datSUPPLIER.AllowUserToDeleteRows = false;
            this.datSUPPLIER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datSUPPLIER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datSUPPLIER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datSUPPLIER.Location = new System.Drawing.Point(0, 0);
            this.datSUPPLIER.Margin = new System.Windows.Forms.Padding(4);
            this.datSUPPLIER.Name = "datSUPPLIER";
            this.datSUPPLIER.ReadOnly = true;
            this.datSUPPLIER.RowHeadersWidth = 51;
            this.datSUPPLIER.RowTemplate.Height = 26;
            this.datSUPPLIER.Size = new System.Drawing.Size(1195, 686);
            this.datSUPPLIER.TabIndex = 1;
            this.datSUPPLIER.DoubleClick += new System.EventHandler(this.datSUPPLIER_DoubleClick);
            // 
            // FRM_SUPPLIERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 686);
            this.Controls.Add(this.datSUPPLIER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SUPPLIERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قائمة جميع العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.datSUPPLIER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView datSUPPLIER;
    }
}