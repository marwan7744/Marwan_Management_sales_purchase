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
    internal class CashBox
    {
        private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";


        public decimal TryParseDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
                return 0;

            decimal result;
            if (decimal.TryParse(value.ToString(), out result))
                return result;

            return 0;
        }



        public DataSet Get_CashBox(int? customerId,DateTime fromDate, DateTime toDate, string filterType = "ALL")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Get_CashBox", conn);
                cmd.CommandType = CommandType.StoredProcedure; 

                // إضافة المعاملات للإجراء المخزن
                cmd.Parameters.AddWithValue("@CustomerID", (object)customerId ?? DBNull.Value);          
                cmd.Parameters.AddWithValue("@DateFrom", fromDate);
                cmd.Parameters.AddWithValue("@DateTo", toDate);
                cmd.Parameters.AddWithValue("@FilterType", filterType); 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                return ds;
            }
        }




     
    }
}
