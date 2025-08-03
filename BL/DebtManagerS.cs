using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class DebtManagerS
    {
        private string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");

        // جلب جميع الديون
        public DataTable GetAllDebts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, ID_SUPPLIER, Debt,DateT FROM Debit_Suppliers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // إضافة دين جديد
        public void AddDebt(int ID_SUPPLIER, decimal Debt, DateTime DateT)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Debit_Suppliers (ID_SUPPLIER, Debt,DateT) VALUES (@ID_SUPPLIER ,@Debt,@DateT)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID_SUPPLIER", ID_SUPPLIER);
                command.Parameters.AddWithValue("@Debt", Debt);
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
                string query = "UPDATE Debit_Suppliers SET Debt = @Debt WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Debt", newDebtAmount);
                command.Parameters.AddWithValue("@ID", debtID);
                command.ExecuteNonQuery();
            }
        }

        // حذف دين
        public void DeleteDebt(int debtID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Debit_Suppliers WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", debtID);
                command.ExecuteNonQuery();
            }
        }
    }
}

