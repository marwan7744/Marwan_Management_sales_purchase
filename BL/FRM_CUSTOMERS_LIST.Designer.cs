namespace MANGEMENT.BL
{
    partial class FRM_CUSTOMERS_LIST
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
            this.datCUSTOMER = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datCUSTOMER)).BeginInit();
            this.SuspendLayout();
            // 
            // datCUSTOMER
            // 
            this.datCUSTOMER.AllowUserToAddRows = false;
            this.datCUSTOMER.AllowUserToDeleteRows = false;
            this.datCUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datCUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datCUSTOMER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datCUSTOMER.Location = new System.Drawing.Point(0, 0);
            this.datCUSTOMER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datCUSTOMER.Name = "datCUSTOMER";
            this.datCUSTOMER.ReadOnly = true;
            this.datCUSTOMER.RowHeadersWidth = 51;
            this.datCUSTOMER.RowTemplate.Height = 26;
            this.datCUSTOMER.Size = new System.Drawing.Size(1196, 686);
            this.datCUSTOMER.TabIndex = 0;
            this.datCUSTOMER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datCUSTOMER_CellContentClick);
            this.datCUSTOMER.DoubleClick += new System.EventHandler(this.datCUSTOMER_DoubleClick);
            // 
            // FRM_CUSTOMERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 686);
            this.Controls.Add(this.datCUSTOMER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUSTOMERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لائحة جميع العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.datCUSTOMER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView datCUSTOMER;
    }
}