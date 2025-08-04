using DevExpress.XtraBars;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraPrinting.Shape.Native;
using MANGEMENT.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_INV_SUPP : Form
    {
        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";


        // private readonly InvoiceManager dbManager = new InvoiceManager();
        private DataTable cartItems = new DataTable();
        private decimal totalAmount = 0;
        InvoiceManager salesManager = new InvoiceManager();

        public FRM_INV_SUPP()
        {
            InitializeComponent();
            InitializeCart();
            LoadProduct();
            dgvCart.ForeColor = Color.Black;
            SetupUI();
            //IDataGridView();
            UpdateTotalAmount();
            CalculateTotal();
            GetAllSaleIDs();

        }

        private void SetupUI()
        {
            // إعداد الواجهة
            this.Text = "نظام البيع بالتجزئة";
            dtpSaleDate.Value = DateTime.Now;
            cmbPaymentMethod.Items.AddRange(new string[] { "نقدي", "بطاقة ائتمان", "تحويل بنكي" });
            cmbPaymentMethod.SelectedIndex = 0;
            txtQuantity.Text = "1";
        }

        private void InitializeCart()
        {
            cartItems.Columns.Add("ProductID", typeof(string));
            cartItems.Columns.Add("Quantity", typeof(int));
            cartItems.Columns.Add("UnitPrice", typeof(decimal));
            cartItems.Columns.Add("Total", typeof(decimal));
            dgvCart.DataSource = salesManager;
        }

        // دالة لتحميل المنتجات في ComboBox
        private void LoadProduct()
        {
            DataTable PRODUCT = salesManager.sp_GetAvailableProducts();
            // DataTable PRODUCT = invoiceManager.GETALLPRODUCT();
            cmbProducts.DisplayMember = "ID_PRODUCT"; // يعرض اسم المنتج
            cmbProducts.ValueMember = "LABEL_PRODUCT"; // القيمة هي ID_PRODUCT
            cmbProducts.DataSource = PRODUCT;

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

        }

        // تحديث الإجمالي
        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            }
            lblTotal.Text = totalAmount.ToString();
        }


        //  تهيئة أعمدة DataGridView
        //private void IDataGridView()
        //{
        //    dgvCart.Columns.Add("ID_PRODUCT", "معرف المنتج");
        //    dgvCart.Columns.Add("LABEL_PRODUCT", "اسم المنتج");
        //    dgvCart.Columns.Add("Quantity", "الكمية");
        //    dgvCart.Columns.Add("UnitPrice", "سعر الوحدة");
        // dgvCart.Columns.Add("TotalPrice", "الإجمالي");
        //}


        private void ResetForm()
        {
            cartItems.Rows.Clear();
            totalAmount = 0;
            lblTotal.Text = "0.00";
            cmbProducts.Focus();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProducts.SelectedValue == null || !int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
                {
                    MessageBox.Show("الرجاء اختيار منتج وإدخال كمية صحيحة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // int SaleID =Convert.ToInt32(txtinvo.Text);
                string productId = cmbProducts.SelectedValue.ToString();
                string productName = cmbProducts.Text;
                decimal price = decimal.Parse(textBoxUnitPrice.Text);   // decimal price = dbManager.GetProductPrice(productId); from database
                DateTime date = dtpSaleDate.Value;
                decimal lblTotal = qty * price;
                string PaymentMethod = cmbPaymentMethod.Text;
                // إضافة للسلة
                salesManager.sp_AddRetailSale(productId, productName, qty, price, lblTotal, PaymentMethod);
                UpdateTotal();
                txtQuantity.Text = "1";
                MessageBox.Show("تم الاضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvCart.DataSource = salesManager.Get_all_RetailSales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateTotal()
        {
            totalAmount = 0;
            foreach (DataRow row in cartItems.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Total"]);
            }
            lblTotal.Text = totalAmount.ToString("N2");
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cartItems.Rows)
            {
                total += Convert.ToDecimal(row["TotalPrice"]);
            }
            lblTotal.Text = total.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FRM_INV_SUPP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

            }
        }

        private void btnPrintINVOCE_Click(object sender, EventArgs e)
        {

            PrepareInvoicePrint(preview: false);

        }





        private void PrepareInvoicePrint(bool preview)
        {
            // جلب آخر فاتورة من قاعدة البيانات
            DataTable invoiceItems = salesManager.sp_GetLastSaleDetails(); // يجب أن تنشئ هذا الإجراء في قاعدة البيانات

            if (invoiceItems.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لآخر فاتورة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            // جلب رقم الفاتورة والتاريخ من أول صف
            int saleID = Convert.ToInt32(invoiceItems.Rows[0]["SaleID"]);
            DateTime saleDate = Convert.ToDateTime(invoiceItems.Rows[0]["SaleDate"]);

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 350, 600);

            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 9, FontStyle.Bold);
            Font normalFont = new Font("Arial", 9);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            decimal totalAmount = 0;

            printDoc.PrintPage += (s, ev) =>
            {
                float marginX = 10;
                float currentY = 20;
                float lineHeight = normalFont.GetHeight() + 4;
                float[] columnWidths = { 40,50, 70, 40, 50, 60 };
                string[] headers = { "المنتج","إسم", "التاريخ", "الكمية", "السعر", "الإجمالي" };

                // رأس الفاتورة
                ev.Graphics.DrawString("مركز العالمي - فاتورة بيع", titleFont, Brushes.Black, marginX + 30, currentY);
                currentY += lineHeight * 2;

                ev.Graphics.DrawString($"رقم الفاتورة: {saleID}", normalFont, Brushes.Black, marginX, currentY);
                currentY += lineHeight;

                ev.Graphics.DrawString($"التاريخ: {saleDate:yyyy/MM/dd HH:mm}", normalFont, Brushes.Black, marginX, currentY);
                currentY += lineHeight * 2;

                // رؤوس الأعمدة
                float colX = marginX;
                for (int i = 0; i < headers.Length; i++)
                {
                    ev.Graphics.DrawString(headers[i], headerFont, Brushes.Black, colX, currentY);
                    colX += columnWidths[i];
                }

                currentY += lineHeight;
                ev.Graphics.DrawLine(Pens.Black, marginX, currentY, marginX + columnWidths.Sum(), currentY);
                currentY += 4;

                // تفاصيل المنتجات
                foreach (DataRow row in invoiceItems.Rows)
                {
                    float col = marginX;

                    string id = row["ID_PRODUCT"].ToString();
                    string name = row["LABEL_PRODUCT"].ToString();
                    string date = Convert.ToDateTime(row["SaleDate"]).ToString("yyyy/MM/dd");
                    string qty = Convert.ToInt32(row["Quantity"]).ToString(); // الكمية عدد صحيح
                    string price = Convert.ToDecimal(row["UnitPrice"]).ToString("N2");
                    decimal total = Convert.ToDecimal(row["TotalAmount"]);
                    string totalStr = total.ToString("N2");

                    totalAmount += total;

                    ev.Graphics.DrawString(id, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[0], lineHeight));
                    col += columnWidths[0];

                    ev.Graphics.DrawString(name, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[1], lineHeight));
                    col += columnWidths[1];

                    ev.Graphics.DrawString(date, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[2], lineHeight));
                    col += columnWidths[2];

                    ev.Graphics.DrawString(qty, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[3], lineHeight));
                    col += columnWidths[3];

                    ev.Graphics.DrawString(price, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[4], lineHeight));
                    col += columnWidths[4];

                    ev.Graphics.DrawString(totalStr, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[5], lineHeight));
                    currentY += lineHeight;
                }

                currentY += 4;
                ev.Graphics.DrawLine(Pens.Black, marginX, currentY, marginX + columnWidths.Sum(), currentY);
                currentY += lineHeight;

                // الإجمالي
                string totalText = $"الإجمالي: {totalAmount:N2}";
                ev.Graphics.DrawString(totalText, boldFont, Brushes.Black,
                    marginX + columnWidths.Sum() - ev.Graphics.MeasureString(totalText, boldFont).Width, currentY);
                currentY += lineHeight * 2;

                // طريقة الدفع (اختياري إذا كانت محفوظة)
                string paymentMethod = invoiceItems.Rows[0]["PaymentMethod"].ToString(); // تأكد من وجود هذا العمود في الإجراء
                ev.Graphics.DrawString($"طريقة الدفع: {paymentMethod}", normalFont, Brushes.Black, marginX, currentY);
                currentY += lineHeight;

                // التذييل
                string footer = "شكراً لتعاملكم معنا - هاتف: 774431711";
                ev.Graphics.DrawString(footer, headerFont, Brushes.Green,
                    marginX + (columnWidths.Sum() - ev.Graphics.MeasureString(footer, headerFont).Width) / 2, currentY);
            };

            if (preview)
            {
                new PrintPreviewDialog
                {
                    Document = printDoc,
                    Width = 800,
                    Height = 600
                }.ShowDialog();
            }
            else
            {
                PrintDialog printDialog = new PrintDialog { Document = printDoc };
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDoc.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطأ في الطباعة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void PrepareInvoicePrint(DataTable invoiceItems, bool preview)
        {
            if (invoiceItems.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لطباعتها", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int saleID = Convert.ToInt32(invoiceItems.Rows[0]["SaleID"]);
            DateTime saleDate = Convert.ToDateTime(invoiceItems.Rows[0]["SaleDate"]);

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 350, 600);

            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 9, FontStyle.Bold);
            Font normalFont = new Font("Arial", 9);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            decimal totalAmount = 0;

            printDoc.PrintPage += (s, ev) =>
            {
                float marginX = 10;
                float currentY = 20;
                float lineHeight = normalFont.GetHeight() + 4;
                float[] columnWidths = { 40, 60, 70, 40, 50, 60 };
                string[] headers = { "المنتج", "الاسم", "التاريخ", "الكمية", "السعر", "الإجمالي" };

                // رأس الفاتورة
                ev.Graphics.DrawString("مركز العالمي - فاتورة بيع", titleFont, Brushes.Black, marginX + 30, currentY);
                currentY += lineHeight * 2;

                ev.Graphics.DrawString($"رقم الفاتورة: {saleID}", normalFont, Brushes.Black, marginX, currentY);
                currentY += lineHeight;

                ev.Graphics.DrawString($"التاريخ: {saleDate:yyyy/MM/dd HH:mm}", normalFont, Brushes.Black, marginX, currentY);
                currentY += lineHeight * 2;

                // رؤوس الأعمدة
                float colX = marginX;
                for (int i = 0; i < headers.Length; i++)
                {
                    ev.Graphics.DrawString(headers[i], headerFont, Brushes.Black, colX, currentY);
                    colX += columnWidths[i];
                }

                currentY += lineHeight;
                ev.Graphics.DrawLine(Pens.Black, marginX, currentY, marginX + columnWidths.Sum(), currentY);
                currentY += 4;

                // تفاصيل المنتجات
                foreach (DataRow row in invoiceItems.Rows)
                {
                    float col = marginX;

                    string id = row["ID_PRODUCT"].ToString();
                    string name = row["LABEL_PRODUCT"].ToString();
                    string date = Convert.ToDateTime(row["SaleDate"]).ToString("yyyy/MM/dd");
                    string qty = Convert.ToInt32(row["Quantity"]).ToString(); // الكمية عدد صحيح
                    string price = Convert.ToDecimal(row["UnitPrice"]).ToString("N2");
                    decimal total = Convert.ToDecimal(row["TotalAmount"]);
                    string totalStr = total.ToString("N2");

                    totalAmount += total;

                    ev.Graphics.DrawString(id, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[0], lineHeight));
                    col += columnWidths[0];

                    ev.Graphics.DrawString(name, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[1], lineHeight));
                    col += columnWidths[1];

                    ev.Graphics.DrawString(date, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[2], lineHeight));
                    col += columnWidths[2];

                    ev.Graphics.DrawString(qty, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[3], lineHeight));
                    col += columnWidths[3];

                    ev.Graphics.DrawString(price, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[4], lineHeight));
                    col += columnWidths[4];

                    ev.Graphics.DrawString(totalStr, normalFont, Brushes.Black, new RectangleF(col, currentY, columnWidths[5], lineHeight));
                    currentY += lineHeight;
                }

                currentY += 4;
                ev.Graphics.DrawLine(Pens.Black, marginX, currentY, marginX + columnWidths.Sum(), currentY);
                currentY += lineHeight;

                // الإجمالي
                string totalText = $"الإجمالي: {totalAmount:N2}";
                ev.Graphics.DrawString(totalText, boldFont, Brushes.Black,
                    marginX + columnWidths.Sum() - ev.Graphics.MeasureString(totalText, boldFont).Width, currentY);
                currentY += lineHeight * 2;

                // طريقة الدفع
                if (invoiceItems.Columns.Contains("PaymentMethod"))
                {
                    string paymentMethod = invoiceItems.Rows[0]["PaymentMethod"].ToString();
                    ev.Graphics.DrawString($"طريقة الدفع: {paymentMethod}", normalFont, Brushes.Black, marginX, currentY);
                    currentY += lineHeight;
                }

                // التذييل
                string footer = "شكراً لتعاملكم معنا - هاتف: 774431711";
                ev.Graphics.DrawString(footer, headerFont, Brushes.Black,
                    marginX + (columnWidths.Sum() - ev.Graphics.MeasureString(footer, headerFont).Width) / 2, currentY);
            };

            if (preview)
            {
                new PrintPreviewDialog
                {
                    Document = printDoc,
                    Width = 800,
                    Height = 600
                }.ShowDialog();
            }
            else
            {
                PrintDialog printDialog = new PrintDialog { Document = printDoc };
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDoc.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطأ في الطباعة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void GetAllSaleIDs()
        {
            //كود تحميل العملاء
            try
            {
                // تحميل العملاء
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT SaleID FROM RetailSales", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    comboBoxInvoices.DataSource = dt;
                    comboBoxInvoices.DisplayMember = "SaleID";
                    comboBoxInvoices.ValueMember = "SaleID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void FillInvoiceComboBox()
        //{
        //    DataTable dt = ; // تنشئ هذا الميثود في كلاس SalesManager
        //    comboBoxInvoices.DataSource = dt;
        //    comboBoxInvoices.DisplayMember = "SaleID";
        //    comboBoxInvoices.ValueMember = "SaleID";
        //}
        private void cmbProducts_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    txtQuantity.Focus();
            //}
        }





        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    textBoxUnitPrice.Focus();
            //}
        }

        private void textBoxUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    cmbPaymentMethod.Focus();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd__Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbProducts.SelectedValue == null || !int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
                {
                    MessageBox.Show("الرجاء اختيار منتج وإدخال كمية صحيحة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               //  int SaleID =Convert.ToInt32(txtinvo.Text);
                string productId = cmbProducts.SelectedValue.ToString();
                string productName = cmbProducts.Text;
                decimal price = decimal.Parse(textBoxUnitPrice.Text);   // decimal price = dbManager.GetProductPrice(productId); from database
                DateTime date = dtpSaleDate.Value;
                decimal lblTotal = qty * price;
                string PaymentMethod = cmbPaymentMethod.Text;
                // إضافة للسلة
                salesManager.sp_AddRetailSale(productId, productName, qty, price, lblTotal, PaymentMethod);
                UpdateTotal();
                txtQuantity.Text = "1";
                MessageBox.Show("تم الاضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvCart.DataSource = salesManager.GetDailySalesReport(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareInvoicePrint(preview: true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrintI_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(comboBoxInvoices.Text, out int saleID))
                {
                    MessageBox.Show("الرجاء إدخال رقم فاتورة صالح");
                    return;
                }

                DataTable invoiceItems = salesManager.sp_GetLastSaleDetails();

                if (invoiceItems.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد بيانات لهذه الفاتورة");
                    return;
                }

                PrepareInvoicePrint(invoiceItems, preview: false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cmbProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                txtQuantity.Focus();
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                textBoxUnitPrice.Focus();
                e.Handled = true;
            }
        }

        private void textBoxUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                cmbPaymentMethod.Focus();
                e.Handled = true;
            }
        }

        private void cmbPaymentMethod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbPaymentMethod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_.Focus();
            }
        }
    }
    }
