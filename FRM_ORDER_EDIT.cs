using MANGEMENT.BL;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_ORDER_EDIT : Form
    {

        private DataTable Dt = new DataTable(); // جدول بيانات تفاصيل الفاتورة
        private BL.CLS_ORDERS order = new BL.CLS_ORDERS(); // كائن إدارة الفواتير
        private void LoadCustomerData(int ID_CUSTOMER, string FIRST_NAME, string LAST_NAME, string TEL, string EMAI)
        {
           
            DataTable customerData = order.GetAllCustomers();
            if (customerData.Rows.Count > 0)
            {
                txtFirstName.Text = customerData.Rows[0]["FIRST_NAME"].ToString();
                txtLastName.Text = customerData.Rows[0]["LAST_NAME"].ToString();
                txtTel.Text = customerData.Rows[0]["TEL"].ToString();
                txtEmail.Text = customerData.Rows[0]["EMAI"].ToString();
              
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
        void ClearBoxes()     //هذا الاجراء يقوم با مسح  الخانات التي تمت إضافتها إلى داتاتابل
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

         
         
          
        }

        void EnsureColumnsExist(DataGridView dataGridView)
        {
            AddColumnIfNotExists(dataGridView, "ID_PRODUCT", "معرف المنتج");
            AddColumnIfNotExists(dataGridView, "LABEL_PRODUCT", "اسم المنتج");
            AddColumnIfNotExists(dataGridView, "MEID", "الرقم التسلسلي");
            AddColumnIfNotExists(dataGridView, "PRICE", "الثمن");
            AddColumnIfNotExists(dataGridView, "QTE", "الكمية");
            AddColumnIfNotExists(dataGridView, "AMOUNT", "المبلغ");
            AddColumnIfNotExists(dataGridView, "DISCOUNT", "الخصم");
            AddColumnIfNotExists(dataGridView, "TOTAL_AMOUNT", "المبلغ الإجمالي");
        }

        void AddColumnIfNotExists(DataGridView dgv, string name, string headerText)
        {
            if (!dgv.Columns.Contains(name))
            {
                dgv.Columns.Add(name, headerText);
            }
        }

        void InitializeDataTable()
        {
            Dt.Columns.Add("ID_PRODUCT");
            Dt.Columns.Add("LABEL_PRODUCT");
            Dt.Columns.Add("MEID");
            Dt.Columns.Add("PRICE");
            Dt.Columns.Add("QTE");
            Dt.Columns.Add("AMOUNT");
            Dt.Columns.Add("DISCOUNT");
            Dt.Columns.Add("TOTAL_AMOUNT");
        }
        public FRM_ORDER_EDIT()
        {
            InitializeComponent();
            EnsureColumnsExist(dataGridView);
            InitializeDataTable();
            dataGridView.ForeColor = Color.Black;
          

        }
        private void btnEditOrder1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderID.Text == string.Empty)
                {
                    MessageBox.Show("يرجى إدخال رقم الفاتورة أولاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int orderId = Convert.ToInt32(txtOrderID.Text);

                // تحميل بيانات الفاتورة من الإجراء المخزن
                DataTable dt = order.GetOrderDetails(orderId);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم العثور على الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // تعبئة بيانات الرأس
                txtCustomerID.Text = dt.Rows[0]["معرف العميل"].ToString();
                txtDesOrder.Text = dt.Rows[0][" وصف الفاتورة"].ToString();
                txtSaleMan.Text = dt.Rows[0]["اسم البائع"].ToString();
                dtOrder.Value = Convert.ToDateTime(dt.Rows[0]["تاريخ الفاتورة"]);

                // تفريغ DataGridView
                dataGridView.Rows.Clear();

                LoadCustomerData(Convert.ToInt32(txtCustomerID.Text), txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text);
  
                        // تعبئة التفاصيل
         foreach (DataRow row in dt.Rows)
                {
                    dataGridView.Rows.Add(
                        row["معرف المنتج"],
                        row["اسم المنتج"],
                        row["الرقم التسلسلي"],
                        row[" الثمن"],
                        row[" الكمية"],
                        row["المبلغ"],
                        row["الخصم"],
                        row["المبلغ الإجمالي"]
                    );
                }

                MessageBox.Show("تم تحميل الفاتورة بنجاح، يمكنك التعديل الآن", "تحميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء في التحميل: " + ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }
        public bool OrderExists(int orderId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ORDERS WHERE order_id = @id");
            cmd.Parameters.AddWithValue("@id", orderId);
            DAL.Open();
            int count = (int)cmd.ExecuteScalar();
            DAL.Close();
            return count > 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
       
            try
            {
                if (txtOrderID.Text == string.Empty || txtCustomerID.Text == string.Empty || dataGridView.Rows.Count < 1 || txtDesOrder.Text == string.Empty)
                {
                    MessageBox.Show("ينبغي عليك تسجيل المعلومات المهمة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int orderId = Convert.ToInt32(txtOrderID.Text);

                // حذف تفاصيل الفاتورة القديمة قبل إعادة الإضافة مع تجاهل الخطأ
                try
                {
                    order.DeleteOrderDetails(orderId);
                }
                catch
                {
                  
                }

                // تحديث معلومات الفاتورة
                order.UPDATE_ORDER(orderId, dtOrder.Value, Convert.ToInt32(txtCustomerID.Text), txtDesOrder.Text, txtSaleMan.Text);

                // إضافة تفاصيل الفاتورة الجديدة
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    order.ADD_ORDER_DETAILS(
                        dataGridView.Rows[i].Cells[0].Value.ToString(),
                        orderId,
                        dataGridView.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value),
                        dataGridView.Rows[i].Cells[3].Value.ToString(),
                        Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value),
                        dataGridView.Rows[i].Cells[5].Value.ToString(),
                        dataGridView.Rows[i].Cells[7].Value.ToString()
                    );
                }

                MessageBox.Show("تم التعديل بنجاح", "تحديث الفاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء " + ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
        
            if (e.KeyCode == Keys.Enter)
            {
              
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value?.ToString() == txtEMAI.Text)
                    {
                        MessageBox.Show("هذا المنتوج تم إدخاله مسبقا");
                        return;
                    }
                }

                // إدخال الصف الجديد مباشرة في  
                dataGridView.Rows.Insert(0,
                    txtIDproduct.Text,
                    txtNameProduct.Text,
                    txtEMAI.Text,
                    txtPrice.Text,
                    txtQte.Text,
                    txtAmount.Text,
                    txtDiscount.Text,
                    txtTotalAmount.Text
                );

                ClearBoxes();

                //      تحديث الإجمالي
                double sum = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    double.TryParse(row.Cells[7].Value?.ToString(), out double value);
                    sum += value;
                }
                txtSumTotals.Text = sum.ToString("N2");
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPrice.Text != string.Empty)  // عندما نريد ادخال الثمن  
            {
                txtQte.Focus();
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {

            CalculateAmount();
            CalculateTotelAmount();
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQte.Text != string.Empty)  // عندما نريد ادخال الثمن  
            {
                txtDiscount.Focus();
            }
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

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtSumTotals.Text=(from DataGridViewRow row in dataGridView.Rows
                where row.Cells[6].FormattedValue.ToString() !=string.Empty
                select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
                    return;
                }
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
        }

        private void FRM_ORDER_EDIT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

            }
        }

        private void txtEMAI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQte.Focus();
            }
        }

        private void FRM_ORDER_EDIT_Load(object sender, EventArgs e)
        {
        }

        private void txtOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEditOrder1.Focus();
                e.Handled = true;
            }
        }

        private void txtOrderID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDesOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtOrderID.Focus();
                e.Handled = true;
            }
        }
    }
}
