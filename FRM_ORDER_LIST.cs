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
    public partial class FRM_ORDER_LIST : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        
        public FRM_ORDER_LIST()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.DataSource = order.SearchOrders("");
        }

        private void FRM_ORDER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = order.SearchOrders(txtSearch.Text);
            }
            catch
            {
                return;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor; //LOAD    يتحول إلى علامات التحميل
                int order_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);//هذا رقم الفاتوره
                                                                                        // هذا الامر يقوم بجلب اخر فاتوره
                Convert.ToInt32(order.GET_LAST_ORDER_ID_FOR_PRINT().Rows[0][0]);
                RPT.rpt_ordersrpt report = new RPT.rpt_ordersrpt();
                RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
                report.SetDataSource(order.GetOrderDetails(order_ID));
                frm.crystalReportViewer1.ReportSource = report;
                frm.ShowDialog();
                this.Cursor = Cursors.Default; //LOAD  


            }
            catch (Exception ex)
            {
MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FRM_EDIT_ORDER frm= new FRM_EDIT_ORDER();
         //   frm.ShowDialog();
            //this.Cursor = Cursors.WaitCursor; //LOAD    يتحول إلى علامات التحميل
            //int order_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);//هذا رقم الفاتوره


        }

        private void FRM_ORDER_LIST_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // هذه السطر الوحيد المطلوب لتحريك الفورم عند السحب
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);

            }
        }
    }
}
