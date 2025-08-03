using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace MANGEMENT.BL
{
    class CLS_LOGIN
    {






        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        //الداله ترسل باراميتران إلى الاجرءا المخزن نوعهمه سترينج 
        //idوالثاني اسمهpassword الاول اسمه  
        public DataTable SP_LOGIN(string ID_USER, string PWD)
        {
           // product_DO_Entities2 db;=new product_DO_Entities2();
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();  //قم بانشاء كائن من الداتااكسيسلاير
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.VarChar, 50); // IDقم الإعلان عن الباراميتر
            param[0].Value = ID_USER;
            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50); //passwordقم الإعلان عن الباراميتر
            param[1].Value = PWD;
            DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();  //نسح
            Dt = DAL.SelectData("SP_LOGIN", param); // نحصل على النتيجه
            DAL.Close();
            return Dt; // نحفظ النتيجه في الداتا تابل
        }




    public void ADD_USER(string ID_USER, string @FullName, string PWD,
            string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[1].Value = FullName;

            param[2] = new SqlParameter("@PWD", SqlDbType.NChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;

            DAL.ExecuteCommand("ADD_USER", param);        
            DAL.Close();
        }
        public void EDIT_USER(string ID_USER, string @FullName, string PWD,
            string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;

            param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[1].Value = FullName;

            param[2] = new SqlParameter("@PWD", SqlDbType.NChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;

            DAL.ExecuteCommand("EDIT_USER", param);
            DAL.Close();
        }

        public void DELETE_USER(string ID_USER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_USER", SqlDbType.VarChar, 50);
            param[0].Value = ID_USER;
            DAL.ExecuteCommand("DELETE_USER", param);
            DAL.Close();
        }
        public DataTable SearchUser(string Criterion)
        {
            //قم بانشاء كان من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //قم الإعلان عن الباراميتر
            // DAL.Open();    //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();//إنشاء باروميتر لان إجراء المخزن يستقبل باروميتر
            SqlParameter[] Param = new SqlParameter[1]; /// لدينا با روميتر واحد بس 
            Param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);//إسم الباروميتر 
            Param[0].Value = Criterion; ////Criterion القيمه التي يرسلها إلى 

            Dt = DAL.SelectData("SearchUser", Param);//
            DAL.Close();//
            return Dt;//
        }
    }
}
