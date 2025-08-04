using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
namespace MANGEMENT.PL
{
    public partial class FRM_PRODUCTScs : Form
    {
        private static FRM_PRODUCTScs frm;   //
        //يستخدم لتوصيل إلى الحدث  اويتم تنفيذة عند  إطلاق حدث معين   
        static void frm_FormClosed(object sender, FormClosedEventArgs e)   //دالة الهاند لار
        {
            frm = null; ///نول تهدم 

        } //handlar
        public static FRM_PRODUCTScs getMainForm //إسم معبر للفورم الرئيسي       دالة جيتر
        {
            get   //لانها تتبع جيتر
            {
                if (frm == null) //تحقق من حالة الاوبجيت وإذا كان مهدوم نقوم به نشاءهي من جديد 
                {
                    frm = new FRM_PRODUCTScs();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);  // FORMCLOSEDEVETHANDLER  هذا هو الدلجيت الذي ينفذ الحدث
                }
                return frm; // يعني قيد الاستخدام إذا لم تكن نوول نسوي ريتورن
            }
        }

        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();  //الإعلان عن كائن من كلاس برودوكت الموجوده في بزنيز سلاير
        public FRM_PRODUCTScs()
        {
            InitializeComponent();  //هي التي تقوم ببناء الفورم اساسن او وضع المكونات على الفورم//وتهيات عناصر الفورم
            dataGridView1.ForeColor = Color.Black;

            if (frm == null)     //FRM التحقق من القيمة 
                frm = this;  //إذن قيمته الفولرم الحالي

            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();   //dataGridViewإضهار البيانات في 
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void FRM_PRODUCTScs_Load(object sender, EventArgs e)
        {

            //  this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();  //يستقبل البيانات القادمه
            dt = prd.Search(txtSearch.Text);//البحث عن القيمه  في قائمة تكسبوكس
            this.dataGridView1.DataSource = dt;//إضهار النتيجه
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();  // // FRM_ADD_PRODUCT إضهار النافذة حق المنتوجات الجديدإسم الفورم
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // عرض رسالة الحذف 
                if (MessageBox.Show("هل تريد حذف المنتج", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();  //هنا الحذف تلقائي بدون الخروج وإعادة الدخول لتشوف  
                }
                else
                {
                    MessageBox.Show("تم إلغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Error"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();  //وتعديل عليها FRM_ADD_PRODUCT إضهار النافذة حق المنتجات إسم الفورم
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCUS.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = " : تحديث المنتج" + this. dataGridView1.CurrentRow.Cells[1].Value.ToString();//تغير النص حق الفورم بدل ان تكون إضافة منتوج جديد يصبح تحديث البيانات المنتج
            frm.btnOK.Text = "تحديث";//تغير زر الموفق إلى تحديث
            frm.state = "update";//سوف تتغير قيمة التحديث
            frm.txtRef.ReadOnly = true;// للقراءه فقط
           //اخذ الصوره وتحويلهاإلى بيانات وتكون من المصفوفه الثنائيه
            byte[] Img = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            // prd هو كائن من كلاس بروداكت
            MemoryStream ms = new MemoryStream(Img);  //تخزن الصورة في الذاكره
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
        } 
         catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
private void button4_Click(object sender, EventArgs e)
        {
            try { 
            //اكواد جلب الصوره
            FRM_PREVIEW frm = new FRM_PREVIEW();
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            //prd هو كائن من كلاس بروداكت 
            MemoryStream ms = new MemoryStream(image);  //تخزن الصورة في الذاكره
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            RPT.rpt1_prd_single myReport = new RPT.rpt1_prd_single(); //نسخة من rpt
            //هنا قمنا بارسال  الباروميتر بحيث يقوم بعرض منتوج واحد وهو المنتوج المحداد في  الداتاجريدفيو
            myReport.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //بعدها قمنا بانشاء نسخه من الفورم
            //من اجل  الوصول إلى كرستال ريبوت فيو وبعدها وضع الخاصيتها تعني المصدر واعطيناهو قيمة
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();// 
            myForm.crystalReportViewer1.ReportSource = myReport;

            myForm.ShowDialog();//عرض الفورم الذي يقوم بدور الذي يحتوي على الكرستاله والقيم ونسخه

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            //طباعة الكل
            RPT.rpt_all_product1 myReport = new RPT.rpt_all_product1();
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try { 
            //طباعة الكل
            RPT.rpt_all_product1 myReport = new RPT.rpt_all_product1(); //نسخ كائن من RPT
            //create export optoins
            ExportOptions export = new ExportOptions();
            //create object for destinstion
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            ExcelFormatOptions excelformat = new ExcelFormatOptions();  //تنسيق ملف الاكسيل
            // set the path of destionation
            dfoptions.DiskFileName = @"E:\ProductList.xls";
            export = myReport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = excelformat;
            export.ExportDestinationOptions = dfoptions;

            myReport.Export();

            MessageBox.Show("List Exported Successfully !", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FRM_PRODUCTScs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
    }
}