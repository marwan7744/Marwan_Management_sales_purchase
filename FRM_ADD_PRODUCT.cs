using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MANGEMENT.PL
{
    public partial class FRM_ADD_PRODUCT : Form

    {
        public string state = "add";      // نعلن عن متغير عام ونوعه سترينج و قيمته ااد
    
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
           cmbCUS.DataSource = prd.GET_ALL_CATEGORIES();// categories تعني هنا المنتوجات وليس الاصناف
           cmbCUS.DisplayMember = "FIRST_NAME";
            cmbCUS.ValueMember = "DESCRIPTION_CUS";
            cmbCUS.ValueMember = "ID_CUS";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenFileDialog عملها تمكننا من فتح الملفات
                //ل دينا حالاتان الإضافة والتعديل
                OpenFileDialog ofd = new OpenFileDialog();   
            ofd.Filter = "ملفات الصور|*JPG; *.PNG; *GIF; *.BMP";   //تحديد انواع الصور التي نريدها

            if (ofd.ShowDialog() == DialogResult.OK)    //هنا إضهار النتيجه ويقوم المستخدم بضغط على اوكه
            {
                pbox.Image = Image.FromFile(ofd.FileName);//إضهار الصوره

            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")  //الإضافة
                {
                    MemoryStream ms = new MemoryStream();    //MemoryStream   يستخدم فقط في عمليات الوراثه هو كلاس مشتقه من الكلاس الريسي المسما ستريم
                    pbox.Image.Save(ms, pbox.Image.RawFormat);   //rawformat تعيد لنا نوع الصوره
                    byte[] byteImage = ms.ToArray();          //تحويل الصوره إلى بيانات ثنائية //ToArray تمكن من تخزين محتوى ستريم في مصفوفات
                    prd.ADD_PRODUCT(Convert.ToInt32(cmbCUS.SelectedValue), txtDes.Text, txtRef.Text,
                    Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);
                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else   //التعديل
                {
                    MemoryStream ms = new MemoryStream();                    //MemoryStream   يستخدم فقط في عمليات الوراثه هو كلاس مشتقه من الكلاس الريسي المسما ستريم
                    pbox.Image.Save(ms, pbox.Image.RawFormat);             //rawformat تعيد لنا نوع الصوره
                    byte[] byteImage = ms.ToArray();                          //تحويل الصوره إلى بيانات ثنائية //ToArray تمكن من تخزين محتوى ستريم في مصفوفات
                    prd.UPDATE_PRODUCT(Convert.ToInt32(cmbCUS.SelectedValue), txtDes.Text, txtRef.Text,
                   Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);
                    MessageBox.Show(" تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //هذا الامر يجعل عند الضغط على إضافه او تعديل  يضيف الناتج الجديد بنفس الوقت
                FRM_PRODUCTScs.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCT(); // يقوم با جلب كل المنتوجات بما في المنتوج الذي تم إضافته او تعديله
                                                                                             //
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
        private void txtRef_Validated(object sender, EventArgs e)
        {
            try { 
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.VerifyProductID(txtRef.Text);
                if (Dt.Rows.Count > 0)    //إذا كان اكبر من الصفر فان النص موجود مسبقا بيانات 
                {
                    MessageBox.Show("هذا المعرف  موجودمسبقا", "تنبيه,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.TextLength;
                }
            }
        }
         catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQte.Focus();
            }
        }
        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter )
            {
                txtPrice.Focus();
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

