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
    internal class CLS_CUSTOMERS
    {
        // decimal Debit//
        public void ADD_CUSTOMER(string First_Name, string Last_Name, string Tel,
            string Email, byte[] Picture, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
           
            param[0] = new SqlParameter("@First_Name", SqlDbType.VarChar, 25);
            param[0].Value = First_Name;

            param[1] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 25);
            param[1].Value = Last_Name;

            param[2] = new SqlParameter("@Tel", SqlDbType.NChar, 15);
            param[2].Value = Tel;

            param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 25);
            param[3].Value = Email;

            //param[4] = new SqlParameter("@Debit", SqlDbType.Decimal);
            //param[4].Value = Debit;


            param[4] = new SqlParameter("@Picture", SqlDbType.Image);
            param[4].Value = Picture;

          
            param[5] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[5].Value = Criterion;
           

            DAL.ExecuteCommand("ADD_CUSTOMER", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        // decimal Debit,
        public void EDIT_CUSTOMER(string First_Name, string Last_Name, string Tel,
          string Email, byte[] Picture, string Criterion ,int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@First_Name", SqlDbType.VarChar, 25);
            param[0].Value = First_Name;

            param[1] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 25);
            param[1].Value = Last_Name;

            param[2] = new SqlParameter("@Tel", SqlDbType.NChar, 15);
            param[2].Value = Tel;

            param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 25);
            param[3].Value = Email;

            //param[4] = new SqlParameter("@Debit", SqlDbType.Decimal);
            //param[4].Value = Debit;

            param[4] = new SqlParameter("@Picture", SqlDbType.Image);
            param[4].Value = Picture;

            param[5] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[5].Value = Criterion;

            param[6] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[6].Value = ID;
            DAL.ExecuteCommand("EDIT_CUSTOMER", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();

        }
        public void DELETE_CUSTOMER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[0].Value = ID;


            DAL.ExecuteCommand("DELETE_CUSTOMER", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        public DataTable GET_ALL_CUSTOMERS()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);
            DAL.Close();
            return Dt;
        }
        public DataTable SEARCH_CUSTOMER(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;
            Dt = DAL.SelectData("SEARCH_CUSTOMER", param);
            DAL.Close();
            return Dt;
        }



        public DataTable VerifyID_CUSTOMER(string ID)   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            //قم بانشاء كان من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //قم الإعلان عن الباراميتر
            // DAL.Open();    //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();//إنشاء باروميتر لان إجراء المخزن يستقبل باروميتر
            SqlParameter[] Param = new SqlParameter[1]; /// لدينا با روميتر واحد بس 
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);//إسم الباروميتر 
            Param[0].Value = ID; //  ID القيمه التي يرسلها إلى 
            Dt = DAL.SelectData("VerifyID_CUSTOMER", Param);//
            DAL.Close();//
            return Dt;//
        }
    }
}
