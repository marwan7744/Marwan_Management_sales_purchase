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
    public partial class FRM_SUPPLIERS_LIST : Form
    {
        BL.CLS_TB_SUPPLIER supplier =new BL.CLS_TB_SUPPLIER();
        public FRM_SUPPLIERS_LIST()
        {
            InitializeComponent();
            this.datSUPPLIER.DataSource = supplier.GET_ALL_Supplier();//يقوم بجلب كل الموردين
            //this.datSUPPLIER.Columns[0].Visible = false;
            //this.datSUPPLIER.Columns[5].Visible = false;
        }
        private void datSUPPLIER_DoubleClick(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
