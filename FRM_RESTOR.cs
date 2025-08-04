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
    public partial class FRM_RESTOR : Form
    {
        SqlConnection con = new SqlConnection(@"server=ADMIN\SQLEXPRESS;Database=master;Integrated Security=true");
        SqlCommand cmd;
        public FRM_RESTOR()
        {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
          // if(openFileDialog1.ShowDialog()== DialogResult.OK)
            //{
              // txtFileName.Text = openFileDialog1.FileName;
            //}
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Backup file(*.Back)| *.Bak";
            if (op.ShowDialog() == DialogResult.OK)
            {
                cmd = new SqlCommand("Restore DataBase product_DO_ From Disk ='" + op.FileName + "'with replace", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" تم إستعادة النسخة الإحتياطية بنجاح", "إستعادة النسخة الإحتياطية",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FRM_RESTOR_Load(object sender, EventArgs e)
        {

        }
    }
}
