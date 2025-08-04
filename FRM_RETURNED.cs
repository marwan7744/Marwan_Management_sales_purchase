using CrystalDecisions.CrystalReports.Engine;
//using DevExpress.XtraEditors.Controls;
using MANGEMENT.RPT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace MANGEMENT.PL
{
    public partial class FRM_RETURNED : Form
    {
        private BL.CLS_RETURNED_SALES returnManager = new BL.CLS_RETURNED_SALES();
        private int currentOrderId = 0;
        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";
        int orderId;
        // أضف هذا المتغير لتخزين رقم الفاتورة الحالي
        //  private int currentOrderId;
        public FRM_RETURNED()
        {
            InitializeComponent();
            SetupForm();
            GetAllORDERIDs();
            dataGridView.ForeColor = Color.Black;


        }
        private void GetAllORDERIDs()
        {
            //كود تحميل العملاء
            try
            {
                // تحميل العملاء
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID_ORDER FROM ORDERS", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CmdOrder.DataSource = dt;
                    CmdOrder.DisplayMember = "ID_ORDER";
                    CmdOrder.ValueMember = "ID_ORDER";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetupForm()
        {
            LoadCustomers();
            LoadProducts();
         
            ResetForm();
        }
        private void LoadCustomers()
        {
            // كود تحميل العملاء
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
        private void LoadProducts()
        {
            // تحميل المنتجات
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID_PRODUCT, LABEL_PRODUCT AS ProductName FROM PRODUCT", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbProduct.DataSource = dt;
                    cmbProduct.DisplayMember = "ID_PRODUCT";
                    cmbProduct.ValueMember = "ID_PRODUCT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CalculateAmount()
        {
            try
            {
                ////نسوي إجرا لكي يتم حساب الثمن و الكميه ليعطينا المبلغ
                //if (txtPrice.Text != string.Empty && txtQuantity.Text != string.Empty)
                //{

                //    txtPrice.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)).ToString();
                //}
                double Amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                txtAmount.Text = Amount.ToString();
            }
            catch
            {
                return;
            }

        }

        void CalculateTotelAmount()      //إجراء جديد يقوم بحساب المبلغ الاجمالي
        {
            //  تحقق من نسبة الخصم وتحولها إلى قيمة رقمية   
            if (txtDISCOUNT.Text != string.Empty && txtAmount.Text != string.Empty)
            {
                double Discount = Convert.ToDouble(txtDISCOUNT.Text);
                double Amount = Convert.ToDouble(txtAmount.Text);
                double TotalAmount = Amount - (Amount * (Discount / 100));
                txtTotalReturns.Text = TotalAmount.ToString();

            }
        }
        //private void SetupGrid()
        //{
        //    dataGridView.AutoGenerateColumns = false;
        //    dataGridView.Columns.Clear();

        //    // إضافة الأعمدة
        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "ReturnID",
        //        HeaderText = "رقم المرتجع"
        //    });
        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "ID_ORDER",
        //        HeaderText = "رقم الفاتورة",

        //    });
        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "ID_PRODUCT",
        //        HeaderText = "نوع المنتج",

        //    });
        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "ID_CUSTOMER",
        //        HeaderText = " إسم العميل",

        //    });
        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "ReturnQty",
        //        HeaderText = " الكمية المرتجعة",

        //    });
        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "PRICE",
        //        HeaderText = " المبلغ",

        //    });

        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "Amount",
        //        HeaderText = " الإجمالي",

        //    });

        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "DISCOUNT",
        //        HeaderText = " الخصم",

        //    });

        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "TotalAmount",
        //        HeaderText = " الإجمالي بعد الخصم",

        //    });

        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "ReturnReason",
        //        HeaderText = " سباب المرتجع",

        //    });
        //    dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
        //    {
        //        DataPropertyName = "ProcessedBy",
        //        HeaderText = "  الموظف المسوؤل",

        //    });
        //    // إضافة باقي الأعمدة بنفس الطريقة
        //}

        private void LoadSessionReturns(int orderId)
        {
            try
            {
                DataTable dt = returnManager.GET_SESSION_RETURNS(orderId);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل المرتجعات: " + ex.Message);
            }
        }
        private void ClearFormExceptOrderId()
        {
            CmdOrder.SelectedIndex = 0;
            cmbProduct.SelectedIndex = 0;
            cmbCustomer.SelectedIndex = 0;
            txtQuantity.Clear();
            txtPrice.Clear();
            txtReason.Clear();
            txtProcessedBy.Clear();
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(CmdOrder.Text) ||
                cmbProduct.SelectedIndex == -1 ||
                cmbCustomer.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                 string.IsNullOrWhiteSpace(txtAmount.Text) ||
                  string.IsNullOrWhiteSpace(txtTotalReturns.Text))
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول المطلوبة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(CmdOrder.Text, out _))
            {
                MessageBox.Show("رقم الطلب يجب أن يكون رقماً صحيحاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("الكمية يجب أن تكون رقماً صحيحاً موجباً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string priceText = txtPrice.Text.Replace(",", ".");
            if (!decimal.TryParse(priceText, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("السعر يجب أن يكون رقماً عشرياً صحيحاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string AmountText = txtAmount.Text.Replace(",", ".");
            if (!decimal.TryParse(priceText, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("المبلغ يجب أن يكون رقماً عشرياً صحيحاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string TotalAmountText = txtTotalReturns.Text.Replace(",", ".");
            if (!decimal.TryParse(priceText, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("الإجمالي يجب أن يكون رقماً عشرياً صحيحاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ClearForm()
        {
            CmdOrder.SelectedIndex=0;
            cmbProduct.SelectedIndex = 0;
            cmbCustomer.SelectedIndex = 0;
            txtQuantity.Clear();
            txtPrice.Clear();
            txtReason.Clear();
            txtProcessedBy.Clear();
        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.Contains('.') || (sender as TextBox).Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

       private void btnPrintReturn_Click(object sender, EventArgs e)
        {
            
            if (currentOrderId == 0)
            {
                MessageBox.Show("لا توجد فاتورة محددة للطباعة");
                return;
            }

            try
            {
                DataTable dt = returnManager.GET_SESSION_RETURNS(currentOrderId);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد مرتجعات للطباعة");
                    return;
                }

                // كود الطباعة باستخدام Crystal Reports
                PrintReturns(dt, currentOrderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الطباعة: " + ex.Message);
            }
        }
        private void PrintReturns(DataTable returnsData, int orderId)
        {
            try
            {
                // كود الطباعة الفعلي باستخدام التقرير
                RPT.RETURN_REPORT report = new RPT.RETURN_REPORT();
                report.SetDataSource(returnsData);

                FRM_RPT_PRODUCT viewer = new FRM_RPT_PRODUCT();
                viewer.crystalReportViewer1.ReportSource = report;
                viewer.Text = $"تقرير مرتجعات الفاتورة رقم {orderId}";
                viewer.ShowDialog();
            }catch(Exception ex) { 
            MessageBox.Show(ex.Message);
            }
        }

        private void ResetForm()
        {
            currentOrderId = 0;
       //     CmdOrder.SelectedIndex=0;

            ClearData();
            dataGridView.DataSource = null;
        }
        private void ClearData()
        {
            CmdOrder.SelectedIndex=-1;
            cmbProduct.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Clear();
            txtReason.Clear();
            txtProcessedBy.Clear();
            txtAmount.Clear();
            txtDISCOUNT.Clear();
        }
        private void btnAddReturn_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                currentOrderId = int.Parse(CmdOrder.Text);

                int returnId = returnManager.ADD_RETURN_SALES(
                    currentOrderId,
                    cmbProduct.SelectedValue.ToString(),
                    (int)cmbCustomer.SelectedValue,
                    int.Parse(txtQuantity.Text),
                    txtPrice.Text,
                    txtAmount.Text,
                    txtTotalReturns.Text,
                    txtReason.Text,
                    txtProcessedBy.Text,
                    txtDISCOUNT.Text);
                MessageBox.Show("تمت إضافة المرتجع بنجاح!");
                LoadSessionReturns(currentOrderId);
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        private void btnPrintSingle_Click_1(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtOrderId.Text))
            //{
            //    MessageBox.Show("الرجاء إدخال رقم الفاتورة أولاً");
            //    return;
            //}

                try
               {
          

            //طباعة كل الاصناف
            RPT.GET_ALL_RETURNS rpt = new RPT.GET_ALL_RETURNS();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.Refresh(); //لتحديث
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في الطباعة: {ex.Message}");
            }
        }

        private void FRM_RETURNED_Load(object sender, EventArgs e)
        {
            CmdOrder.Focus();
            CmdOrder.SelectAll();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //void CalculateTotelAmount()      //إجراء جديد يقوم بحساب المبلغ الاجمالي
        //{
        //    //  تحقق من نسبة الخصم وتحولها إلى قيمة رقمية   
        //    if (txtDISCOUNT.Text != string.Empty && txtPrice.Text != string.Empty)
        //    {
        //        double Discount = Convert.ToDouble(txtDISCOUNT.Text);
        //        double Amount = Convert.ToDouble(txtPrice.Text);
        //        double TotalAmount = Amount - (Amount * (Discount / 100));
        //    //    txtTotalAmount.Text = TotalAmount.ToString();
        //    }
        //}
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
            CalculateTotelAmount();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_RETURNED_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

            }
        }

        private void txtOrderId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCustomer.Focus();
            }
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbProduct.Focus();
            }
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuantity.Focus();
            }
          
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrice.Focus();
            }

        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    txtDISCOUNT.Focus();
            //}

            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)  // عندما نريد ادخال الثمن  
            {
                txtQuantity.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReason.Focus();
            }
        }

        private void txtReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProcessedBy.Focus();
            }
        }

        private void txtTotalReturns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)  // عندما نريد ادخال الثمن  
            {
                txtQuantity.Focus();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                txtPrice.Focus();
                e.Handled = true;
            }
        }

        private void txtDISCOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtOrderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                cmbCustomer.Focus();
                e.Handled = true;
            }
        }

        private void cmbCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                cmbProduct.Focus();
                e.Handled = true;
            }
        }

        private void cmbProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                txtQuantity.Focus();
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                txtDISCOUNT.Focus();
                e.Handled = true;
            }
        }

        private void txtProcessedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddReturn.Focus();
            }
        }

        private void FRM_RETURNED_Shown(object sender, EventArgs e)
        {
            CmdOrder.Focus();
        }

        private void CmdOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCustomer.Focus();
            }
        }

        private void CmdOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                cmbCustomer.Focus();
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
