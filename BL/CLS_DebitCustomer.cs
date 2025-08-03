using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // الخاص با datatebl and data serice
using System.Data.SqlClient;//تتعامل مع قاعدة البيانات 
using System.Diagnostics;

namespace MANGEMENT.BL
{
    internal class CLS_DebitCustomer
    {
        public void ADD_Debt_CUSTOMER(int ID_CUSTOMER ,string CustomerName, decimal Debit, DateTime DateT,bool IsPaid)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[0].Value = ID_CUSTOMER;

            param[1] = new SqlParameter("@CustomerName", SqlDbType.VarChar, 50);
            param[1].Value = CustomerName;

            param[2] = new SqlParameter("@Debit", SqlDbType.Decimal);
            param[2].Value = Debit;
        
            param[3] = new SqlParameter("@DateT", SqlDbType.DateTime);
            param[3].Value = DateT;

            param[4] = new SqlParameter("@IsPaid", SqlDbType.Bit);
            param[4].Value = IsPaid;

            DAL.ExecuteCommand("ADD_Debt_CUSTOMER", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        public void EDIT_Debit_CUSTOMERS( string CustomerName,  decimal Debit, DateTime DateT, bool IsPaid, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];

            //param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            //param[0].Value = ID_CUSTOMER;

            param[0] = new SqlParameter("@CustomerName", SqlDbType.VarChar, 50);
            param[0].Value = CustomerName;

            param[1] = new SqlParameter("@Debit", SqlDbType.Decimal);
            param[1].Value = Debit;
         

            param[2] = new SqlParameter("@DateT", SqlDbType.DateTime);
            param[2].Value = DateT;

            param[3] = new SqlParameter("@IsPaid", SqlDbType.Bit);
            param[3].Value = IsPaid;

            param[4] = new SqlParameter("@ID", SqlDbType.Int);
            param[4].Value = ID;

            DAL.ExecuteCommand("EDIT_Debit_CUSTOMERS", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        public void DELETE_Debt_CUSTOMER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DELETE_Debt_CUSTOMER", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        public DataTable GET_Debt_CUSTOMER()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_Debt_CUSTOMER", null);
            DAL.Close();
            return Dt;
        }
        //public DataTable SEARCH_Debt_CUSTOMER(string Criterion)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
        //                                                         //قم الإعلان عن الباراميتر
        //                                                         // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
        //    param[0].Value = Criterion;
        //    Dt = DAL.SelectData("SEARCH_Debt_CUSTOMER", param);
        //    DAL.Close();
        //    return Dt;
        //}

        //internal void ADD_Suppliers(string text1, string text2, string text3, string text4)
        //{
        //    throw new NotImplementedException();
        //}
    }
}