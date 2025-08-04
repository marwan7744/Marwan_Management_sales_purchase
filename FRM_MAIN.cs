using MANGEMENT.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_MAIN : Form
    {
        //single Instance 
        private static FRM_MAIN frm;        //فليد  
        static void frm_FormClosed(object sender, FormClosedEventArgs e)   //دالة الهاند لار
        {
            frm = null; ///نول تهدم 
        }
        public static FRM_MAIN getMainForm //إسم معبر للفورم الريسي       دالة جيتر
        {
            get   //لانها تتبع جيتر
            {
                if (frm == null)                                                                                         //تحقق من حالة الاوبجيت وإذا كان مهدوم نقوم به نشاءهي من جديد 
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);  // FORMCLOSEDEVETHANDLER  هذا هو الدلجيت الذي ينفذ الحدث
                }
                return frm; // يعني قيد الاستخدام إذا لم تكن نوول نسوي ريتورن
            }
        }
        public FRM_MAIN()
        {
            InitializeComponent();  //هي التي تقوم ببناء الفورم اساسن او وضع المكونات على الفورم//وتهيات عناصر الفورم
            if (frm == null)     //FRM التحقق من القيمة 
                frm = this;  //إذن قيمته الفولرم الحالي 
            this.المنتوجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.الستخدمونToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = false;
            this.إستعادةنسخةالإحتياطيةToolStripMenuItem.Enabled = false;

        }
        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();    //  عملها لكي يضهر الفورم حق الدخول فوق الفورم الرئيسي يعني يضهر بحيث لا استطيع اضغط على ما خلف الفورم يضهر مدل showDialog
                                 //وكذلك التحكم باالعناصر  الخلفيه
        }
        private void إضافةمنتوججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void إدارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTScs frm = new FRM_PRODUCTScs();
            frm.ShowDialog();

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void إدارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIEScs frm = new FRM_CATEGORIEScs();
            frm.ShowDialog();
        }

        private void تسجلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.ShowDialog();
        }

        private void إصافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.ShowDialog();
        }

        private void المنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إصافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();

        }

        private void إدارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST frm = new FRM_ORDER_LIST();
            frm.ShowDialog();
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.ShowDialog();

        }

        private void إدارةالستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER_LIST frm = new FRM_USER_LIST();
            frm.ShowDialog();

        }

        private void إنشاءنسخةإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void إستعادةنسخةالإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTOR frm = new FRM_RESTOR();
            frm.ShowDialog();

        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إعداداتالأتصالالالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG frm = new FRM_CONFIG();
            frm.ShowDialog();
        }

        private void قائمةجميعالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
            frm.ShowDialog();
        }

        private void دليلالحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void الموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers fr = new Suppliers();
            fr.ShowDialog();
        }

        private void ديونالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SupplierDebt frm = new frm_SupplierDebt();
            frm.ShowDialog();
        }

        private void ديونالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers frm=new Suppliers();
            frm.ShowDialog();
        }

        private void كشفسجلالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCustomerStatement frm = new frmCustomerStatement();
            //frm.ShowDialog();
        }

        private void إدخالديونالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Debt frm=new frm_Add_Debt();
            frm.ShowDialog();
        }

        private void الدفعالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_customer_pym frm= new frm_customer_pym();
            frm.ShowDialog();
        }
    }
}
