using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.RPT
{
    public partial class FRM_REPORT_VIEWER : Form
    {
        public FRM_REPORT_VIEWER()
        {
            InitializeComponent();
        }
        public void ShowReport(ReportDocument reportDoc)
        {
            myReport.ReportSource = reportDoc;
            myReport.Refresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (myReport.ReportSource != null)
            {
                myReport.PrintReport();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport_Click(sender, e, myReport);
        }

        // حدث التصدير (اختياري)
        private void btnExport_Click(object sender, EventArgs e, CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1)
        {
           
            //ExportOptions export = new ExportOptions();

            ////create object for destinstion
            //DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            //PdfFormatOptions pdfformat = new PdfFormatOptions();  //تنسيق ملف بي دي اف
            //// set the path of destionation
            //dfoptions.DiskFileName = @"E:\CategoriesList.pdf";
            ////set the Report option to crystal export options
            //export = myReport.ExportOptions;
            ////set Destination type 
            //export.ExportDestinationType = ExportDestinationType.DiskFile;
            ////set the type of document
            //export.ExportFormatType = ExportFormatType.PortableDocFormat; //PortableDocFormat تعني PDF
            ////format the pdf document
            //export.ExportFormatOptions = pdfformat;
            ////set Destination option
            //export.ExportDestinationOptions = dfoptions;
            //// myReport.Refresh(); //تحديث
            ////Export
            //myReport.Export();
            //MessageBox.Show("List Exported Successfully !", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF|*.pdf";
            if (save.ShowDialog() == DialogResult.OK)
            {
               
                      
            }
        }
    }
}
       

  