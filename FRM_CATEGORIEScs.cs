using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace MANGEMENT.PL
{
    public partial class FRM_CATEGORIEScs : Form
    {
         SqlConnection sqlcon =new SqlConnection(@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;  // دورها يقوم با إدارة الادوات المرتبطه مع البيانات المرتبطه با قاعدة البيانات
                                 // CurrencyManager cm;//نفس العمل
        SqlCommandBuilder cmdb;   //للاضافه والحذف والتعديل
        public FRM_CATEGORIEScs()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select id_cus as 'المعرف',DESCRIPTION_CUS as'الصنف' from categories", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "المعرف");
            txtDes.DataBindings.Add("text", dt, "الصنف");
            bmb = this.BindingContext[dt];//bmb=this تسمى الفورم الحالي
            lblPosition.Text = (bmb.Position+1 + " / " + bmb.Count);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.AddNew(); //AddNew() تعني التفريغ ويدخل بينات جديده
                btnNew.Enabled =false;
                btnAdd.Enabled =true;
                int id = Convert.ToInt32(dt.Rows[dt.Rows.Count- 1][0])+1;
                txtID.Text = id.ToString();
                txtDes.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();  //هذه العمليه سوف نستخدمها للاضافه والحذف والتعديل

                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تم الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAdd.Enabled = false;//يتم الغاء زر الاضافة 
                btnNew.Enabled = true; //و يفعل الجديد
                lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count); // يجب إضهار البوزشين لكي يتم تحديد العنصر ورتبت العناصر عند كل عمليت إضافه او حذف
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.RemoveAt(bmb.Position);  //للحذف

                bmb.EndCurrentEdit();  //هذه العمليه سوف نستخدمها للاضافه والحذف والتعديل

                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            //طباعة كل الاصناف
            RPT.rpt_All_categories rpt = new RPT.rpt_All_categories();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.Refresh(); //لتحديث
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();  //هذه العمليه سوف نستخدمها للاضافه والحذف والتعديل

                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تم التحديث", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportToPdfAll_Click(object sender, EventArgs e)
        {

            RPT.rpt_All_categories myReport = new RPT.rpt_All_categories(); //نسخ كائن من RPT
            //create export optoins
            ExportOptions export = new ExportOptions();

            //create object for destinstion
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

           PdfFormatOptions pdfformat = new PdfFormatOptions();  //تنسيق ملف بي دي اف
            // set the path of destionation
            dfoptions.DiskFileName = @"E:\CategoriesList.pdf";
            //set the Report option to crystal export options
            export = myReport.ExportOptions;
            //set Destination type 
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            //set the type of document
            export.ExportFormatType = ExportFormatType.PortableDocFormat; //PortableDocFormat تعني PDF
            //format the pdf document
            export.ExportFormatOptions = pdfformat;
            //set Destination option
            export.ExportDestinationOptions = dfoptions;
           // myReport.Refresh(); //تحديث
            //Export
            myReport.Export();
            MessageBox.Show("List Exported Successfully !", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
        private void ExportToPdfCurrent_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_category myReport = new RPT.rpt_single_category(); //نسخ كائن من RPT
            //create export options
            ExportOptions export = new ExportOptions();

            //create object for destinstion
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            PdfFormatOptions pdfformat = new PdfFormatOptions();  //تنسيق ملف بي دي اف
            // set the path of destionation
            dfoptions.DiskFileName = @"E:\CategoriesList.pdf";
            //set the Report option to crystal export options
            export = myReport.ExportOptions;
            //set Destination type 
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            //set the type of document
            export.ExportFormatType = ExportFormatType.PortableDocFormat; //PortableDocFormat تعني PDF
            //format the pdf document
            export.ExportFormatOptions = pdfformat;
            //set Destination option
            export.ExportDestinationOptions = dfoptions;
            // myReport.Refresh(); //تحديث
            //Export
            myReport.Export();
            MessageBox.Show("List Exported Successfully !", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnPrintCurrent_Click(object sender, EventArgs e)
        {
            //طباعة الصنف الحالي 
            RPT.rpt_single_category rpt = new RPT.rpt_single_category();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.SetParameterValue("@id", Convert.ToInt32(txtID.Text)); //يقوم بتحويل القيمه النصيه إلى قيمه رقميه
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
        private void FRM_CATEGORIEScs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

            }
        }
    }
}
