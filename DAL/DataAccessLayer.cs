using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;   //مجال الاسماء الذي يمكننا التاعمل مع قاعدة البيانات
using System.Data;  //مجال الاسماء الذي يسمح يتعامل مع البيانات 
using System.Windows.Forms;

namespace MANGEMENT.DAL
{
    // نبني  كلاس  لكي يمكننى التواصل مع قاعدة البيانات بشكل مباشر
    class DataAccessLayer
    {
        SqlConnection sqlconnection;       //هذا يربط مع قاعدة البيانات 
        //هذا با استنساخ الكائن كونكشن 
        //this constructor inisialize the connection object
        public DataAccessLayer()
        {          
   //إ  /طريقة الوصول الى السرفر /اسم قاعدةالبيانات التي نتواصل معها/     اسم السيرفر
   sqlconnection = new SqlConnection(@"server=ADMIN\SQLEXPRESS;Database=product_DO_;Integrated Security=true");
            // OR server=.\SQLEXPRESS;Database=product_DO_;Integrated Security=true")
        }

        //دالة  يقوم الاجراء بفتح  و الاتصال 
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)                                                                                                            //تحقق من حال الاتصال 
            { 
                sqlconnection.Open();
            // وكذلك يامن الاتصال
        }
        //method to close the connection
    }
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {                                                                                                        // تحقق من إذا كان مفتوح نقوم با غلقه

                sqlconnection.Close();
            }
            
        }
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)    
        {                                                                                                                                                                        //    ا sqlcommand الاجراءت المخزن ترتبط
            SqlCommand sqlcmd = new SqlCommand(); // name an action stored إنشا إجراء مخزن  
            sqlcmd.CommandType = CommandType.StoredProcedure;// type command 
            sqlcmd.CommandText = stored_procedure; // text command
            sqlcmd.Connection = sqlconnection;
                                                                                                                                                                         //نسوي الشرط إذا كانت موجوده باراميتر ام لا 
            if (param != null)
            {
               //او نستخدم بدون لووب نستخدم في دالة ااد AddRange
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]); // all parametar
                }
            } 
            //// read data result عنecext an action stored
           SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
        ////ينبغي ان نضع الناتج في الداتا تابل
           DataTable dt = new DataTable();
               ////نقوم با تعبات الداتا ادبتر
              da.Fill(dt);
            //fill هي داله تابعه لداتااد ابتر
            return dt;
        }
        //METHOD to// insert// update// and delete// data //from database
        //وكذلك هذه الدالة لا تعيد لنا اي شي
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;// type command 
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;
                //لا يستطيع الكومند العمل إلابا الكونكشن
                if (param != null)
                {
                    //لكي نعرف هل يوجد باراميتر واحد او اكثر ومن الضروري نستخدم لووب الفور
                    // نستخدم بدون لووب  في دالة ااد  AddRange    او  
                    sqlcmd.Parameters.AddRange(param);            //  با إضافة مصفوفه اما الاد تقوم با إضافه عنصر واحد AddRangeتقوم                                                                                    // commandإضافة العامل إلا 
                                                                  // all parametar
                }
                sqlcmd.ExecuteNonQuery(); ///commandهذا ينفذ ال 
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطاء"+ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal SqlConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        internal object ExecuteScalar(string v, SqlParameter[] param)
        {
            throw new NotImplementedException();
      }
    }
} 
