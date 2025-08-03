using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class InvoiceManager
    {

        private string _connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");
        // إضافة فاتورة جديدة




        public InvoiceManager()
        {
           
        }

        // 1. إجراءات المنتجات
        public DataTable sp_GetAvailableProducts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAvailableProducts", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }

    
        public int GetProductStock(string ID_PRODUCT)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT QTE_IN_STOOK FROM PRODUCT WHERE ID_PRODUCT = @ID_PRODUCT";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_PRODUCT", ID_PRODUCT);
                object result = command.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }
       
        public bool UpdateProductStock(string productId, int quantityChange)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateProductStock", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@QuantityChange", quantityChange);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // 2. إجراءات المبيعات
        public int CreateNewSale(DateTime saleDate, decimal totalAmount, string paymentMethod)
        {
            int saleId = 0;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CreateNewSale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleDate", saleDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                    SqlParameter outputParam = new SqlParameter("@SaleID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    if (outputParam.Value != DBNull.Value)
                    {
                        saleId = Convert.ToInt32(outputParam.Value);
                    }
                }
            }
            return saleId;
        }

        public bool sp_AddRetailSale( string ID_PRODUCT, string productName,
                              int quantity, decimal unitPrice, decimal TotalAmount, string PaymentMethod)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddRetailSale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
               
                    cmd.Parameters.AddWithValue("@ID_PRODUCT", ID_PRODUCT);
                    cmd.Parameters.AddWithValue("@LABEL_PRODUCT", productName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public DataTable GetSaleDetails(int saleId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetSaleDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleID", saleId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }

        // 3. إجراءات التقارير
        public DataTable GetDailySalesReport(DateTime date)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetDailySalesReport", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Date", date.Date);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }
        public DataTable Get_all_RetailSales()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_all_RetailSales", null);
            DAL.Close();
            return Dt;
        }
        public DataTable GetTopSellingProducts(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetTopSellingProducts", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                    cmd.Parameters.AddWithValue("@EndDate", endDate.Date);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }


        public DataTable sp_GetLastSaleDetails()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("sp_GetLastSaleDetails", null);  // ينفذ الإجراء المخزن
            DAL.Close();
            return Dt;
        }


        public DataTable sp_GetSaleDetailByID(int saleID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SaleID", SqlDbType.Int);
            param[0].Value = saleID;

            DataTable Dt = DAL.SelectData("sp_GetSaleDetailByID", param);
            DAL.Close();
            return Dt;
        }

        public DataTable GetAllSaleIDs()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = DAL.SelectData("SELECT SaleID FROM RetailSales",null);
            DAL.Close();
            return Dt;
        }
    }
}
