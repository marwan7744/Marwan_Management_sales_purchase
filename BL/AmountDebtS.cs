using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class AountDebtS
    {

        static void Main()
        {
            string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");

            // بيانات الدين الجديد
            int ID_SUPPLIER = 1; // معرف العميل
            decimal Debt = 100.00m; // قيمة الدين

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // إضافة الدين إلى جدول الديون
                string insertDebtQuery = "INSERT INTO Debt (ID_SUPPLIER, Debt) VALUES (@ID_SUPPLIER, @Debt);";
                using (SqlCommand command = new SqlCommand(insertDebtQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID_SUPPLIER", ID_SUPPLIER);
                    command.Parameters.AddWithValue("@Debt", Debt);

                    command.ExecuteNonQuery();
                    Console.WriteLine("تم إضافة الدين بنجاح.");
                }
            }
        }
    }
}

