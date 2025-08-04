using CrystalDecisions.CrystalReports.Engine;
using MANGEMENT.BL;
using MANGEMENT.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_ORDERS : Form
    {
        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";

        private DataTable Dt = new DataTable(); // جدول بيانات تفاصيل الفاتورة
        private BL.CLS_ORDERS order = new BL.CLS_ORDERS(); // كائن إدارة الفواتير
        private void LoadCustomerData(int ID_CUSTOMER,
            string FIRST_NAME, string LAST_NAME, string TEL, string EMAI)
        {
            //  ID_CUSTOMER, FIRST_NAME, LAST_NAME, TEL, EMAI
            DataTable customerData = order.GetAllCustomers();
            if (customerData.Rows.Count > 0)
            {
                txtFirstName.Text = customerData.Rows[0]["FIRST_NAME"].ToString();
                txtLastName.Text = customerData.Rows[0]["LAST_NAME"].ToString();
                txtTel.Text = customerData.Rows[0]["TEL"].ToString();
                txtEmail.Text = customerData.Rows[0]["EMAI"].ToString();
                // تحميل الصورة إذا وجدت
                //if (customerData.Rows[0]["PICTURE"] != DBNull.Value)
                //{
                //    byte[] imageData = (byte[])customerData.Rows[0]["PICTURE"];
                //    using (MemoryStream ms = new MemoryStream(imageData))
                //    {
                //        pbox.Image = Image.FromStream(ms);
                //    }
                //}
            }
        }
        /// ////////////////////////////
        void CalculateAmount()
        {
            try
            {
                //نسوي إجرا لكي يتم حساب الثمن و الكميه ليعطينا المبلغ
                if (txtPrice.Text != string.Empty && txtQte.Text != string.Empty)
                {

                    txtAmount.Text = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQte.Text)).ToString();
                }
                //double Amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQte.Text);
                // txtAmount.Text = Amount.ToString();
            }
            catch
            {
                return;
            }

        }
        void CalculateTotelAmount()      //إجراء جديد يقوم بحساب المبلغ الاجمالي
        {
            //  تحقق من نسبة الخصم وتحولها إلى قيمة رقمية   
            if (txtDiscount.Text != string.Empty && txtAmount.Text != string.Empty)
            {
                double Discount = Convert.ToDouble(txtDiscount.Text);
                double Amount = Convert.ToDouble(txtAmount.Text);
                double TotalAmount = Amount - (Amount * (Discount / 100));
                txtTotalAmount.Text = TotalAmount.ToString();
            }
        }
        void ClearBoxes()   //هذا الاجراء يقوم با مسح  الخانات التي تمت إضافتها إلى داتاتابل
        {
            txtIDproduct.Clear();
            txtNameProduct.Clear();
            txtEMAI.Clear();
            txtQte.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtAmount.Clear();
            txtTotalAmount.Clear();
            btnBrowse.Focus();   //هذا يضع موشر جديد من اجل اختيار منتوج ثاني

        }
        void ClearData()   // هذا الاجراء يقوم با مسح الادوات 
        {
            txtOrderID.Clear();
            txtDesOrder.Clear();
            txtSaleMan.Clear();
            dtOrder.ResetText();
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            ClearBoxes();
            Dt.Clear();
            dataGridView.DataSource = null;
            txtSumTotals.Clear();
            pbox.Image = null;

            btnSave.Enabled = false;
            btnNew.Enabled = true;
            btnPrint.Enabled =true;
        }
        void CreateDataTable()
        {
            Dt.Columns.Add("معرف المنتوج");
            Dt.Columns.Add("اسم المنتوج");
            Dt.Columns.Add("الرقم التسلسلي");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("الثمن"); //سعر الواحده
            Dt.Columns.Add("المبلغ المنتوج"); // سعر الجملة المبلغ يساوي الكمية في الثمن
            Dt.Columns.Add(" نسبة الخصم (%)");
            Dt.Columns.Add("المبلغ الإجمالي "); //المبلغ الحقيقي 

            dataGridView.DataSource = Dt;

        }
        void ResizeDGV()            //إعادة تحجيم الخانات المودوده في داتاجريد فيوا
        {
            this.dataGridView.RowHeadersWidth =100;
            this.dataGridView.Columns[0].Width = 140;
            this.dataGridView.Columns[1].Width = 133;
            this.dataGridView.Columns[2].Width = 223;
            this.dataGridView.Columns[3].Width = 123;
            this.dataGridView.Columns[4].Width = 100;
            this.dataGridView.Columns[5].Width = 100;
            this.dataGridView.Columns[6].Width = 100;
        }



        private bool CheckProductAvailability(string productId, int requestedQty)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT QTE_IN_STOCK FROM PRODUCT WHERE ID_PRODUCT = @ProductID", con);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int availableQty))
                    {
                        if (availableQty == 0)
                        {
                            MessageBox.Show("المنتج غير متوفر في المخزون حالياً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                        if (availableQty < requestedQty)
                        {
                            MessageBox.Show($"الكمية المطلوبة ({requestedQty}) أكبر من الكمية المتاحة ({availableQty})", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على هذا المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التحقق من الكمية: " + ex.Message);
                return false;
            }

            return true;
        }
        public FRM_ORDERS()
        {
            InitializeComponent();
            CreateDataTable();  // هذا يقوم باستدعاء في الاعلى الاجراء ويضهره في الداتاجردفيو
                                // ResizeDGV();
            txtSaleMan.Text = Program.SaleMan;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.txtOrderID.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();    //ليس فيها باروميترات

            btnNew.Enabled = false;
            btnSave.Enabled = true;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
                frm.ShowDialog(); //فتح الفورم
                if (frm.datCUSTOMER.CurrentRow.Cells[5].Value is DBNull)   // نستخدم تري او هذه الطريقة

                {
                    MessageBox.Show("هذا العميل لا يحتوي على صورة");
                    this.txtCustomerID.Text = frm.datCUSTOMER.CurrentRow.Cells[0].Value.ToString();
                    this.txtFirstName.Text = frm.datCUSTOMER.CurrentRow.Cells[1].Value.ToString();
                    this.txtLastName.Text = frm.datCUSTOMER.CurrentRow.Cells[2].Value.ToString();
                    this.txtTel.Text = frm.datCUSTOMER.CurrentRow.Cells[3].Value.ToString();
                    this.txtEmail.Text = frm.datCUSTOMER.CurrentRow.Cells[4].Value.ToString();
                    pbox.Image = null; // هذا يقوم با فراغ الصورة
                    return;}
                this.txtCustomerID.Text = frm.datCUSTOMER.CurrentRow.Cells[0].Value.ToString();
                this.txtFirstName.Text = frm.datCUSTOMER.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = frm.datCUSTOMER.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = frm.datCUSTOMER.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = frm.datCUSTOMER.CurrentRow.Cells[4].Value.ToString();
                byte[] custPicture = (byte[])frm.datCUSTOMER.CurrentRow.Cells[5].Value;  //تحويل الصورة إلى مصفوفه ثنائية 
                MemoryStream ms = new MemoryStream(custPicture); //  تخزن في الذاكره 
                pbox.Image = Image.FromStream(ms); // ثم قراءة الصورة من الذاكرة من خلال فروم ستريم
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            {

            }
        }
        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)  // عندما نريد ادخال الثمن  
            {
                txtQte.Focus();
            }
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQte.Text != string.Empty)  // عندما نريد ادخال الثمن  
            {
                txtDiscount.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotelAmount();
        }

        private void txtQte_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotelAmount();
        }
        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotelAmount();
        }
        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {  // يقوم بانزال من الخصم الى داتاجريد فيو
       
            if (e.KeyCode == Keys.Enter)
            {
                // التحقق من توفر الكمية
                if (order.verifyQte(txtIDproduct.Text, Convert.ToInt32(txtQte.Text)).Rows.Count < 0)
                {
                    MessageBox.Show("الكميه المدخلة لهذا المنتج غير متوفرة ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // التحقق من تكرار الإيميل فقط إذا لم يكن فارغا
                if (!string.IsNullOrEmpty(txtEMAI.Text))
                {
                    for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    {
                        if (dataGridView.Rows[i].Cells[2].Value != null &&
                            dataGridView.Rows[i].Cells[2].Value.ToString() == txtEMAI.Text)
                        {
                            MessageBox.Show("هذا المنتج تم إدخالة من قبل ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }

                // إضافة السجل الجديد
                DataRow r = Dt.NewRow();
                r[0] = txtIDproduct.Text;
                r[1] = txtNameProduct.Text;
                r[2] = txtEMAI.Text;
                r[3] = txtPrice.Text;
                r[4] = txtQte.Text;
                r[5] = txtAmount.Text;
                r[6] = txtDiscount.Text;
                r[7] = txtTotalAmount.Text;
                Dt.Rows.Add(r);

                dataGridView.DataSource = Dt;
                ClearBoxes();

                txtSumTotals.Text =
                (from DataGridViewRow row in dataGridView.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                ClearBoxes();  // تنضيف الخانات

                FRM_PRODUCT_LIST frml = new FRM_PRODUCT_LIST();
                frml.ShowDialog();
                this.txtIDproduct.Text = frml.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtNameProduct.Text = frml.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtPrice.Text = frml.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }
        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtIDproduct.Text = this.dataGridView.CurrentRow.Cells[0].Value.ToString();
                txtNameProduct.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
                txtEMAI.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
                txtQte.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
                txtAmount.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
                txtDiscount.Text = this.dataGridView.CurrentRow.Cells[6].Value.ToString();
                txtTotalAmount.Text = this.dataGridView.CurrentRow.Cells[7].Value.ToString();
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);

                txtQte.Focus();
            }
            catch
            {
                return;
            }
        }
        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView_DoubleClick(sender, e);
        }

        private void حذفسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
        }
        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dt.Clear();
            dataGridView.Refresh();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
        
            try
            {
                // التحقق من صحة الإدخال
                if (txtOrderID.Text == string.Empty || txtCustomerID.Text == string.Empty || dataGridView.Rows.Count < 1 || txtDesOrder.Text == string.Empty)
                {
                    MessageBox.Show("ينبغي عليك تسجيل المعلومات المهمة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                                                                                                                                                    // قراءة نوع الدفع من ComboBox
                string paymentType = cmbPaymentType.Text;
      
                                                                                                                                                    // التحقق أن نوع الدفع تم اختياره
                if (string.IsNullOrWhiteSpace(paymentType))
                {
                    MessageBox.Show("يرجى اختيار نوع الدفع (نقدي / آجل)", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // قراءة حالة التعليق من CheckBox
                bool isSuspended = chkSuspended.Checked;

                // إضافة معلومات الفاتورة
                order.ADD_ORDER(
                    Convert.ToInt32(txtOrderID.Text),
                    dtOrder.Value,
                    Convert.ToInt32(txtCustomerID.Text),
                    txtDesOrder.Text,
                    txtSaleMan.Text,
                    paymentType,
                    isSuspended
                );

                // إضافة المنتجات المدخلة
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    order.ADD_ORDER_DETAILS(
                        dataGridView.Rows[i].Cells[0].Value.ToString(),
                        Convert.ToInt32(txtOrderID.Text),
                        dataGridView.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value),
                        dataGridView.Rows[i].Cells[3].Value.ToString(),
                        Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value),
                        dataGridView.Rows[i].Cells[5].Value.ToString(),
                       dataGridView.Rows[i].Cells[7].Value.ToString()
                    );
                }

                MessageBox.Show("تمت عمليت الحفظ بنجاح", "عملبة الحفط", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء: " + ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //ينبغي علينا انحصل على اخر فاتوره تم تخزينها لكي نحصل على رقمها
            this.Cursor = Cursors.WaitCursor; //LOAD    يتحول إلى علامات التحميل
            int order_ID = Convert.ToInt32(order.GET_LAST_ORDER_ID_FOR_PRINT().Rows[0][0]);//هذا رقم الفاتوره
            RPT.rpt_ordersrpt report = new RPT.rpt_ordersrpt();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            report.SetDataSource(order.GetOrderDetails(order_ID));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default; //LOAD 
        }
        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
                e.Handled = true;
            }
        }
        private void txtDesOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtOrder.Focus();
                e.Handled = true;
            }
        }
        private void dtOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
                e.Handled = true;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //هذا عند حذف عنصر من عارض البيانات يقوم بتعديل على الجموع الكلي
        private void dataGridView_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtSumTotals.Text=(from DataGridViewRow row in dataGridView.Rows
                               where row.Cells[6].FormattedValue.ToString() !=string.Empty
                               select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void txtEMAI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtEMAI.Text != string.Empty)  // عندما نريد ادخال الثمن  
            {
                txtQte.Focus();
            }
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[7].Value);
                }
            }
            txtSumTotals.Text = total.ToString("N2");
        }



    }
}
