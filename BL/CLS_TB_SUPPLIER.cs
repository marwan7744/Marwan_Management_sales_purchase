using DevExpress.XtraExport.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MANGEMENT.BL
{
    internal class CLS_TB_SUPPLIER
    {
      
        public void ADD_Supplier(string FullName, string Phone, string Email, byte[] Picture, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[0].Value = FullName;

            param[1] = new SqlParameter("@Phone", SqlDbType.VarChar, 10);
            param[1].Value = Phone;

            param[2] = new SqlParameter("@Email", SqlDbType.VarChar, 10);
            param[2].Value = Email;

            param[3] = new SqlParameter("@Picture", SqlDbType.Image);
            param[3].Value = Picture;

            param[4] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[4].Value = Criterion;
            DAL.ExecuteCommand("ADD_Supplier", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        public void EDIT_Supplier(string FullName, string Phone, string Email, byte[] Picture, string Criterion, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[1].Value = FullName;

            param[2] = new SqlParameter("@Phone", SqlDbType.VarChar, 10);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 10);
            param[3].Value = Email;

            param[4] = new SqlParameter("@Picture", SqlDbType.Image);
            param[4].Value = Picture;

            param[5] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[5].Value = Criterion;

           

            DAL.ExecuteCommand("EDIT_Supplier", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        public void DELETE_Supplier(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DELETE_Supplier", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        public DataTable GET_ALL_Supplier()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_Supplier", null);
            DAL.Close();
            return Dt;
        }
        public DataTable SEARCH_Suppliers(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
                                                                 //قم الإعلان عن الباراميتر
                                                                 // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;
            Dt = DAL.SelectData("SEARCH_Suppliers", param);
            DAL.Close();
            return Dt;
        }
        //internal void ADD_Suppliers(string text1, string text2, string text3, string text4)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
