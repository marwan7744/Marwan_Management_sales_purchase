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
    public partial class FRM_JournalEntries : Form
    {
        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";
        private DataTable saleItems = new DataTable();

        LedgerManager ledger = new LedgerManager();
        public FRM_JournalEntries()
        {
            InitializeComponent();
        }

        private void btnShowCustomerLedger_Click(object sender, EventArgs e)
        {
            LoadJournalEntries();
        
           
        }

            private void LoadJournalEntries()
        {
        
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT EntryID, EntryDate, AccountID, AccountType, Descriptions, Debit, Credit, RefType, RefID FROM JournalEntries";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // تعريب رؤوس الأعمدة
                    dataGridView1.Columns["EntryID"].HeaderText = "رقم القيد";
                    dataGridView1.Columns["EntryDate"].HeaderText = "تاريخ القيد";
                    dataGridView1.Columns["AccountID"].HeaderText = "رقم الحساب";
                    dataGridView1.Columns["AccountType"].HeaderText = "نوع الحساب";
                    dataGridView1.Columns["Descriptions"].HeaderText = "البيان";
                    dataGridView1.Columns["Debit"].HeaderText = "مدين";
                    dataGridView1.Columns["Credit"].HeaderText = "دائن";
                    dataGridView1.Columns["RefType"].HeaderText = "نوع المرجع";
                    dataGridView1.Columns["RefID"].HeaderText = "رقم المرجع";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحميل القيود: " + ex.Message);
            }
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_JournalEntries_Load(object sender, EventArgs e)
        {

        }
    }
    
}
