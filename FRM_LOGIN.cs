using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_LOGIN : Form
    {
      

        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Dt = log.SP_LOGIN(txtID.Text, txtPWD.Text);  //  المامل الثاني وهوالباسوردID المعامل االاول النص  وهو القيمه الموجوده في
                if (Dt.Rows.Count > 0)  //فحص  إذا كان الاسطر اكبر من الصفر يحتوي على بيانات 
                {
                    if (Dt.Rows[0][2].ToString() == "مدير")
                    {
                        FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.الستخدمونToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إستعادةنسخةالإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.الستخدمونToolStripMenuItem.Visible = true; //يستطيع يسجل في المستخدمين والشاشه مفتوحه
                        FRM_MAIN.getMainForm.الموردينToolStripMenuItem.Visible = true;
                       // FRM_MAIN.getMainForm.الديونToolStripMenuItem.Visible = true;
                        Program.SaleMan = Dt.Rows[0]["FullName"].ToString();
                        Program.PURCHASE_MAN = Dt.Rows[0]["PURCHASE_MAN"].ToString();
                        this.Close();

                    }
                    else if (Dt.Rows[0][2].ToString() == "عامل")
                    {
                        FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.الستخدمونToolStripMenuItem.Visible = false; //لا يرى المستخدمين
                        FRM_MAIN.getMainForm.إنشاءنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.إستعادةنسخةالإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.الموردينToolStripMenuItem.Visible = true;
                      //  FRM_MAIN.getMainForm.الديونToolStripMenuItem.Enabled = true;
                        Program.SaleMan = Dt.Rows[0]["FullName"].ToString();
                        Program.PURCHASE_MAN = Dt.Rows[0]["PURCHASE_MAN"].ToString();
                        this.Close();
                    }

                }
                else
                {
                    // Login();
                    MessageBox.Show("login fail !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //private void Login()
        //{
        //    try
        //    {
        //       // btnlogin.Dt.TBL_USER.Where(x => x.txtID.Text == txtPWD.Text).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
       // }
        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
           // if(e.KeyCode == Keys.Enter)
           // {
            //    txtPWD.Focus();
            //}
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
         //  if(e.KeyCode == Keys.Enter)
            //{
            //    btnlogin.Focus();
           // }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtPWD.Focus();
                e.Handled = true;
            }
        }

        private void txtPWD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.Focus();
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
