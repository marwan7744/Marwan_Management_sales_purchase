using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANGEMENT.BL
{
    internal class Management_Account_Supplier
    {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            private string connectionString = @"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true";

            /// <summary>
            /// ترجع جدولين: الأول تفاصيل كشف الحساب، والثاني إجماليات المدين والدائن والرصيد.
            /// </summary>
            public (DataTable ledgerDetails, DataTable totals) GetCustomerLedgerWithTotals(int Id)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Get_SupplierLedger_ByID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", Id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds); // الجدول الأول: تفاصيل اليومية
                    da.Fill(ds); // الجدول الثاني: المجاميع

                    DataTable ledgerDetails = ds.Tables[0];
                    DataTable totals = ds.Tables[1];

                    return (ledgerDetails, totals);
                }
            }
            public DataTable GetCashLedger()
            {
                dal.Open();
                DataTable dt = dal.SelectData("Get_CashLedger", null);
                dal.Close();
                return dt;
            }

            //public DataTable GetCustomerLedger(int customerId)
            //{
            //    dal.Open();

            //    SqlParameter[] param = new SqlParameter[1];
            //    param[0] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            //    param[0].Value = customerId;

            //    DataTable dt = dal.SelectData("Get_CustomerLedger", param);
            //    dal.Close();
            //    return dt;
            //}



            public void Add_JournalEntry(DateTime entryDate, int accountId, string accountType,
                                         string descriptions, decimal debit, decimal credit,
                                         string refType, int refId)
            {
                dal.Open();

                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@EntryDate", entryDate);
                param[1] = new SqlParameter("@AccountID", accountId);
                param[2] = new SqlParameter("@AccountType", accountType);
                param[3] = new SqlParameter("@Descriptions", descriptions);
                param[4] = new SqlParameter("@Debit", debit);
                param[5] = new SqlParameter("@Credit", credit);
                param[6] = new SqlParameter("@RefType", refType);
                param[7] = new SqlParameter("@RefID", refId);

                dal.ExecuteCommand("Add_JournalEntry", param);
                dal.Close();
            }
            /////////////////////////////
            public DataTable Get_SupplierLedger_ByID(int ID)
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                dal.Open();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DataTable dt = dal.SelectData("Get_SupplierLedger_ByID", param);
                dal.Close();
                return dt;
            }


            public DataTable Get_PaymentVoucher_By_ID(int ID)
            {
                DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                dal.Open();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;

                DataTable dt = dal.SelectData("Get_PaymentVoucher_By_ID", param);
                dal.Close();
                return dt;
            }

            public (DataTable ledgerDetails, DataTable totals)
           Get_SupplierLedger_Full(int SupplierID, DateTime fromDate, DateTime toDate)
            {
                DataTable dtLedger = new DataTable();
                DataTable dtTotals = new DataTable();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Get_SupplierLedger_Full", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SupplierID", SupplierID);
                        cmd.Parameters.AddWithValue("@DateFrom", fromDate);
                        cmd.Parameters.AddWithValue("@DateTo", toDate);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds); // جدول 1: كشف الحساب
                            da.Fill(ds); // جدول 2: المجاميع

                            if (ds.Tables.Count > 0)
                                dtLedger = ds.Tables[0];

                            if (ds.Tables.Count > 1)
                                dtTotals = ds.Tables[1];
                        }
                    }
                }

                return (dtLedger, dtTotals);
            }
        }
    }

    /// <summary>
    /// استدعاء كشف حساب كامل للعميل (مبيعات، مرتجعات، سندات قبض)
    /// </summary>


