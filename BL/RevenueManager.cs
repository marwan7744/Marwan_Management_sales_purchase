using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    public class RevenueManager
    {
        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";

        // إضافة إيراد جديد
        //public void AddRevenue(DateTime revenueDate, string description, decimal amount, int ID_CUSTOMER, int ID_CUS, string notes)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "INSERT INTO Revenues (RevenueDate, RevenueDescription, Amount, ID_CUSTOMER, ID_CUS, Notes) VALUES (@RevenueDate, @Description, @Amount, @ID_CUSTOMER, @ID_CUS, @Notes)";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@RevenueDate", revenueDate);
        //        command.Parameters.AddWithValue("@Description", description);
        //        command.Parameters.AddWithValue("@Amount", amount);
        //        command.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
        //        command.Parameters.AddWithValue("@ID_CUS", ID_CUS);
        //        command.Parameters.AddWithValue("@Notes", notes);
        //        command.ExecuteNonQuery();
        //    }
        //}




        public void AddRevenue(DateTime revenueDate, string description, decimal amount, int ID_CUSTOMER, string notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@RevenueDate", SqlDbType.DateTime);
            param[0].Value = revenueDate;

            param[1] = new SqlParameter("@RevenueDescription", SqlDbType.NVarChar, 255);
            param[1].Value = description;

            param[2] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[2].Value = amount;

            param[3] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[3].Value = ID_CUSTOMER;

            //param[4] = new SqlParameter("@ID_CUS", SqlDbType.Int);
            //param[4].Value = ID_CUS;

            param[4] = new SqlParameter("@Notes", SqlDbType.NVarChar,100);
            param[4].Value = notes;

            DAL.ExecuteCommand("AddRevenue", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }

        public void UPDATE_Revenues(int RevenueID,DateTime revenueDate, string description, decimal amount, int ID_CUSTOMER,string notes)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@RevenueID", SqlDbType.Int);
            param[0].Value = RevenueID;

            param[1] = new SqlParameter("@RevenueDate", SqlDbType.DateTime);
            param[1].Value = revenueDate;

            param[2] = new SqlParameter("@RevenueDescription", SqlDbType.NVarChar, 255);
            param[2].Value = description;

            param[3] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[3].Value = amount;

            param[4] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[4].Value = ID_CUSTOMER;

            //param[5] = new SqlParameter("@ID_CUS", SqlDbType.Int);
            //param[5].Value = ID_CUS;

            param[5] = new SqlParameter("@Notes", SqlDbType.NVarChar, 100);
            param[5].Value = notes;

            
            DAL.ExecuteCommand("UPDATE_Revenues", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }


        // جلب الإيرادات مع بيانات العملاء والأصناف
        public DataTable GetAllRevenuesWithCustomersAndItems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT R.RevenueID, R.RevenueDate, R.RevenueDescription, R.Amount, C.FIRST_NAME,R.Notes
            FROM Revenues R
            INNER JOIN CUSTOMERS C ON R.ID_CUSTOMER = C.ID_CUSTOMER";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // جلب جميع الإيرادات
        public DataTable GetAllRevenues()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Revenues";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // حذف إيراد
        public void DeleteRevenue(int revenueID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Revenues WHERE RevenueID = @RevenueID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RevenueID", revenueID);
                command.ExecuteNonQuery();
            }
        }
      
        /// ///////////////////////////////////////////////////////////////////
    
        public DataTable Get_single_RevenuesWithCustomer(int RevenueID)
        {
            try
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@RevenueID", RevenueID);
                //  param[0] = new SqlParameter("@ExpenseDate", ExpenseDate);


                return DAL.SelectData("Get_single_RevenuesWithCustomer", param);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get session returns: " + ex.Message);
            }
            finally
            {
                //  DAL.Close();
            }
        }
    }
}