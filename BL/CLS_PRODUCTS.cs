using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MANGEMENT.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير
            //قم الإعلان عن الباراميتر
           // DAL.Open(); //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;
        }
        public void ADD_PRODUCT(int ID_cus, string Label, string ID_product,int Qte, string Price, byte[] Img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CUS", SqlDbType.Int);
            param[0].Value = ID_cus;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[1].Value = ID_product;

            param[2] = new SqlParameter("@Label", SqlDbType.VarChar,30);
            param[2].Value = Label;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = Img;
            DAL.ExecuteCommand("ADD_PRODUCT", param);       // جراءالمخزن في ADD_PRODUCT ترسل البارومترات القادمة من الفورم إلى 
            DAL.Close();
        }
        // إنشاء إجراء المخزن الذي يقوم با إرسال الباروميترات إليه
        public void UPDATE_PRODUCT(int ID_CUS , string LABEL_PRODUCT, string ID_PRODUCT,  int Qte, string Price, byte[] Img)
        {
           
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CUS", SqlDbType.Int);
            param[0].Value = ID_CUS;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,50);
            param[1].Value = ID_PRODUCT;

            param[2] = new SqlParameter("@Label", SqlDbType.VarChar,30);
            param[2].Value = LABEL_PRODUCT;

            param[3] = new SqlParameter("@Qte", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@Price", SqlDbType.VarChar,50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@Img", SqlDbType.Image);
            param[5].Value = Img;
            DAL.ExecuteCommand("UPDATE_PRODUCT", param);
            DAL.Close();
        }
        public void UPDATE_PRODUCT_QTY(string ID_PRODUCT, int Qte)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID_PRODUCT", ID_PRODUCT);
                param[1] = new SqlParameter("@Qty", Qte);
                DAL.ExecuteCommand("UPDATE_PRODUCT_QTY", param);
            }
            finally
            {
                DAL.Close();
            }
        }
        public DataTable VerifyProductID(string ID)   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            //قم بانشاء كان من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                                                          //قم الإعلان عن الباراميتر
                                                                // DAL.Open();    //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();//إنشاء باروميتر لان إجراء المخزن يستقبل باروميتر
            SqlParameter[] Param = new SqlParameter[1]; /// لدينا با روميتر واحد بس 
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);//إسم الباروميتر 
            Param[0].Value = ID; //  ID القيمه التي يرسلها إلى 
            Dt = DAL.SelectData("VerifyProductID", Param);//
            DAL.Close();//
            return Dt;//
        }
        public DataTable GET_ALL_PRODUCT()   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();//قم بانشاء كان من الداتااكسيسلاير
            DAL.Open();//هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PRODUCT", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Search(string ID)   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            //قم بانشاء كان من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            //قم الإعلان عن الباراميتر
            //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            // DAL.Open(); 
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            Dt = DAL.SelectData("search", Param);
            DAL.Close();
            return Dt;
        }

        //نقوم بانشاء داله من نوع داتا تابل وترسل باروميتر تستقبل الباروميتر من خلال دالة داتا جريد فوليو
        public DataTable GET_IMAGE_PRODUCT(string ID)   // تجلب كل الاصناف ولا تجلب بارو واحد بل كل الاصناف
        {
            //قم بانشاء كان من الداتااكسيسلاير
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();  //هنا نقوم بافتح الاتصال مع قاعدة البيانات
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            Dt = DAL.SelectData("GET_IMAGE_PRODUCT", Param);
            DAL.Close();
            return Dt;
        }
        public void DeleteProduct(String ID)        //دالة الحذف

        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            DAL.ExecuteCommand("DeleteProduct", param);
            DAL.Close();
        }
    }
}