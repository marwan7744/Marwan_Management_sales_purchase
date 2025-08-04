using MANGEMENT.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_MANAGE_PURCHASES : Form
    {
        private InvoiceManager invoiceManager = new InvoiceManager();
        private BL.CLS_PURCHASES purchases = new BL.CLS_PURCHASES();
        //   private string state = "add"; // حالة الفورم (إضافة أو تعديل)
        // private BL.CLS_PURCHASES purchases = new BL.CLS_PURCHASES();
        private BL.CLS_PRODUCTS products = new BL.CLS_PRODUCTS();
        private BL.CLS_TB_SUPPLIER suppliers = new BL.CLS_TB_SUPPLIER();
        private string state = "add"; // حالة الفورم (إضافة أو تعديل)
        public FRM_MANAGE_PURCHASES()
        {
            InitializeComponent();
            LoadPurchases();
         //   LoadSuppliers(); // تحميل الموردين في ComboBox
            LoadProducts();  // تحميل المنتجات في ComboBox
           // IDataGridView();
        }
        // دالة لتحميل المشتريات في DataGridView
        private void LoadPurchases()
        {
            dataGridViewPurchasesItems.DataSource = purchases.GET_ALL_PURCHASES();
        }
        // دالة لتحميل الموردين في ComboBox
        //private void LoadSuppliers()
        //{
        //    DataTable TB_SUPLIERS = invoiceManager.GetAllSuppliers();
          
        //    cmbSuppliers.DisplayMember = "FullName"; // الاسم المعروض
        //    cmbSuppliers.ValueMember = "ID_SUPPLIER"; // القيمة المخزنة
        //    cmbSuppliers.DataSource = TB_SUPLIERS;     //  cmbSuppliers.DataSource = TB_SUPLIERS;
        //}

        // دالة لتحميل المنتجات في ComboBox
        private void LoadProducts()
        {
            DataTable PRODUCT = invoiceManager.sp_GetAvailableProducts();
            // DataTable PRODUCT = invoiceManager.GETALLPRODUCT();
            cmbProducts.DisplayMember = "LABEL_PRODUCT"; // يعرض اسم المنتج
            cmbProducts.ValueMember = "ID_PRODUCT"; // القيمة هي ID_PRODUCT
            cmbProducts.DataSource = PRODUCT;
            //  cmbProducts.DataSource = PRODUCT;
            //  cmbProducts.DisplayMember = "LABEL_PRODUCT"; // الاسم المعروض
            //cmbProducts.ValueMember = "ID_PRODUCT"; // القيمة المخزنة
            //cmbProducts.DataSource = PRODUCT;
        }
        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string ID_PRODUCT = cmbProducts.SelectedValue.ToString();
                if (state == "add")
                {
                    //اعمل كلاس جديد
                 //   purchases.ADD_PURCHASES(
                    //    Convert.ToInt32(cmbSuppliers.SelectedValue), // استخدام ComboBox للموردين
                    //    cmbProducts.SelectedValue.ToString(),       // استخدام ComboBox للمنتجات
                     //   Convert.ToInt32(txtQuantity.Text),
                     //   Convert.ToDecimal(txtUnitPrice.Text),
                     //   Convert.ToDecimal(txtTotal.Text),
                  //      txtInvoiceType.Text
                  //  );
                    MessageBox.Show("تمت إضافة المشتريات بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    purchases.UPDATE_PURCHASE(
                        Convert.ToInt32(txtPurchaseID.Text),
                        Convert.ToInt32(cmbSuppliers.SelectedValue), // استخدام ComboBox للموردين
                        cmbProducts.SelectedValue.ToString(),        // استخدام ComboBox للمنتجات
                        Convert.ToInt32(txtQuantity.Text),
                        Convert.ToDecimal(txtUnitPrice.Text),
                          Convert.ToDecimal(txtTotal.Text)
                         // txtInvoiceType.Text
                    );
                    MessageBox.Show("تم تعديل المشتريات بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadPurchases();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message,"error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewPurchasesItems.SelectedRows.Count > 0)
            {
                int ID_PURCHASE = Convert.ToInt32(dataGridViewPurchasesItems.CurrentRow.Cells["ID_PURCHASE"].Value);
                purchases.DELETE_PURCHASE(ID_PURCHASE);
                MessageBox.Show("تم حذف المشتريات بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPurchases();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            dataGridViewPurchasesItems.DataSource = purchases.SEARCH_PURCHASES(txtSearch.Text);
        }

        private void dataGridViewPurchasesItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          

        }
        //private void IDataGridView()
        //{
        //    dataGridViewPurchasesItems.Columns.Add("ID_PRODUCT", "معرف المنتج");
        //    dataGridViewPurchasesItems.Columns.Add("ID_SUPPLIER", "معرف المورد ");
        //    dataGridViewPurchasesItems.Columns.Add("QTE_PURCHASED", "الكمية");
        //    dataGridViewPurchasesItems.Columns.Add("PRICE_PURCHASED", "سعر الشراء");
        //      dataGridViewPurchasesItems.Columns.Add("TotalPrice", "الإجمالي");
        //}

        private void dataGridViewPurchasesItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPurchasesItems.Rows[e.RowIndex];
                txtPurchaseID.Text = row.Cells["ID_PURCHASE"].Value.ToString();
                cmbSuppliers.SelectedValue = row.Cells["ID_SUPPLIER"].Value; // تحديث ComboBox للموردين
                cmbProducts.SelectedValue = row.Cells["ID_PRODUCT"].Value;   // تحديث ComboBox للمنتجات
                txtQuantity.Text = row.Cells["QTE_PURCHASED"].Value.ToString();
                txtUnitPrice.Text = row.Cells["PRICE_PURCHASED"].Value.ToString();
                state = "edit"; // تغيير الحالة إلى تعديل
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnprintInvoice_Click(object sender, EventArgs e)
        {
            //طباعة كل الاصناف
            RPT.rpt_Get_All_purchases rpt = new RPT.rpt_Get_All_purchases();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.Refresh(); //لتحديث
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.Single_PurchaseReport rpt = new RPT.Single_PurchaseReport();
                RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                rpt.SetParameterValue("@ID_PURCHASE", Convert.ToInt32(txtPurchaseID.Text)); //يقوم بتحويل القيمه النصيه إلى قيمه رقميه
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MANAGE_PURCHASES_MouseDown(object sender, MouseEventArgs e)
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

