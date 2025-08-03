using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Shape.Native;

namespace MANGEMENT.BL
{
    internal class CLS_RETAIL_SALES
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer(); //قم بانشاء كان من الداتااكسيسلاير

        public void AddRetailSale(DateTime SaleDate, string LABEL_PRODUCT,
                                  int Quantity, decimal UnitPrice, decimal TotalAmount,
                                  string PaymentMethod)
        {
            try { 
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[6];

             
             param[0] = new SqlParameter("@SaleDate", SqlDbType.DateTime);
             param[0].Value = SaleDate;

            param[1] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = LABEL_PRODUCT;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = Quantity;

            param[3] = new SqlParameter("@UnitPrice", SqlDbType.Decimal);
            param[3].Value = UnitPrice;

            param[4] = new SqlParameter("@TotalAmount", SqlDbType.Decimal);
            param[4].Value = TotalAmount;

            param[5] = new SqlParameter("@PaymentMethod", SqlDbType.VarChar, 50);
            param[5].Value = PaymentMethod;

            DAL.ExecuteCommand("AddRetailSale", param);

          //  return Convert.ToInt32(param[0].Value);
        }
            catch (Exception ex)
            {
                throw new Exception("Failed to add return: " + ex.Message);
    }
            finally
            {
                DAL.Close();
            }
      }

        public void AddRetailSaleDetail(int SaleID, string ID_PRODUCT, int Quantity,
                                           decimal UnitPrice)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@SaleID", SqlDbType.Int);
            param[0].Value = SaleID;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 50);
            param[1].Value = ID_PRODUCT;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = Quantity;

            param[3] = new SqlParameter("@UnitPrice", SqlDbType.Decimal);
            param[3].Value = UnitPrice;

            DAL.ExecuteCommand("AddRetailSaleDetail", param);
            DAL.Close();
        }


        public DataTable GET_ALL_RETAIL(int SaleID)
        {
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SaleID", SaleID);
                return DAL.SelectData("GET_ALL_RETAIL", param);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get session returns: " + ex.Message);
            }
            finally
            {
                DAL.Close();
            }
        }

        // دالة الحصول على آخر رقم فاتورة
        public DataTable sp_GetLastSaleID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("sp_GetLastSaleID", null);
            DAL.Close();
            return Dt;
        }
    }
}




