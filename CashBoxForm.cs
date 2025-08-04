using CrystalDecisions.CrystalReports.Engine;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraSplashScreen;
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
    public partial class CashBoxForm : Form
    {

        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";

      //  CashBox cashBoxData = new CashBox();
        //  BL.CLS_ORDERS cashBoxManager = new BL.CLS_ORDERS();

       private CashBox cashBoxData = new CashBox();

        private DataTable originalData;


        private void LoadCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_CUSTOMER, FIRST_NAME FROM CUSTOMERS";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmbCustomer.DataSource = dataTable;
                cmbCustomer.DisplayMember = "FIRST_NAME"; // يعرض اسم العميل
                cmbCustomer.ValueMember = "ID_CUSTOMER";   // القيمة الفعلية هي CustomerID
            }
        }


        private void ClearData()
        {
            txtTotalSales.Clear();
      
            txtTotalReceipts.Clear();
        
            txtTotalRevenue.Clear();
          
            txtTotalRetailSales.Clear();
        }

        //private void rdoCustomer_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdoCustomer.Checked)
        //    {
        //        cmbCustomer.Enabled = true;
        //        cmbSupplier.Enabled = false;
        //        cmbSupplier.SelectedIndex = -1; // مسح اختيار المورد
        //    }
        //}

       
        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
          
         
        }

        public CashBoxForm()
        {

            InitializeComponent();
            // this.dgvCashBox.DataSource = cashBoxData.SearchOrders("");   // البحث عن فاتورة البيعات
            LoadCustomers();
        
       //     ShowMovementTotals(); 

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //  this.dgvCashBox.DataSource = cashBoxData.SearchOrders(txtSearch.Text);
            }
            catch
            {
                return;
            }
        }

      //  طباعة فاتورة البيعات
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                RPT.Report_CashBox rpt = new RPT.Report_CashBox();
                rpt.Load("RPT_CashBox.rpt");

                int? customerId = null;
                string filterType = "ALL";
                if (rdoCustomer.Checked)
                {
                    customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                    filterType = "CUSTOMER";
                }

                else if (rdoRevenue.Checked)
                {
                    filterType = "CUSTOMERS";
                }

                else if (rdoRetailSales.Checked)
                {
                    filterType = "SALES";
                }
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                rpt.SetParameterValue("@CustomerID", (object)customerId ?? DBNull.Value);    
                rpt.SetParameterValue("@DateFrom", fromDate);
                rpt.SetParameterValue("@DateTo", toDate);
                rpt.SetParameterValue("@FilterType", filterType);
                RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الطباعة: " + ex.Message);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {     
            try
            {
                int? customerId = null;
               
                string filterType = "ALL";

                if (rdoCustomer.Checked)
                {
                    if (cmbCustomer.SelectedValue == null)
                    {
                        MessageBox.Show("يرجى اختيار العميل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                    filterType = "CUSTOMER";
                }
                else if (rdoAll.Checked)
                {
                    filterType = "ALL";
                }
                else if (rdoRevenue.Checked)
                {
                    filterType = "CUSTOMERS";
                }
                

              else if (rdoRetailSales.Checked)
                {
                  filterType = "SALES";
               }
                else
                {
                    MessageBox.Show("يرجى اختيار نوع الحركة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
           
                // استدعاء البيانات من الكلاس المعدل
                var ds = cashBoxData.Get_CashBox(customerId,fromDate, toDate, filterType);
                
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    originalData = ds.Tables[0];
                    dgvCashBox.DataSource = originalData;

                    // تعبئة أنواع المستندات في الكمبوبوكس
                    cmbDocType.Items.Clear();
                    cmbDocType.Items.Add("عرض الكل");

                    var types = originalData.AsEnumerable()
                        .Select(r => r.Field<string>("نوع_المستند"))
                        .Distinct()
                        .OrderBy(t => t)
                        .ToList();

                    foreach (var type in types)
                        cmbDocType.Items.Add(type);

                    cmbDocType.SelectedIndex = 0;

                    // تعبئة الإجماليات
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[1].Rows[0];

                        decimal totalDebit = row.IsNull("مدين_إجمالي") ? 0 : Convert.ToDecimal(row["مدين_إجمالي"]);
                        decimal totalCredit = row.IsNull("دائن_إجمالي") ? 0 : Convert.ToDecimal(row["دائن_إجمالي"]);
                        decimal balance = totalDebit - totalCredit;

                        lblTotal.Text = $"مدين: {totalDebit:N2} | دائن: {totalCredit:N2} | الرصيد: {balance:N2}";
                    }
                    else
                    {
                        lblTotal.Text = "";
                    }

                    ShowMovementTotals(); // حساب الإجماليات لكل نوع
                }
                else
                {
                    dgvCashBox.DataSource = null;
                    lblTotal.Text = "";
                    MessageBox.Show("قم بتحديد التاريخ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }
        private void cmbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (originalData == null || originalData.Rows.Count == 0)
                return;

            string selected = cmbDocType.SelectedItem?.ToString();

            if (selected == "عرض الكل" || string.IsNullOrWhiteSpace(selected))
            {
                dgvCashBox.DataSource = originalData;
                ShowMovementTotals(); // إجماليات لكل الأنواع
            }
            else
            {
                DataView dv = new DataView(originalData);
                dv.RowFilter = $"[نوع_المستند] = '{selected.Replace("'", "''")}'";
                dgvCashBox.DataSource = dv;

                // عرض الإجمالي للحركة المختارة فقط
                ShowMovementTotals(selected);
            }
        }
       
        private void ShowMovementTotals(string filterType = null)
        {
            // تصفية البيانات حسب نوع الحركة إذا تم تمرير نوع
            var rows = originalData.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(filterType))
            {
                rows = rows.Where(r => r.Field<string>("نوع_المستند") == filterType);
            }
            // حساب الإجماليات
            decimal totalDebit = rows.Sum(r => cashBoxData.TryParseDecimal(r["مدين"]));
            decimal totalCredit = rows.Sum(r => cashBoxData.TryParseDecimal(r["دائن"]));
            decimal balance = totalDebit - totalCredit;

            // تعبئة TextBoxes حسب نوع الحركة
            ClearData();

            if (!string.IsNullOrWhiteSpace(filterType))
            {
                decimal netTotal = totalDebit - totalCredit;

                switch (filterType)
                {
                    case "فاتورة مبيعات":
                        txtTotalSales.Text = netTotal.ToString("N2");
                        break;
                    case "سند قبض":
                        txtTotalReceipts.Text = netTotal.ToString("N2");
                        break;
                   
                    case "إيراد":
                        txtTotalRevenue.Text = totalCredit.ToString("N2");
                        break;

                    case "بيع بالتجزئة":
                        txtTotalRetailSales.Text = netTotal.ToString("N2");
                        break;
                }
            }
            else
            {
                // في حالة عرض الكل، نحسب إجمالي كل نوع على حدة
                txtTotalSales.Text         = GetTotalByType("فاتورة مبيعات").ToString("N2");
                txtTotalReceipts.Text      = GetTotalByType("سند قبض").ToString("N2");
                txtTotalRevenue.Text     = GetTotalByType("إيراد").ToString("N2");
                txtTotalRetailSales.Text   = GetTotalByType("بيع بالتجزئة").ToString("N2");

            }
        }

        private decimal GetTotalByType(string type)
        {
            var rows = originalData.AsEnumerable()
                .Where(r => r.Field<string>("نوع_المستند") == type);

            decimal totalDebit = rows.Sum(r => cashBoxData.TryParseDecimal(r["مدين"]));
            decimal totalCredit = rows.Sum(r => cashBoxData.TryParseDecimal(r["دائن"]));

            return totalDebit - totalCredit;
        }


        private string GetTotal(DataTable data, string docType, string column)
        {
            var filtered = data.AsEnumerable()
                .Where(r => r.Field<string>("نوع_المستند") == docType);

            decimal total = filtered.Sum(r => Convert.ToDecimal(r[column]));
            return total.ToString("N2");
        }
       
        private void txtTotalPayments_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                RPT.Report_CashBox rpt = new RPT.Report_CashBox();
                rpt.Load("Report_CashBox.rpt");

                int? customerId = null;
                string filterType = "ALL";
                string PaymentType = "نقد";
                if (rdoCustomer.Checked)
                {
                    customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                    filterType = "CUSTOMER";
                }
                else if (rdoRevenue.Checked)
                {
                    filterType = "CUSTOMERS";
                }

                else if (rdoRetailSales.Checked)
                {
                    filterType = "SALES";
                }
              
                    DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                rpt.SetParameterValue("@CustomerID", (object)customerId ?? DBNull.Value);
                rpt.SetParameterValue("@DateFrom", fromDate);
                rpt.SetParameterValue("@DateTo", toDate);
                rpt.SetParameterValue("@FilterType", filterType);
               // rpt.SetParameterValue("@PaymentType", PaymentType);
                RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.crystalReportViewer1.Refresh();
            frm.ShowDialog();
        }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء الطباعة: " + ex.Message);
            }
}

        private void CashBoxForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
        }

        private void txtTotalSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalReturns_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPurchases_TextChanged(object sender, EventArgs e)
        {

        }

        private void CashBoxForm_MouseDown(object sender, MouseEventArgs e)
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