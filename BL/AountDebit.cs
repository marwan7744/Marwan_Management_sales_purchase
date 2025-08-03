//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MANGEMENT.BL
//{
//    internal class AountDebit
//    {

//        static void Main()
//        {
//            string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");

//            // بيانات الدين الجديد
//            int ID_CUSTOMER = 1; // معرف العميل
//            decimal Debit = 100.00m; // قيمة الدين

//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();

//                // إضافة الدين إلى جدول الديون
//                string insertDebtQuery = "INSERT INTO Debts (ID_CUSTOMER, Debit) VALUES (@ID_CUSTOMER, @Debit);";
//                using (SqlCommand command = new SqlCommand(insertDebtQuery, connection))
//                {
//                    command.Parameters.AddWithValue("@ID_CUSTOMER", ID_CUSTOMER);
//                    command.Parameters.AddWithValue("@Debit", Debit);

//                    command.ExecuteNonQuery();
//                    Console.WriteLine("تم إضافة الدين بنجاح.");
//                }
//            }
//        }
//    }
//}

