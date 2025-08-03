using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANGEMENT.BL
{
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS(); //
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            this.datCUSTOMER.DataSource = cust.GET_ALL_CUSTOMERS();//يقوم بجلب كل العملاء
            this.datCUSTOMER.Columns[0].Visible = false;
            this.datCUSTOMER.Columns[5].Visible = false;

        }

        

        private void datCUSTOMER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datCUSTOMER_DoubleClick(object sender, EventArgs e)
        {
            this.Close(); //  هنا سيتم  الإغلاق وعند الإغلاق سيتم اخذ القيم المحداده في السطر المحداد وعرضها في الادوات
        }
    }
}
