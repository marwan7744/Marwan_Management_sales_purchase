using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DevExpress.XtraEditors.Controls;
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
    public partial class FRM_DAILY_EXPENSES : Form
    {
        private ExpenseManager expenseManager = new ExpenseManager();
        public FRM_DAILY_EXPENSES()
        {
            InitializeComponent();
            LoadExpenses(); // تحميل المصروفات عند تحميل الفورم

            dataGridViewExpenses.Refresh();
            //  UpdateDailyTotal(); // تحديث الإجمالي اليومي عند تحميل الفورم
        }
        // تحميل المصروفات وعرضها في DataGridView
        private void LoadExpenses()
        {
            DataTable expenses = expenseManager.GET_DailyExpenses();
            dataGridViewExpenses.DataSource = expenses;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            System.DateTime expenseDate = datetime.Value;
            string description = textBoxDescription.Text;
            decimal amount = decimal.Parse(textBoxAmount.Text);
            string notes = textBoxNotes.Text;
            string UserName = cobUserName.Text;
            expenseManager.ADD_DailyExpenses(expenseDate, description, amount, notes, UserName);
            MessageBox.Show("تم إضافة المصروف بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تحديث قائمة المصروفات
            LoadExpenses();
            // تحديث الإجمالي اليومي
          //  UpdateDailyTotal();
            // مسح الحقول بعد الإضافة
            ClearFields();
            // ClearFields();
        }
        //private void UpdateDailyTotal()
        //{
        //    DateTime selectedDate = dateTimePickerExpenseDate.Value;
        // //   decimal dailyTotal = expenseManager.GetDailyTotalFromTotals(selectedDate);

        //    if (dailyTotal == 0)
        //    {
        //        labelDailyTotal.Text = "لا توجد مصروفات مسجلة لهذا اليوم.";
        //    }
        //    else
        //    {
        //        labelDailyTotal.Text = $"الإجمالي اليومي: {dailyTotal:N2}";
        //    }
        //}

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {

            if (dataGridViewExpenses.SelectedRows.Count > 0)
            {
                int expenseID = Convert.ToInt32(dataGridViewExpenses.SelectedRows[0].Cells["ExpenseID"].Value);
                expenseManager.DeleteExpense(expenseID);
                MessageBox.Show("تم حذف المصروف بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // تحديث قائمة المصروفات
                LoadExpenses();
                // تحديث الإجمالي اليومي
               // UpdateDailyTotal();
            }
        }

        // مسح الحقول
        private void ClearFields()
        {
            txtExpenseID.Clear();
            textBoxDescription.Clear();
            textBoxAmount.Clear();
            cobUserName.SelectedIndex = -1;
            textBoxNotes.Clear();
            cobUserName.Items.Clear();
        }

        private void FRM_DAILY_EXPENSES_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBoxDescription.Clear();
            textBoxAmount.Clear();
            cobUserName.SelectedIndex = -1;
            textBoxNotes.Clear();
        }

        private void dateTimePickerExpenseDate_ValueChanged(object sender, EventArgs e)
        {
            //UpdateDailyTotal();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ExpenseID = Convert.ToInt32(txtExpenseID.Text);
            System.DateTime expenseDate = datetime.Value;
            string description = textBoxDescription.Text;
            decimal amount = decimal.Parse(textBoxAmount.Text);
            string notes = textBoxNotes.Text;
            string UserName = cobUserName.Text;
            expenseManager.UPDATE_DailyExpenses(ExpenseID, expenseDate, description, amount, notes, UserName);
            MessageBox.Show("تم تعديل المصروف بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewExpenses.Refresh();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPrints_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = expenseManager.GET_DailyExpenses();

                RPT.RPT_DailyExpenses rpt = new RPT.RPT_DailyExpenses(); // تأكد من اسم التقرير
                rpt.SetDataSource(dt);

                RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT(); // أو أي فورم يحتوي على CrystalReportViewer
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewExpenses.CurrentRow == null)
                {
                    MessageBox.Show("يرجى اختيار الصف.");
                    return;
                }

                   int ExpenseID = Convert.ToInt32(dataGridViewExpenses.SelectedRows[0].Cells["ExpenseID"].Value);
                 //  System.DateTime expenseDate = datetime.Value;

                  DataTable dt =  expenseManager.GET_SINGLE_DailyExpenses(ExpenseID);
                //DataTable dt = result.ledgerDetails;

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد بيانات لعرضها في التقرير.");
                    return;
                }

                RPT.RPT_SINGLE_DailyExpenses rpt = new RPT.RPT_SINGLE_DailyExpenses();
                    rpt.SetDataSource(dt);
                // تمرير البارامترات المطلوبة
                rpt.SetParameterValue("ExpenseID", ExpenseID);


                RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في طباعة التقرير: " + ex.Message);
            }
        }
        
        private void dataGridViewExpenses_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                int ExpenseID = Convert.ToInt32(dataGridViewExpenses.Rows[e.RowIndex].Cells["ExpenseID"].Value);

               


            }
        }
        private void dataGridViewExpenses_DoubleClick(object sender, EventArgs e)
        {
            txtExpenseID.Text =this.dataGridViewExpenses.CurrentRow.Cells[0].Value.ToString();
            datetime.Text = this.dataGridViewExpenses.CurrentRow.Cells[1].Value.ToString();
            textBoxDescription.Text = this.dataGridViewExpenses.CurrentRow.Cells[2].Value.ToString();
           
            textBoxAmount.Text = this.dataGridViewExpenses.CurrentRow.Cells[3].Value.ToString();


            textBoxNotes.Text= this.dataGridViewExpenses.CurrentRow.Cells[4].Value.ToString();
           cobUserName.Text =this.dataGridViewExpenses.CurrentRow.Cells[5].Value.ToString();

            dataGridViewExpenses.Refresh();
        }

        private void FRM_DAILY_EXPENSES_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

            }
        }

        private void textBoxDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                datetime.Focus();
            }
        }

        private void datetime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxAmount.Focus();
            }
        }

        private void textBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxAmount.Focus();
            }
        }

        private void textBoxNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cobUserName.Focus();
            }
        }
    }
}


