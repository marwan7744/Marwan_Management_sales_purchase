using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class ExpenseManager
    {
        private string connectionString = (@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");

        public void ADD_DailyExpenses(DateTime ExpenseDate, string ExpenseDescription, 
            decimal Amount,  string Notes, string UserName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ExpenseDate", SqlDbType.DateTime);
            param[0].Value = ExpenseDate;

            param[1] = new SqlParameter("@ExpenseDescription", SqlDbType.VarChar, 50);
            param[1].Value = ExpenseDescription;

            param[2] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[2].Value = Amount;
            param[3] = new SqlParameter("@Notes", SqlDbType.VarChar, 50);
            param[3].Value = Notes;

            param[4] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[4].Value = UserName;

            DAL.ExecuteCommand("ADD_DailyExpenses", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
       

        public void UPDATE_DailyExpenses(int ExpenseID, DateTime ExpenseDate, string ExpenseDescription,
          decimal Amount, string Notes, string UserName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ExpenseID", SqlDbType.Int);
            param[0].Value = ExpenseID;

            param[1] = new SqlParameter("@ExpenseDate", SqlDbType.DateTime);
            param[1].Value = ExpenseDate;

            param[2] = new SqlParameter("@ExpenseDescription", SqlDbType.VarChar, 50);
            param[2].Value = ExpenseDescription;

            param[3] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[3].Value = Amount;

            param[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 50);
            param[4].Value = Notes;

            param[5] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[5].Value = UserName;

            DAL.ExecuteCommand("UPDATE_DailyExpenses", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }


        public DataTable GET_DailyExpenses()  
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();//قم بانشاء كان من الداتااكسيسلاير
            DAL.Open();//هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_DailyExpenses", null);
            DAL.Close();
            return Dt;
        }

        // حذف مصروف
        public void DeleteExpense(int expenseID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM DailyExpenses WHERE ExpenseID = @ExpenseID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExpenseID", expenseID);
                command.ExecuteNonQuery();
            }
        }
    
        public DataTable GET_SINGLE_DailyExpenses(int ExpenseID)
        {
            try
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ExpenseID", ExpenseID);
              //  param[0] = new SqlParameter("@ExpenseDate", ExpenseDate);


                return DAL.SelectData("GET_SINGLE_DailyExpenses", param);
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

        // حساب الإجمالي اليومي للمصروفات
        public decimal GetDailyTotal(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(Amount) AS DailyTotal FROM DailyExpenses ";//WHERE ExpenseDate = @ExpenseDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExpenseDate", date);
                var result = command.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }
    }
}
