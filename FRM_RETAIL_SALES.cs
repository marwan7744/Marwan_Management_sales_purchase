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
    public partial class FRM_RETAIL_SALES : Form
    {
        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";
        private BL.CLS_RETAIL_SALES retailSales = new BL.CLS_RETAIL_SALES();
        private DataTable saleItems = new DataTable();
        private int currentOrderId = 0;
        public FRM_RETAIL_SALES()
        {
            InitializeComponent();
            SetupSaleItemsTable();
            LoadProducts(); 
     
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
                    cmbProduct.DisplayMember = "LABEL_PRODUCT";
                    cmbProduct.ValueMember = "ID_PRODUCT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetupSaleItemsTable()
        {
            saleItems.Columns.Add("معرف المنتج");
            saleItems.Columns.Add("الاسم");
            saleItems.Columns.Add("الكمية");
            saleItems.Columns.Add("سعر الوحدة");
            saleItems.Columns.Add("الإجمالي");

            dataGridView.DataSource = saleItems;
        }


        private void btnNewSale_Click(object sender, EventArgs e)
        {
            try
            {
                txtSaleId.Text = retailSales.sp_GetLastSaleID().Rows[0][0].ToString();
                saleItems.Clear();
                txtTotal.Text = "0";
                cmbPaymentMethod.SelectedIndex = 0;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try {
             DateTime SaleDate = dtOrder.Value;
            decimal UnitPrice = decimal.Parse(txtUnitPrice.Text);
            cmbProduct.SelectedValue.ToString();
            int Quantity = int.Parse(txtQuantity.Text);
            decimal total = UnitPrice * Quantity;

                retailSales.AddRetailSale(dtOrder.Value, cmbProduct.Text,
               int.Parse(txtQuantity.Text),
               decimal.Parse(txtUnitPrice.Text),
               decimal.Parse(txtTotal.Text),
               cmbPaymentMethod.Text
           );
                MessageBox.Show("تم إضافة الإيراد بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRow row = saleItems.NewRow();
                row["معرف المنتج"] = cmbProduct.Text;
                row["الاسم"] = txtProductName.Text;
                row["الكمية"] = Quantity;
                row["سعر الوحدة"] = UnitPrice;
                row["الإجمالي"] = total;

                saleItems.Rows.Add(row);
           //     CalculateTotal();

        }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        //private void CalculateTotal()
        //{
        // //   decimal total = 0;
        //    foreach (DataRow row in saleItems.Rows)
        //    {
        //        total += decimal.Parse(row["الإجمالي"].ToString());
        //    }
        //    txtTotal.Text = total.ToString();
        //}
        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            try{        
             //   currentOrderId = int.Parse(txtSaleId.Text);
                // حفظ الفاتورة الرئيسية
  retailSales.AddRetailSale(dtOrder.Value,cmbProduct.Text,
                int.Parse(txtQuantity.Text),
                decimal.Parse(txtUnitPrice.Text), 
                decimal.Parse(txtTotal.Text),
                cmbPaymentMethod.Text
            );
                // حفظ تفاصيل الفاتورة
                foreach (DataRow row in saleItems.Rows)
                {
                    retailSales.AddRetailSaleDetail(
                         Convert.ToInt32(txtSaleId.Text),
                        row["معرف المنتج"].ToString(),
                        int.Parse(row["الكمية"].ToString()),
                        decimal.Parse(row["سعر الوحدة"].ToString())
                    );
                    MessageBox.Show("تم حفظ الفاتورة بنجاح!");
                    btnNewSale.PerformClick(); // إعادة تعيين الفورم
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}