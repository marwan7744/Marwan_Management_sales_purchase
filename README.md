نظام إدارة المبيعات والمشتريات - Marwan Management
📂 طبقة BL (Business Logic Layer)
تحتوي على الكلاسات الأساسية للنظام:

SalesManager.cs لإدارة المبيعات والفواتير

InventoryManager.cs لإدارة المخزون

CustomerManager.cs لإدارة العملاء

ReportManager.cs لتوليد التقارير

📊 طبقة RPT (التقارير)
csharp
public class ReportGenerator
{
    public void GenerateSalesReport(DateTime from, DateTime to)
    {
        // 1. جلب بيانات المبيعات من قاعدة البيانات
        // 2. تصميم التقرير باستخدام Crystal Reports
        // 3. تصدير التقرير كـ PDF أو طباعته
    }
    
    public void GenerateInventoryReport()
    {
        // تقرير يوضح حالة المخزون
        // والمنتجات المنتهية الصلاحية
    }
}
🗃️ طبقة DAL (Data Access Layer)
csharp
public class DatabaseManager
{
    private SqlConnection _connection;
    
    public DatabaseManager(string connectionString)
    {
        _connection = new SqlConnection(connectionString);
    }
    
    public DataTable ExecuteQuery(string query)
    {
        // تنفيذ استعلام SELECT
        using (SqlCommand cmd = new SqlCommand(query, _connection))
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
    
    public int ExecuteNonQuery(string command)
    {
        // تنفيذ INSERT, UPDATE, DELETE
        using (SqlCommand cmd = new SqlCommand(command, _connection))
        {
            _connection.Open();
            int result = cmd.ExecuteNonQuery();
            _connection.Close();
            return result;
        }
    }
}
🔄 مثال للتفاعل بين الطبقات
csharp
// في واجهة المستخدم (PL)
var salesManager = new SalesManager();
var invoices = salesManager.GetTodayInvoices();

// في BL
public List<Invoice> GetTodayInvoices()
{
    var dal = new DatabaseManager(connectionString);
    string query = "SELECT * FROM Invoices WHERE Date = @Today";
    DataTable dt = dal.ExecuteQuery(query);
    // تحويل البيانات إلى كائنات Invoice
    return invoices;
}
لا اريد هذا الشرح غيرة كامل
طبقات النظام الأساسية
طبقة BL (Business Logic)
تحتوي على:

SalesManager: إدارة عمليات البيع

PurchaseManager: إدارة المشتريات

InventoryManager: متابعة المخزون

طبقة RPT (التقارير)
تتضمن:

SalesReport: تقارير المبيعات اليومية والشهرية

InventoryReport: تقارير حركة المخزون

FinancialReport: التقارير المالية

طبقة DAL (اتصال قاعدة البيانات)
المكونات الرئيسية:

DBConnection: إدارة الاتصال بالخادم

DataAccess: تنفيذ الاستعلامات

TransactionHandler: معالجة العمليات المالية

كل طبقة تعمل بشكل مستقل وتتواصل مع الأخرى عبر واجهات محددة.

هههههههههههههههههه
حاضر يا مروان! 😊 خلاصة بسيطة وسريعة:

markdown
# 💼 طبقات النظام الأساسية

## 🔵 BL (المنطق التشغيلي)
- `Sales.cs` ← إدارة الفواتير والطلبات
- `Purchases.cs` ← متابعة المشتريات
- `Inventory.cs` ← مراقبة المخزون

## 📊 RPT (التقارير)
- `SalesReport.rpt` ← تقارير المبيعات
- `StockReport.rpt` ← حركة المخزون
- `FinanceReport.rpt` ← الإيرادات/المصروفات

## 🗃️ DAL (قاعدة البيانات)
- `DB.cs` ← الإتصال بالسيرفر
- `SQLHelper.cs` ← تنفيذ الإستعلامات
