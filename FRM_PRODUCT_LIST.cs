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
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();

        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_PRODUCT_LIST_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();  //يستقبل البيانات القادمه
            dt = prd.Search(txtSearch.Text);//البحث عن القيمه  في قائمة تكسبوكس
            this.dataGridView1.DataSource = dt;//إضهار النتيجه
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();  //يستقبل البيانات القادمه
            dt = prd.Search(txtSearch.Text);//البحث عن القيمه  في قائمة تكسبوكس
            this.dataGridView1.DataSource = dt;//إضهار النتيجه
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
