using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;


namespace MANGEMENT.BL
{
    internal class CLS_ORDERS
    {
        private string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");


        public DataTable GET_LAST_ORDER_ID()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {

           DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return Dt;
        }
        public DataTable GET_LAST_ORDER_ID_FOR_PRINT()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_ID_FOR_PRINT", null);
            DAL.Close();
            return Dt;
        }
        //إضافة فاتورة المبيعات
        public void ADD_ORDER(int ID_ORDER, DateTime DATE_ORDER, int CUSTOMER_ID,
                       string DESCRIPTION_ORDER, string SALEMAN,
                       string PAYMENT_TYPE, bool IS_SUSPENDED)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[2].Value = CUSTOMER_ID;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar, 250);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@SALEMAN", SqlDbType.VarChar, 75);
            param[4].Value = SALEMAN;

            param[5] = new SqlParameter("@PaymentType", SqlDbType.NVarChar, 50);
            param[5].Value = PAYMENT_TYPE;

            param[6] = new SqlParameter("@IsSuspended", SqlDbType.Bit);
            param[6].Value = IS_SUSPENDED;

            DAL.ExecuteCommand("ADD_ORDER", param);
            DAL.Close();
        }

        //إضافة تفاصيل فاتورة المبيعات
        public void ADD_ORDER_DETAILS(string ID_PRODUCT, int ID_ORDER, string MEID, int QTE,
        string PRICE, double DISCOUNT, string AMOUNT, string TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@MEID", SqlDbType.VarChar, 50);
            param[2].Value = MEID;

            param[3] = new SqlParameter("@QTE ", SqlDbType.Int);
            param[3].Value = QTE;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = PRICE;

            param[5] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[5].Value = DISCOUNT;

            param[6] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[6].Value = AMOUNT;
            param[7] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            param[7].Value = TOTAL_AMOUNT;

            DAL.ExecuteCommand("ADD_ORDER_DETAILS", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }

        public DataTable verifyQte(string ID_PRODUCT, int Qty_Entered)   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            //قم بانشاء كان من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //قم الإعلان عن الباراميتر
            // DAL.Open();    //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();//إنشاء باروميتر لان إجراء المخزن يستقبل باروميتر
            SqlParameter[] Param = new SqlParameter[2]; /// لدينا با روميتر واحد بس 
            Param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);//إسم الباروميتر 
            Param[0].Value = ID_PRODUCT; ////ID_PRODUCT القيمه التي يرسلها إلى 
            Param[1] = new SqlParameter("@Qty_Entered", SqlDbType.Int);//إسم الباروميتر 
            Param[1].Value = Qty_Entered; //// Qty_Entered القيمه التي يرسلها إلى 

            Dt = DAL.SelectData("verifyQte", Param);//
            DAL.Close();//
            return Dt;//
        }
   

        public DataTable GetOrderDetails(int orderId)
        {
            DataTable orderDetails = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {try
                {
                    SqlCommand command = new SqlCommand("GetOrderDetails",connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_ORDER", orderId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(orderDetails);
                }
                catch (Exception ex)
                {
                    // يمكنك تسجيل الخطأ هنا أو معالجته حسب الحاجة
                    throw new Exception("حدث خطأ أثناء جلب تفاصيل الفاتورة: " + ex.Message);
                }
            }
            return orderDetails;
        }

        public DataTable SearchOrders(string Criterion)
        {
            //قم بانشاء كان من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //قم الإعلان عن الباراميتر
            // DAL.Open();    //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();//إنشاء باروميتر لان إجراء المخزن يستقبل باروميتر
            SqlParameter[] Param = new SqlParameter[1]; /// لدينا با روميتر واحد بس 
            Param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);//إسم الباروميتر 
            Param[0].Value = Criterion; ////Criterion القيمه التي يرسلها إلى 

            Dt = DAL.SelectData("SearchOrders", Param);//
            DAL.Close();//
            return Dt;//
        }
       //public void ProcessSale(DateTime dateOrder, int customerId, string descriptionOrder,
       //     string salesman, string productId, int Qte, string price, double discount, 
       //     string totalAmount)
       // {
       //     DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
       //     DAL.Open();
       //     SqlParameter[] param = new SqlParameter[9];
       //     param[0] = new SqlParameter("@DATE_ORDER", dateOrder);
       //     param[1] = new SqlParameter("@CUSTOMER_ID", customerId);
       //     param[2] = new SqlParameter("@DESCRIPTION_ORDER", descriptionOrder);
       //     param[3] = new SqlParameter("@SALEMAN", salesman);
       //     param[4] = new SqlParameter("@ID_PRODUCT", productId);
       //     param[5] = new SqlParameter("@QTE", Qte);
       //     param[6] = new SqlParameter("@PRICE", price);
       //     param[7] = new SqlParameter("@DISCOUNT", discount);
       //     param[8] = new SqlParameter("@TOTAL_AMOUNT", totalAmount);
       //     DAL.ExecuteCommand("PROCESS_SALE", param);
       //     DAL.Close();
       // } 


        // إضافة هذه الدوال إلى كلاس CLS_ORDERS
        public DataTable GetOrderHeader(int orderId)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", orderId);
            dt = DAL.SelectData("GetOrderHeader", param);
            DAL.Close();
            return dt;
        }

        public void UpdateOrderDetails(string ID_PRODUCT, int ID_ORDER, string MEID, int QTE, string PRICE,
                                     double DISCOUNT, string AMOUNT ,string TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_PRODUCT", ID_PRODUCT);
            param[1] = new SqlParameter("@ID_ORDER", ID_ORDER);
            param[2] = new SqlParameter("@MEID", MEID);
            param[3] = new SqlParameter("@QTE", QTE);
            param[4] = new SqlParameter("@PRICE", PRICE);
            param[4] = new SqlParameter("@AMOUNT", AMOUNT);
            param[5] = new SqlParameter("@DISCOUNT", DISCOUNT);
            param[6] = new SqlParameter("@TOTAL_AMOUNT", TOTAL_AMOUNT);

            DAL.ExecuteCommand("UpdateOrderDetails", param);
            DAL.Close();
        }


        //public void Add_JournalEntry(DateTime entryDate, int accountId, string accountType,
        //                      string descriptions, decimal debit, decimal credit,
        //                      string refType, int refId)
        //{
        //    DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        //    dal.Open();

        //    SqlParameter[] param = new SqlParameter[8];
        //    param[0] = new SqlParameter("@EntryDate", entryDate);
        //    param[1] = new SqlParameter("@AccountID", accountId);
        //    param[2] = new SqlParameter("@AccountType", accountType);
        //    param[3] = new SqlParameter("@Descriptions", descriptions);
        //    param[4] = new SqlParameter("@Debit", debit);
        //    param[5] = new SqlParameter("@Credit", credit);
        //    param[6] = new SqlParameter("@RefType", refType);
        //    param[7] = new SqlParameter("@RefID", refId);

        //    dal.ExecuteCommand("Add_JournalEntry", param);
        //    dal.Close();
        //}


        public void UPDATE_ORDER_DETAILS(string ID_PRODUCT, int ID_ORDER, int QTE,
            string PRICE, double DISCOUNT, string AMOUNT, string TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", ID_PRODUCT);
            param[1] = new SqlParameter("@ID_ORDER", ID_ORDER);
            param[2] = new SqlParameter("@QTE", QTE);
            param[3] = new SqlParameter("@PRICE", PRICE);
            param[4] = new SqlParameter("@DISCOUNT", DISCOUNT);
            param[5] = new SqlParameter("@AMOUNT", AMOUNT);
            param[6] = new SqlParameter("@TOTAL_AMOUNT", TOTAL_AMOUNT);
            DAL.ExecuteCommand("UPDATE_ORDER_DETAILS", param);
            DAL.Close();
        }

     

        //internal DataTable GET_CUSTOMER_DATA(int customerId)
        //{
        //    throw new NotImplementedException();
        //}
        internal DataTable GetAllCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT  ID_CUSTOMER,FIRST_NAME,LAST_NAME,TEL,EMAI FROM CUSTOMERS";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        /////////////////////////

        public DataTable GetOrderForEdit(int orderID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            Param[0].Value = orderID;

            Dt = DAL.SelectData("GetOrderDetails", Param);
            DAL.Close();
            return Dt;
        }
        
     public void UPDATE_ORDER(int ID_ORDER, DateTime DATE_ORDER, int CUSTOMER_ID,
               string DESCRIPTION_ORDER,string SALEMAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[2].Value = CUSTOMER_ID;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar, 250);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@SALEMAN", SqlDbType.VarChar, 75);
            param[4].Value = SALEMAN;

            DAL.ExecuteCommand("UPDATE_ORDER", param);
            DAL.Close();
        }
        public void UPDATE_ORDER_DETAILS(string ID_PRODUCT, int ID_ORDER, string MEID, int QTE,
            string PRICE, double DISCOUNT, string AMOUNT, string TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@MEID", SqlDbType.VarChar, 50);
            param[2].Value = MEID;

            param[3] = new SqlParameter("@QTE", SqlDbType.Int);
            param[3].Value = QTE;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = PRICE;

            param[5] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[5].Value = DISCOUNT;

            param[6] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[6].Value = AMOUNT;

            param[7] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            param[7].Value = TOTAL_AMOUNT;

            DAL.ExecuteCommand("UPDATE_ORDER_DETAILS", param);
            DAL.Close();
        }
        public void DeleteOrderDetails(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            DAL.ExecuteCommand("DELETE_ORDER_DETAILS", param);
            DAL.Close();
        }
    }
}


