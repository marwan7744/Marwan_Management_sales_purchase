using System;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using DevExpress.XtraEditors.Controls;
using MANGEMENT.RPT;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MANGEMENT.BL
{
    public class CLS_RETURNED_SALES
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

        public int ADD_RETURN_SALES(int orderId, string productId, int customerId,
                            int quantity, string price, string Amount, string TotalAmount, string reason, string processedBy,string DISCOUNT)
        {
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@ReturnID", SqlDbType.Int);
                param[0].Direction = ParameterDirection.Output;

                param[1] = new SqlParameter("@ID_ORDER", orderId);
                param[2] = new SqlParameter("@ID_PRODUCT", productId);
                param[3] = new SqlParameter("@ID_CUSTOMER", customerId);
                param[4] = new SqlParameter("@ReturnQty", quantity);
                param[5] = new SqlParameter("@PRICE", price);
                param[6] = new SqlParameter("@Amount", Amount);
                param[7] = new SqlParameter("@TotalAmount  ", TotalAmount);
                param[8] = new SqlParameter("@ReturnReason", reason);
                param[9] = new SqlParameter("@ProcessedBy", processedBy);
                param[10] = new SqlParameter("@DISCOUNT", DISCOUNT);

                DAL.ExecuteCommand("ADD_RETURN_SALES", param);
                return Convert.ToInt32(param[0].Value);
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

        //order_sales
        public DataTable GET_SESSION_RETURNS(int orderId)
        {
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID_ORDER", orderId);
                return DAL.SelectData("GET_SESSION_RETURNS", param);
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





        public int ADD_RETURN_PURCHASE(int purchased, string productId, int suplierId,
                          int quantity, string price, string Amount, string TotalAmount,string reason, string processedBy, string DISCOUNT)
        {
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[11];

                param[0] = new SqlParameter("@Return_buy_ID", SqlDbType.Int);
                param[0].Direction = ParameterDirection.Output;

                param[1] = new SqlParameter("@ID_PURCHASE", purchased);
                param[2] = new SqlParameter("@ID_PRODUCT", productId);
                param[3] = new SqlParameter("@ID", suplierId);
                param[4] = new SqlParameter("@ReturnQty", quantity);
                param[5] = new SqlParameter("@PRICE", price);
                param[6] = new SqlParameter("@Amount", Amount);
                param[7] = new SqlParameter("@TotalAmount  ", TotalAmount);
                param[8] = new SqlParameter("@ReturnReason", reason);
                param[9] = new SqlParameter("@ProcessedBy", processedBy);
                param[10] = new SqlParameter("@DISCOUNT", DISCOUNT);

                DAL.ExecuteCommand("ADD_RETURN_PURCHASE", param);
                return Convert.ToInt32(param[0].Value);
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
        //PURCHAES
        public DataTable GET_SESSION_RETURNS_PURCHASE(int purachaesId)
        {
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID_PURCHASE", purachaesId);
                return DAL.SelectData("GET_SESSION_RETURNS_PURCHASE", param);
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
    }
}