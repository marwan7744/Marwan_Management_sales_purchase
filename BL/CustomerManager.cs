using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class CustomerManager
    {
        private string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");

        // جلب جميع العملاء مع firstName و CustomerID
        public DataTable GetAllCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT  ID_CUSTOMER,FIRST_NAME FROM CUSTOMERS";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}

