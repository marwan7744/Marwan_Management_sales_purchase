using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    public class DebtManagerPy
    {
        private string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");
        // خصم المبلغ من ديون العميل
        public void PayDebt(int ID_CUSTOMER, decimal paymentAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // خصم المبلغ من إجمالي الديون في جدول العملاء
                string updateTotalDebtQuery = "UPDATE CUSTOMERS SET Debits = Debits - @PaymentAmount WHERE ID_CUSTOMER = @ID_CUSTOMER";
                SqlCommand updateTotalDebtCommand = new SqlCommand(updateTotalDebtQuery, connection);
                updateTotalDebtCommand.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                updateTotalDebtCommand.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
                updateTotalDebtCommand.ExecuteNonQuery();

                // إضافة سجل الدفع في جدول الديون (اختياري)
                string insertPaymentQuery = "INSERT INTO Debt (ID_CUSTOMER, Debit) VALUES (@ID_CUSTOMER, -@PaymentAmount)";
                SqlCommand insertPaymentCommand = new SqlCommand(insertPaymentQuery, connection);
                insertPaymentCommand.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
                insertPaymentCommand.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
                insertPaymentCommand.ExecuteNonQuery();
            }
        }

        public DataTable GetAllDebts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DebtID, ID_CUSTOMER, Debit,DateT FROM Debt";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // جلب إجمالي ديون العميل
        public decimal GetTotalDebt(int ID_CUSTOMER)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Debits FROM CUSTOMERS WHERE ID_CUSTOMER = @ID_CUSTOMER";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }
    }
}
//public class DebtManager
//{
//    private string connectionString = "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;";

//    // خصم المبلغ من ديون العميل
//    public void PayDebt(int ID_CUSTOMER, decimal paymentAmount)
//    {
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            connection.Open();

//            // خصم المبلغ من إجمالي الديون في جدول العملاء
//            string updateTotalDebtQuery = "UPDATE CUSTOMERS SET Debits = Debits - @PaymentAmount WHERE ID_CUSTOMER = @ID_CUSTOMER";
//            SqlCommand updateTotalDebtCommand = new SqlCommand(updateTotalDebtQuery, connection);
//            updateTotalDebtCommand.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
//            updateTotalDebtCommand.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
//            updateTotalDebtCommand.ExecuteNonQuery();

//            // إضافة سجل الدفع في جدول الديون (اختياري)
//            string insertPaymentQuery = "INSERT INTO Debt (ID_CUSTOMER, Debit) VALUES (@ID_CUSTOMER, -@PaymentAmount)";
//            SqlCommand insertPaymentCommand = new SqlCommand(insertPaymentQuery, connection);
//            insertPaymentCommand.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
//            insertPaymentCommand.Parameters.AddWithValue("@PaymentAmount", paymentAmount);
//            insertPaymentCommand.ExecuteNonQuery();
//        }
//    }

//    // جلب إجمالي ديون العميل
//    public decimal GetTotalDebt(int ID_CUSTOMER)
//    {
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            connection.Open();
//            string query = "SELECT Debits FROM CUSTOMERS WHERE ID_CUSTOMER = @ID_CUSTOMER";
//            SqlCommand command = new SqlCommand(query, connection);
//            command.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
//            return Convert.ToDecimal(command.ExecuteScalar());
//        }
//    }
 
//}

