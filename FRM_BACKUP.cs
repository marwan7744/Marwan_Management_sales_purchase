using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   //مجال الاسماء الذي يمكننا التاعمل مع قاعدة البيانات
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace MANGEMENT.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");
        SqlCommand cmd;//= new SqlCommand();
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;   //سلكت باث تعيد المسار المحداد
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text + "product_DO_" + DateTime.Now.ToShortDateString().Replace('/', '_')

             + " _ " + DateTime.Now.ToLongTimeString().Replace(':', '_');
            string strQuery = "Backup Database product_DO_ to Disk='" + fileName + ".bak'";
            cmd = new SqlCommand(strQuery,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" تم إنشاء النسخة الإحتياطية بنجاح", "إنشاء النسخة الإحتياطية",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }

