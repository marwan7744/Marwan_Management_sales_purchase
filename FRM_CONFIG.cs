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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //هذا الكود يقوم با تخزين المعلومات المدخله في الفورم في الاعدادات السيتنج الخاصه با المشروع
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Mode =rbSql.Checked==true? "SQL" : "Windows";    //: mean is
            Properties.Settings.Default.ID= txtID.Text;
            Properties.Settings.Default.PWD = txtPWD.Text;
            Properties.Settings.Default.Save();//حفظ القيم واعتمادها كاقيم جديدة وحفطها في السيتنج 

        }

        private void txtServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtDatabase.Focus();
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
