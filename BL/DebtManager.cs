using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class DebtManager
    {
        private string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");

        // جلب جميع الديون
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

        // إضافة دين جديد
        public void AddDebt(int ID_CUSTOMER, decimal Debit,DateTime DateT)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Debt (ID_CUSTOMER, Debit,DateT) VALUES (@ID_CUSTOMER ,@Debit,@DateT)";
                SqlCommand command = new SqlCommand(query, connection);
              
                command.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
                command.Parameters.AddWithValue("@Debit", Debit);
                command.Parameters.AddWithValue("@DateT", DateT);
                command.ExecuteNonQuery();
            }
        }

        // تعديل دين موجود
        public void UpdateDebt(int debtID, decimal newDebtAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Debt SET Debit = @Debit WHERE DebtID = @DebtID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Debit", newDebtAmount);
                command.Parameters.AddWithValue("@DebtID", debtID);
                command.ExecuteNonQuery();
            }
        }

        // حذف دين
        public void DeleteDebt(int debtID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Debt WHERE DebtID = @DebtID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DebtID", debtID);
                command.ExecuteNonQuery();
            }
        }
    }
}


