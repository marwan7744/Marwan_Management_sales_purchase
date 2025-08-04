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
    public partial class frm_customer_pym : Form
    {
        private DebtManagerPy  debtManager = new DebtManagerPy();
        private CustomerManager customerManager = new CustomerManager();
        private CLS_CUSTOMERS debtCustomer = new CLS_CUSTOMERS();
        public frm_customer_pym()
        {
            InitializeComponent();
            LoadCustomers();
            LoadDebts();
        }
        private void LoadCustomers()
        {
            // يمكنك استبدال هذا الكود بجلب العملاء من جدول العملاء
            //DataTable CUSTOMERS = debtCustomer.GET_ALL_CUSTOMERS();
            DataTable CUSTOMERS = customerManager.GetAllCustomers();
            // عرض البيانات في ComboBox
            comboBoxCustomers.DisplayMember = "FIRST_NAME"; // يعرض اسم العميل
            comboBoxCustomers.ValueMember = "ID_CUSTOMER"; // القيمة هي CustomerID
            comboBoxCustomers.DataSource = CUSTOMERS;
        }
        private void LoadDebts()
        {
            // يمكنك استخدام هذا الجزء إذا كنت تريد عرض الديون في DataGridView
            DataTable Debt = debtManager.GetAllDebts();
            dataGridViewDebts.DataSource = Debt;
        }
    
        private void buttonPay_Click_1(object sender, EventArgs e)
        {
            int ID_CUSTOMER = (int)comboBoxCustomers.SelectedValue;
            // int ID_CUSTOMER = int.Parse(textBoxCustomerID.Text); // إدخال CustomerID يدويًا
            decimal paymentAmount = decimal.Parse(textBoxPaymentAmount.Text);

            // التحقق من أن المبلغ المدفوع لا يتجاوز إجمالي الديون
            decimal Debits = debtManager.GetTotalDebt(ID_CUSTOMER);
            if (paymentAmount > Debits)
            {
                MessageBox.Show("المبلغ المدفوع أكبر من إجمالي الديون!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // خصم المبلغ من ديون العميل
            debtManager.PayDebt(ID_CUSTOMER, paymentAmount);

            // عرض رسالة تأكيد
            MessageBox.Show("تم دفع المبلغ بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تحديث البيانات المعروضة (إذا كان هناك DataGridView)
            LoadDebts();
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_customer_pym_MouseDown(object sender, MouseEventArgs e)
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
