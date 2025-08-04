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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPWDConfirm_Validated(object sender, EventArgs e)
        {
            // التاكيد من كلمة المرور
            if(txtPWD.Text !=txtPWDConfirm.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty || txtPWD.Text == string.Empty
    || txtFullName.Text == string.Empty || txtPWDConfirm.Text == string.Empty)
            {
                MessageBox.Show("الرجاء ادخل جميع البيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🟢 تشفير كلمة المرور قبل الحفظ
            string hashedPassword = BL.CLS_LOGIN.HashPassword(txtPWD.Text);

            if (btnSave.Text == "حفظ المستخدم")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.ADD_USER(txtID.Text, txtFullName.Text, hashedPassword, cmbType.Text);
                MessageBox.Show("تم إضافة المستخدم بنجاح", "إضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnSave.Text == "تعديل المستخدم")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.EDIT_USER(txtID.Text, txtFullName.Text, hashedPassword, cmbType.Text);
                MessageBox.Show("تم التعديل المستخدم بنجاح", "تعديل مستخدم ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // 🧹 تنظيف الحقول بعد الحفظ
            txtID.Clear();
            txtFullName.Clear();
            txtPWD.Clear();
            txtPWDConfirm.Clear();
            txtID.Focus();  //من اجل انشاء مستخدم جديد
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                txtFullName.Focus();
            }
        }
        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }

        private void txtPWD_KeyDown(object sender, KeyEventArgs e)
        {
            //if( e.KeyCode == Keys.Enter)
           // {
            //    txtPWDConfirm.Focus();
           // }
        }

        private void txtPWDConfirm_KeyDown(object sender, KeyEventArgs e)
        {
          //  if(e.KeyCode == Keys.Enter)
          //// {
           ////    cmbType.Focus();
            //}
        }

        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
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
                txtPWDConfirm.Focus();
                e.Handled = true;
            }
        }

        private void txtPWDConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                cmbType.Focus();
                e.Handled = true;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtFullName.Focus();
                e.Handled = true;
            }
        }

        private void cmbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
               btnSave.Focus();
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            //يتححق اذا كانت البيانات ممتلئة يسوي حفظ
            if (txtID.Text == string.Empty || txtPWD.Text == string.Empty
                || txtFullName.Text == string.Empty || txtPWDConfirm.Text == string.Empty)
            {
                MessageBox.Show("الرجاء ادخل جميع البيانات", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("كلمة السر غير متطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnSave.Text == "حفظ المستخدم")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.ADD_USER(txtID.Text, txtFullName.Text, txtPWD.Text,
                    cmbType.Text);
                MessageBox.Show("تم إضافة المستخدم بنجاح", "إضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (btnSave.Text == "تعديل المستخدم")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.EDIT_USER(txtID.Text, txtFullName.Text, txtPWD.Text,
                    cmbType.Text);
                MessageBox.Show("تم التعديل المستخدم بنجاح", "تعديل مستخدم ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            txtID.Clear();
            txtFullName.Clear();
            txtPWD.Clear();
            txtPWDConfirm.Clear();
            txtID.Focus();  //من اجل انشاء مستخدم جديد
        }
    }
    
}
