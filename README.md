نظام إدارة المبيعات والمشتريات - Marwan Management
<h1><img src="https://emojis.slackmojis.com/emojis/images/1531849430/4246/blob-sunglasses.gif?1531849430" width="30"/> مرحباً! أنا مروان</h1><p>مرحباً بكم في صفحة نظام إدارة المبيعات والمشتريات! </br> أنا <b>مروان</b>، مطور نظم إدارة من <b>الجمهورية اليمنية</b>. </p>
🏗️ بنية النظام المعمارية


يعتمد النظام على التصميم متعدد الطبقات (Multi-Layer Architecture):

🔹 DAL (Data Access Layer)
طبقة الوصول إلى البيانات

🔹 BL (Business Logic Layer)
طبقة منطق الأعمال (سأشرحها بالتفصيل أدناه)

🔹 Models
تحتوي على الكائنات والكيانات

🔹 PL (Presentation Layer)
الواجهة الرسومية

🔹 RPT (Reports)
نظام التقارير

📂 شرح طبقة BL (Business Logic Layer)


تحتوي طبقة منطق الأعمال على الكلاسات الرئيسية التالية:

1. SalesManager.cs
csharp
public class SalesManager {
    public void CreateInvoice(Invoice invoice) {
        // منطق إنشاء الفاتورة
    }
    
    public List<Invoice> GetCustomerInvoices(int customerId) {
        // استرجاع فواتير العميل
    }
    
    public decimal CalculateTotalSales(DateTime from, DateTime to) {
        // حساب إجمالي المبيعات
    }
}
2. InventoryManager.cs
csharp
public class InventoryManager {
    public void UpdateStock(Product product, int quantity) {
        // تحديث كمية المنتج
    }
    
    public List<Product> GetLowStockProducts() {
        // استرجاع المنتجات قليلة الكمية
    }
    
    public void ReceivePurchaseOrder(PurchaseOrder order) {
        // استلام طلب شراء
    }
}
3. CustomerManager.cs
csharp
public class CustomerManager {
    public void AddCustomer(Customer customer) {
        // إضافة عميل جديد
    }
    
    public List<Customer> SearchCustomers(string keyword) {
        // بحث العملاء
    }
    
    public decimal GetCustomerBalance(int customerId) {
        // حساب رصيد العميل
    }
}
4. ReportManager.cs
csharp
public class ReportManager {
    public SalesReport GenerateSalesReport(DateTime period) {
        // توليد تقرير المبيعات
    }
    
    public InventoryReport GenerateInventoryReport() {
        // تقرير المخزون
    }
}
🔄 كيفية عمل الطبقات معاً

واجهة المستخدم (PL) تستدعي دوال من BL

BL تقوم بـ:

تطبيق قواعد العمل

التحقق من الصلاحيات

معالجة البيانات

BL تستخدم DAL للوصول للبيانات

النتائج تعود عبر الطبقات بنفس الترتيب

📌 فوائد هذا التصميم

فصل واضح للمسؤوليات

سهولة الصيانة والتطوير

إمكانية إعادة استخدام الكود

اختبار كل طبقة بشكل منفصل

💻 التقنيات المستخدمة


<p> <img alt=".NET" src="https://img.shields.io/badge/-.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" /> <img alt="C#" src="https://img.shields.io/badge/-C%23-239120?style=flat-square&logo=c-sharp&logoColor=white" /> <img alt="SQL Server" src="https://img.shields.io/badge/-SQL%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=white" /> </p>
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
