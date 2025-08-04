# نظام إدارة المبيعات والمشتريات - Marwan Management

<h1><img src="https://emojis.slackmojis.com/emojis/images/1531849430/4246/blob-sunglasses.gif?1531849430" width="30"/> مرحباً! أنا مروان</h1>

<p>مرحباً بكم في صفحة نظام إدارة المبيعات والمشتريات! </br> أنا <b>مروان</b>، مطور نظم إدارة من <b>الجمهورية اليمنية</b>. </p>

## 🏗️ بنية النظام المعمارية
يعتمد النظام على **التصميم متعدد الطبقات** (Multi-Layer Architecture):

🔹 **DAL (Data Access Layer)**  
طبقة الوصول إلى البيانات

🔹 **BL (Business Logic Layer)**  
طبقة منطق الأعمال (سأشرحها بالتفصيل أدناه)

🔹 **Models**  
تحتوي على الكائنات والكيانات

🔹 **PL (Presentation Layer)**  
الواجهة الرسومية

🔹 **RPT (Reports)**  
نظام التقارير

## 📂 شرح طبقة BL (Business Logic Layer)

تحتوي طبقة منطق الأعمال على الكلاسات الرئيسية التالية:

### 1. SalesManager.cs
```csharp
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
```

### 2. InventoryManager.cs
```csharp
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
```

### 3. CustomerManager.cs
```csharp
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
```

### 4. ReportManager.cs
```csharp
public class ReportManager {
    public SalesReport GenerateSalesReport(DateTime period) {
        // توليد تقرير المبيعات
    }
    
    public InventoryReport GenerateInventoryReport() {
        // تقرير المخزون
    }
}
```

## 🔄 كيفية عمل الطبقات معاً

1. **واجهة المستخدم (PL)** تستدعي دوال من **BL**
2. **BL** تقوم بـ:
   - تطبيق قواعد العمل
   - التحقق من الصلاحيات
   - معالجة البيانات
3. **BL** تستخدم **DAL** للوصول للبيانات
4. النتائج تعود عبر الطبقات بنفس الترتيب

## 📌 فوائد هذا التصميم

- فصل واضح للمسؤوليات
- سهولة الصيانة والتطوير
- إمكانية إعادة استخدام الكود
- اختبار كل طبقة بشكل منفصل

## 💻 التقنيات المستخدمة
<p>
  <img alt=".NET" src="https://img.shields.io/badge/-.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" />
  <img alt="C#" src="https://img.shields.io/badge/-C%23-239120?style=flat-square&logo=c-sharp&logoColor=white" />
  <img alt="SQL Server" src="https://img.shields.io/badge/-SQL%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=white" />
</p>
