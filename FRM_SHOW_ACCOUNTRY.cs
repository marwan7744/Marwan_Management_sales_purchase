using CrystalDecisions.CrystalReports.Engine;
using MANGEMENT.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_SHOW_ACCOUNTRY : Form
    {
     private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";


        LedgerManager ledger = new LedgerManager();

        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        //كود تحميل العملاء
        private void LoadCustomers()
        {
          
            try
            {
                // تحميل العملاء
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID_CUSTOMER, FIRST_NAME + ' ' + LAST_NAME AS CustomerName FROM CUSTOMERS", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbCustomer.DataSource = dt;
                    cmbCustomer.DisplayMember = "CustomerName";
                    cmbCustomer.ValueMember = "ID_CUSTOMER";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        BL.LedgerManager orde = new BL.LedgerManager();
        public FRM_SHOW_ACCOUNTRY()
        {
            InitializeComponent();
            LoadCustomers();
        }
        // عرض كل الحركات للمستند
        private void btnShowCashLedger_Click(object sender, EventArgs e)
        {

            LedgerManager ledger = new LedgerManager(); //  الكلاس المناسب عندك
            DataTable dt = ledger.GetCashLedger();
            dataGridView1.DataSource = dt;
        }

        //طباعة كل الحركات للمستند 
        private void btnPrintCashledger_Click(object sender, EventArgs e)
        {

            LedgerManager ledger = new LedgerManager();
            DataTable dt = ledger.GetCashLedger();

            RPT.RPT_CashLedger rpt = new RPT.RPT_CashLedger(); // تأكد من اسم التقرير
            rpt.SetDataSource(dt);

            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT(); // أو أي فورم يحتوي على CrystalReportViewer
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

       

        //طباعة كل عميل لحالة الحركات 
        private void btnPrintCustomerLedger_Click(object sender, EventArgs e)
        {
        
            try
            {
                if (cmbCustomer.SelectedValue == null)
                {
                    MessageBox.Show("يرجى اختيار عميل أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                string customerName = cmbCustomer.Text;
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);

                var result = ledger.Get_CustomerLedger_Full(customerId, fromDate, toDate);

                // إزالة التكرارات بنفس الطريقة المستخدمة في العرض
                DataTable reportData = RemoveDuplicateDocuments(result.ledgerDetails);

                RPT.RPT_CustomerLedger_Full rpt = new RPT.RPT_CustomerLedger_Full();
                rpt.SetDataSource(reportData);

                rpt.SetParameterValue("CustomerID", customerId);
                rpt.SetParameterValue("CustomerName", customerName);
                rpt.SetParameterValue("DateFrom", fromDate);
                rpt.SetParameterValue("DateTo", toDate);

                using (RPT.FRM_RPT_PRODUCT reportForm = new RPT.FRM_RPT_PRODUCT())
                {
                    reportForm.crystalReportViewer1.ReportSource = rpt;
                    reportForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الطباعة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // دالة مساعدة لإزالة المستندات المكررة
        private DataTable RemoveDuplicateDocuments(DataTable sourceTable)
        {
            if (sourceTable == null) return null;

            // إنشاء نسخة من الجدول مع الأعمدة المطلوبة فقط
            DataTable distinctTable = sourceTable.DefaultView.ToTable(
                true,
                "التاريخ", "نوع_المستند", "الرقم", "المرجع", "البيان", "مدين", "دائن"
            );

            // طريقة بديلة أكثر دقة لإزالة التكرارات
            var distinctData = sourceTable.AsEnumerable()
                .GroupBy(row => new {
                    DocNumber = row.Field<int>("الرقم"),
                    DocType = row.Field<string>("نوع_المستند"),
                    Date = row.Field<DateTime>("التاريخ")
                })
                .Select(group => group.First())
                .CopyToDataTable();

            return distinctData;
        }

        private void btnShowCustomerLedger_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedValue == null)
                {
                    MessageBox.Show("يرجى اختيار العميل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // استدعاء الإجراء المخزن باستخدام التاريخين
                var result = ledger.Get_CustomerLedger_Full(
               Convert.ToInt32(cmbCustomer.SelectedValue),
               dtpFrom.Value.Date,
               dtpTo.Value.Date.AddDays(1).AddTicks(-1)
           );

                // تحقق من تكرار البيانات قبل العرض
                DataTable dtLedger = result.ledgerDetails;

                // هذه الخطوة تزيل التكرارات إن وجدت
               dtLedger = dtLedger.DefaultView.ToTable(true,
                     "التاريخ", "نوع_المستند", "الرقم", "المرجع", "البيان", "مدين", "دائن");

                dataGridView1.DataSource = dtLedger;

                // عرض المجاميع في مربع النصوص
                txtTotalDebit.Text = result.totals.Rows[0]["إجمالي_مدين"].ToString();
                txtTotalCredit.Text = result.totals.Rows[0]["إجمالي_دائن"].ToString();
                txtTotalBalance.Text = result.totals.Rows[0]["الرصيد_الحالي"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_SHOW_ACCOUNTRY_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }

        private void FRM_SHOW_ACCOUNTRY_MouseDown(object sender, MouseEventArgs e)
        {
        
            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            
        }
    }

        private void dtpFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpTo.Focus();
            }
        }

        private void dtpTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpTo.Focus();
            }
        }

        private void FRM_SHOW_ACCOUNTRY_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            DateTime toDate = DateTime.Now.Date;
            DateTime tomorrow = toDate.AddDays(1);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        
            int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            DateTime now = DateTime.Now;

            var result = new LedgerManager().Get_CustomerLedger_Full(
                customerId,
                now.Date,  // من بداية اليوم
                now        // حتى الآن
            );

            // عرض البيانات في DataGridView أو تقرير
            dataGridView1.DataSource = result.ledgerDetails;
        }
    
    }
}

//private void Form1_MouseUp(object sender, MouseEventArgs e)
//{
//    isDragging = false;
//}

