
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
        internal class CLS_PURCHASES
        {
            // إضافة فاتورة مشتريات
            public void ADD_PURCHASES(int ID_PURCHASE, DateTime PURCHASE_DATE, int ID, string InvoiceType, string PURCHASE_MAN)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@ID_PURCHASE", SqlDbType.Int);
                param[0].Value = ID_PURCHASE;

                param[1] = new SqlParameter("@PURCHASE_DATE", SqlDbType.DateTime);
                param[1].Value = PURCHASE_DATE;

                param[2] = new SqlParameter("@ID", SqlDbType.Int);
                param[2].Value = ID;

                param[3] = new SqlParameter("@InvoiceType", SqlDbType.VarChar, 250);
                param[3].Value = InvoiceType;

                param[4] = new SqlParameter("@PURCHASE_MAN", SqlDbType.VarChar, 100);
                param[4].Value = PURCHASE_MAN;

                DAL.ExecuteCommand("ADD_PURCHASES", param);
                DAL.Close();
            }
            // إضافة تفاصيل فاتورة المشتريات
            public void ADD_PURCHASE_DETAIL(string ID_PRODUCT, int ID_PURCHASE, 
                int QTE_PURCHASED, string PRICE_PURCHASED, string Amount, string TOTAL_PRICE)
            {
                try
                {
                    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                    DAL.Open();

                    SqlParameter[] param = new SqlParameter[6];

                    param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 50);
                    param[0].Value = ID_PRODUCT;

                    param[1] = new SqlParameter("@ID_PURCHASE", SqlDbType.Int);
                    param[1].Value = ID_PURCHASE;

                    param[2] = new SqlParameter("@QTE_PURCHASED", SqlDbType.Int);
                    param[2].Value = QTE_PURCHASED;

                    param[3] = new SqlParameter("@PRICE_PURCHASED", SqlDbType.VarChar,50);
                    param[3].Value = PRICE_PURCHASED;

                    param[4] = new SqlParameter("@Amount", SqlDbType.VarChar,50);
                    param[4].Value = Amount;

                    param[5] = new SqlParameter("@TOTAL_PRICE", SqlDbType.VarChar,50);
                    param[5].Value = TOTAL_PRICE;

                    DAL.ExecuteCommand("ADD_PURCHASES_DETAILS", param);
                }
                catch (Exception ex)
                {
                    throw new Exception("حدث خطأ أثناء إضافة تفاصيل الفاتورة: " + ex.Message);
                }
                finally
                {
                  //DAL.Close();
                }
            }

            // التحقق من الكمية المتاحة
            public DataTable verifyQte(string ID_PRODUCT, int Qty_Entered)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DataTable Dt = new DataTable();
                SqlParameter[] Param = new SqlParameter[2];

                Param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
                Param[0].Value = ID_PRODUCT;

                Param[1] = new SqlParameter("@Qty_Entered", SqlDbType.Int);
                Param[1].Value = Qty_Entered;

                Dt = DAL.SelectData("verifyQte", Param);
                DAL.Close();
                return Dt;
            }

            // تحديث فاتورة المشتريات
            public void UPDATE_PURCHASE(int ID_PURCHASE, int ID, string ID_PRODUCT, int QTE_PURCHASED, decimal PRICE_PURCHASED, decimal TOTAL_AMOUNT)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[6];

                param[0] = new SqlParameter("@ID_PURCHASE", SqlDbType.Int);
                param[0].Value = ID_PURCHASE;

                param[1] = new SqlParameter("@ID", SqlDbType.Int);
                param[1].Value = ID;

                param[2] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
                param[2].Value = ID_PRODUCT;

                param[3] = new SqlParameter("@QTE_PURCHASED", SqlDbType.Int);
                param[3].Value = QTE_PURCHASED;

                param[4] = new SqlParameter("@PRICE_PURCHASED", SqlDbType.Decimal);
                param[4].Value = PRICE_PURCHASED;

                param[5] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.Decimal);
                param[5].Value = TOTAL_AMOUNT;

                DAL.ExecuteCommand("UPDATE_PURCHASE", param);
                DAL.Close();
            }

            // حذف فاتورة المشتريات
            public void DELETE_PURCHASE(int ID_PURCHASE)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ID_PURCHASE", SqlDbType.Int);
                param[0].Value = ID_PURCHASE;

                DAL.ExecuteCommand("DELETE_PURCHASE", param);
                DAL.Close();
            }

            // الحصول على جميع فواتير المشتريات
            public DataTable GET_ALL_PURCHASES()
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DataTable Dt = new DataTable();
                Dt = DAL.SelectData("GET_ALL_PURCHASES", null);
                DAL.Close();
                return Dt;
            }

            // الحصول على تقرير فواتير المشتريات
            public DataTable GET_PURCHASES_REPORT()
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DataTable Dt = new DataTable();
                Dt = DAL.SelectData("GET_ALL_PURCHASES", null);
                DAL.Close();
                return Dt;
            }

            // البحث في فواتير المشتريات
            public DataTable SEARCH_PURCHASES(string Keyword)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DataTable Dt = new DataTable();
                SqlParameter[] Param = new SqlParameter[1];

                Param[0] = new SqlParameter("@Keyword", SqlDbType.VarChar, 50);
                Param[0].Value = Keyword;

                Dt = DAL.SelectData("SEARCH_PURCHASES", Param);
                DAL.Close();
                return Dt;
            }

            // الحصول على تفاصيل فاتورة مشتريات محددة
            public DataTable GetPurchasesInvoiceDetail(int ID_PURCHASE)
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DataTable Dt = new DataTable();
                SqlParameter[] Param = new SqlParameter[1];

                Param[0] = new SqlParameter("@ID_PURCHASE", SqlDbType.Int);
                Param[0].Value = ID_PURCHASE;

                Dt = DAL.SelectData("GetPurchasesInvoiceDetail", Param);
                DAL.Close();
                return Dt;
            }

            // الحصول على آخر معرف فاتورة مشتريات
            public DataTable GET_LAST_PURCHASES_ID()
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DataTable Dt = new DataTable();
                Dt = DAL.SelectData("GET_LAST_PURCHASES_ID", null);
                DAL.Close();
                return Dt;
            }

            // الحصول على آخر فاتورة مشتريات للطباعة
            public DataTable GET_LAST_PURCHASES_FOR_PRINT()
            {
                DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
                DataTable Dt = new DataTable();
                Dt = DAL.SelectData("GET_LAST_PURCHASES_FOR_PRINT", null);
                DAL.Close();
                return Dt;
            }
        }
    }