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
    public partial class FRM_ADD_CATEGORIEScs : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;  // دورها يقوم با إدارة الادوات المرتبطه مع البيانات المرتبطه با قاعدة البيانات
                                 // CurrencyManager cm;//نفس العمل
        SqlCommandBuilder cmdb;   //للاضافه والحذف والتعديل
        
        public FRM_ADD_CATEGORIEScs()
        {
            InitializeComponent();
            dgList.ForeColor = Color.Black;

            da = new SqlDataAdapter("select id_cus as 'المعرف',DESCRIPTION_CUS as'الصنف' from categories", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "المعرف");
            txtDes.DataBindings.Add("text", dt, "الصنف");
            bmb = this.BindingContext[dt];//bmb=this تسمى الفورم الحالي
            lblPosition.Text = (bmb.Position+1 + " / " + bmb.Count);
        }

        private void FRM_ADD_CATEGORIEScs_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bmb.EndCurrentEdit();  //هذه العمليه سوف نستخدمها للاضافه والحذف والتعديل

                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تم الإضافة بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAdd.Enabled = false;//يتم الغاء زر الاضافة 
                btnClose.Enabled = true; //و يفعل الجديد
                lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count); // يجب إضهار البوزشين لكي يتم تحديد العنصر ورتبت العناصر عند كل عمليت إضافه او حذف

                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearData()
        {
            txtDes.Clear();
            txtID.Clear();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1 + " / " + bmb.Count);
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            try
            {
                bmb.AddNew(); //AddNew() تعني التفريغ ويدخل بينات جديده
                btnNew.Enabled =false;
                btnAdd.Enabled =true;
                int id = Convert.ToInt32(dt.Rows[dt.Rows.Count- 1][0])+1;
                txtID.Text = id.ToString();
                txtDes.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
