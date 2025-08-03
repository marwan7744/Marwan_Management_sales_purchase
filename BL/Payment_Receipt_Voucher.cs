using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class Payment_Receipt_Voucher
    {
        
        public int Add_ReceiptVouchers( DateTime DateReceipt, int Customer_id,
         string Amount,string Descriptions, string FIRST_NAME, string LAST_NAME,string Currency)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@DateReceipt", SqlDbType.DateTime);
            param[0].Value = DateReceipt;

            param[1] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[1].Value = Customer_id;

            param[2] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            param[2].Value = Amount;

            param[3] = new SqlParameter("@Descriptions", SqlDbType.VarChar, 255);
            param[3].Value = Descriptions;
            param[4] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 50);
            param[4].Value = FIRST_NAME;
            param[5] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 50);
            param[5].Value = LAST_NAME;
            param[6] = new SqlParameter("@Currency", SqlDbType.VarChar, 50);
            param[6].Value = Currency;
            param[7] = new SqlParameter("@NewID", SqlDbType.Int);
            param[7].Direction =ParameterDirection.Output; ///
           
            DAL.ExecuteCommand("Add_ReceiptVouchers", param);   // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();

             return
            Convert.ToInt32(param[7].Value);
        }



        public int Add_PaymentVouchers(DateTime DatePayment, int Supplier_id,
       decimal Amount, string Currency, string Descriptions, string Full_Name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@DatePayment", SqlDbType.DateTime);
            param[0].Value = DatePayment;

            param[1] = new SqlParameter("@ID", SqlDbType.Int);
            param[1].Value = Supplier_id;

            param[2] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[2].Value = Amount;

            param[3] = new SqlParameter("@Currency", SqlDbType.VarChar, 50);
            param[3].Value = Currency;

            param[4] = new SqlParameter("@Descriptions", SqlDbType.VarChar, 255);
            param[4].Value = Descriptions;

            param[5] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[5].Value = Full_Name;
          
            //param[6] = new SqlParameter("@NewID", SqlDbType.Int);
            //param[6].Direction =ParameterDirection.Output; ///

            DAL.ExecuteCommand("Add_PaymentVouchers", param);   // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();

            return
           Convert.ToInt32(param[1].Value);
        }

        public DataTable Get_PaymentVoucher_By_ID(int PaymentID) ///////////////////////////
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PaymentID", SqlDbType.Int);
            param[0].Value = PaymentID;

            DataTable dt = dal.SelectData("Get_PaymentVoucher_By_ID", param);

            dal.Close();
            return dt;
        }
        public DataTable GetReceiptVoucherByID(int receiptID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ReceiptID", SqlDbType.Int);
            param[0].Value = receiptID;

            DataTable dt = dal.SelectData("Get_ReceiptVoucher_By_ID", param);

            dal.Close();
            return dt;
        }


        public DataTable GET_LAST_Receipt_ID_FOR_PRINT()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_Receipt_ID_FOR_PRINT", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_LAST_PaymentVouchers_ID_FOR_PRINT()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_PaymentVouchers_ID_FOR_PRINT", null);
            DAL.Close();
            return Dt;
        }


        public DataTable SearchReceipt(string ID)
        {
            //قم بانشاء كائن من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //قم الإعلان عن الباراميتر
            // DAL.Open();    //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();//إنشاء باروميتر لان إجراء المخزن يستقبل باروميتر
            SqlParameter[] Param = new SqlParameter[1]; /// لدينا با روميتر واحد بس 
       
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);//إسم الباروميتر 
            Param[0].Value = ID; ////القيمه التي يرسلها إلى 
//القيمه التي يرسلها إلى 

            Dt = DAL.SelectData("SearchReceipt", Param);//
            DAL.Close();//
            return Dt;//
        }


        public DataTable SearchPaymentVouchers(string ID)
        {
            //قم بانشاء كائن من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //قم الإعلان عن الباراميتر
            // DAL.Open();    //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();//إنشاء باروميتر لان إجراء المخزن يستقبل باروميتر
            SqlParameter[] Param = new SqlParameter[1]; /// لدينا با روميتر واحد بس 

            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);//إسم الباروميتر 
            Param[0].Value = ID; ////القيمه التي يرسلها إلى 
                                 //القيمه التي يرسلها إلى 

            Dt = DAL.SelectData("SearchPaymentVouchers", Param);//
            DAL.Close();//
            return Dt;//
        }

        public void DELETE_Receipt(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.ExecuteCommand("DELETE_Receipt", param);
            DAL.Close();
        }

        public void DELETE_PaymentVouchers(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.ExecuteCommand("DELETE_PaymentVouchers", param);
            DAL.Close();
        }

        public DataTable GET_ALL_Receipt()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Receipt", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_ALL_PaymentVouchers()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PaymentVouchers", null);
            DAL.Close();
            return Dt;
        }
    }
}
