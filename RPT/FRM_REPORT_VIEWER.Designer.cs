namespace MANGEMENT.RPT
{
    partial class FRM_REPORT_VIEWER
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.myReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(679, 503);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 38);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "button1";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(554, 504);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 37);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "button1";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // myReport
            // 
            this.myReport.ActiveViewIndex = -1;
            this.myReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.myReport.Location = new System.Drawing.Point(12, 12);
            this.myReport.Name = "myReport";
            this.myReport.Size = new System.Drawing.Size(786, 485);
            this.myReport.TabIndex = 2;
            // 
            // FRM_REPORT_VIEWER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.myReport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Name = "FRM_REPORT_VIEWER";
            this.Text = "FRM_REPORT_VIEWER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer myReport;
    }
}