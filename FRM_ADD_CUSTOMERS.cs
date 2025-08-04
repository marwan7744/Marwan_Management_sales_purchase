using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.PL
{
    public partial class FRM_ADD_CUSTOMERS : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int ID, Postion;
        public string state = "add";      // نعلن عن متغير عام ونوعه سترينج و قيمته ااد

        public FRM_ADD_CUSTOMERS()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS(); //يتم عرض كل العملاء في الداتا جريدفيو

            // DateT.BackColor=Color.FromArgb(255,255,255,50);
            //  dataGridView1.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FRM_ADD_CUSTOMERS_Load(object sender, EventArgs e)
        {
            txtFirstName.ReadOnly = true;
            txtFirstName.Text="";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            txtFirstName.ReadOnly = false;
            txtFirstName.Text="";
            txtLastName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtDebit.Clear();
            pbox.Image = null;
            txtFirstName.Focus();  //الموشر
            btnAdd.Enabled = true;   //هذا مفعل
            btnNew.Enabled = false;//إذا هذا غير مفعل

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pbox.Image = null; // تقوم باتغير الصورة
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                this.txtFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.txtDebit.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
                byte[] Picture = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);

            }
            catch
            {
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] Picture;
                if (pbox.Image == null)
                {
                    // decimal.Parse(txtDebit.Text),//
                    Picture = new byte[0]; //في حال لم نريد الصوره
                    cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, Picture, "without_image");
                    MessageBox.Show("تم الاضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    //مصفوفه من البينات الثنائيه
                    Picture = ms.ToArray();
                    //decimal.Parse(txtDebit.Text),//
                    cust.ADD_CUSTOMER(txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, Picture, "with_image");
                    MessageBox.Show("تم الاضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMERS();
                }
            }
            catch
            {
                return;
            }
            finally
            {
                btnAdd.Enabled = false;  //إذا هذا غير مفعل
                btnNew.Enabled = true;// هذا مفعل
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Postion == 0)
            {
                MessageBox.Show("هذا اول عنصر");
                return;
            }
            Postion -= 1;
            Navigate(Postion);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Postion == cust.GET_ALL_CUSTOMERS().Rows.Count - 1)
            {
                MessageBox.Show("هذا اخر عنصر");
                return;
            }
            Postion += 1;
            Navigate(Postion);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Postion = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;

            Navigate(Postion);
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtFirstName_KeyDown(sender, e);
                txtLastName.Focus();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtFirstName_KeyDown(sender, e);
                txtTel.Focus();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtEmail.Focus();
            }
        }

        private void DateT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                // txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DateT.Focus();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.SEARCH_CUSTOMER(txtSearch1.Text);

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLastName.Focus();
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTel.Focus();
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DateT.Focus();
                e.Handled = true;
            }
        }

        private void DateT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd.Focus();
                e.Handled = true;
            }
        }

        private void txtTel_Validated(object sender, EventArgs e)
        {
            try
            {

                DataTable Dt = new DataTable();
                Dt = cust.VerifyID_CUSTOMER(txtTel.Text);
                if (Dt.Rows.Count > 0)    //إذا كان اكبر من الصفر فان النص موجود مسبقا بيانات 
                {
                    MessageBox.Show("هذا المعرف  موجودمسبقا", "تنبيه,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //  txtTel.Focus();
                    txtTel.SelectionStart = 0;
                    txtTel.SelectionLength = txtTel.TextLength;

                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            try
            {

                DataTable Dt = new DataTable();
                Dt = cust.VerifyID_CUSTOMER(txtTel.Text);
                if (Dt.Rows.Count > 0)    //إذا كان اكبر من الصفر فان النص موجود مسبقا بيانات 
                {
                    MessageBox.Show("هذا المعرف  موجودمسبقا", "تنبيه,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //  txtTel.Focus();
                    txtTel.SelectionStart = 0;
                    txtTel.SelectionLength = txtTel.TextLength;

                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    
        void Navigate(int Index)
        {
            try
            {


                pbox.Image = null;

                DataRowCollection DRC = cust.GET_ALL_CUSTOMERS().Rows;
                ID =Convert.ToInt32(DRC[Index][0]);  //يجعل الصوره تضهر بعد التعديل 
                txtFirstName.Text = DRC[Index][1].ToString();
                txtLastName.Text = DRC[Index][2].ToString();
                txtTel.Text = DRC[Index][3].ToString();
                txtEmail.Text = DRC[Index][4].ToString();
                txtDebit.Text = DRC[Index][5].ToString();
                byte[] Picture = (byte[])DRC[Index][5];   //try
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }
    }
}
