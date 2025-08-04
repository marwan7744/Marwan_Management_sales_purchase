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
    public partial class Add_Supplier : Form
    {

        BL.CLS_TB_SUPPLIER cust = new BL.CLS_TB_SUPPLIER();
        int ID, Postion;
        public Add_Supplier()
        {
            InitializeComponent();
           // DateT.BackColor=Color.FromArgb(255, 255, 255, 50);
            dataGridView11.ForeColor = Color.Black;


        }


        void Navigate(int Index)
        {
            try
            {
                pbox1.Image = null;
                DataRowCollection DRC = cust.GET_ALL_Supplier().Rows;
                ID = Convert.ToInt32(DRC[Index][0]);  //يجعل الصوره تضهر بعد التعديل 
                txtFullName.Text = DRC[Index][1].ToString();
                txtPhone.Text = DRC[Index][2].ToString();
                txtAddress.Text = DRC[Index][3].ToString();
                byte[] Picture = (byte[])DRC[Index][4];   //try
                MemoryStream ms = new MemoryStream(Picture);
                pbox1.Image = Image.FromStream(ms);
                txtDebit.Text= DRC[Index][3].ToString();
            }
            catch
            {
                return;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFullName.ReadOnly = false;
            txtFullName.Text="";
          //  txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtDebit.Clear();

            pbox1.Image = null;
            txtFullName.Focus();  //الموشر
            btnAdd2.Enabled = true;   //هذا مفعل
            btnNew.Enabled = false;
        }

        private void btnFirst2_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            if (Postion == 0)
            {
                MessageBox.Show("هذا اول عنصر");
                return;
            }
            Postion -= 1;
            Navigate(Postion);
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (Postion == cust.GET_ALL_Supplier().Rows.Count - 1)
            {
                MessageBox.Show("هذا اخر عنصر");
                return;
            }
            Postion += 1;
            Navigate(Postion);
        }

        private void btnLast2_Click(object sender, EventArgs e)
        {

            Postion = cust.GET_ALL_Supplier().Rows.Count - 1;

            Navigate(Postion);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
                e.Handled = false;
                
            }

            //if (e.KeyCode == Keys.Enter)
            //{
            //    //txtFirstName_KeyDown(sender, e);
            //    txtPhone.Focus();
            //}
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
                e.Handled = true;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DateT.Focus();
                e.Handled = true;
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            dataGridView11.DataSource = cust.SEARCH_Suppliers(txtSearch11.Text);

        }

        private void Add_Supplier_Load(object sender, EventArgs e)
        {
            txtFullName.ReadOnly = true;
            txtFullName.Text="";
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPhone.Focus();
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtAddress.Focus();
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
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
                btnAdd2.Focus();
                e.Handled = true;
            }
        }

        private void Add_Supplier_Shown(object sender, EventArgs e)
        {
            txtFullName.Focus();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] Picture;
                if (pbox1.Image == null)
                {
                    Picture = new byte[0]; //في حال لم نريد الصوره

                    cust.ADD_Supplier(txtFullName.Text, txtPhone.Text, txtAddress.Text, Picture, "without_image");


                    MessageBox.Show("تم الاضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView11.DataSource = cust.GET_ALL_Supplier();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox1.Image.Save(ms, pbox1.Image.RawFormat);
                    //مصفوفه من البينات الثنائيه
                    Picture = ms.ToArray();

                    cust.ADD_Supplier(txtFullName.Text, txtPhone.Text, txtAddress.Text, Picture, "without_image");
                    MessageBox.Show("تم الاضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView11.DataSource = cust.GET_ALL_Supplier();

                }
            }
            catch
            {
                return;
            }
            finally
            {
                btnAdd2.Enabled = false;  //إذا هذا غير مفعل
                btnNew.Enabled = true;// هذا مفعل
            }
        }
    }
}
