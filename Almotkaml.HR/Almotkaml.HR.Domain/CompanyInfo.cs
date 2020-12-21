namespace Almotkaml.HR.Domain
{
    public class CompanyInfo : ICompanyInfo
    {
        public string ShortName { get; set; }
        public string DivisonInGovernment { get; set; }
        public string LongName { get; set; }
        public string EnglishName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string LogoPath { get; set; }
        public string PayrollUnit { get; set; }// وحدة المرتبات
        public string References { get; set; }// المراجع 
        public string FinancialAuditor { get; set; }// المراقب المالي
        public string FinancialAffairs { get; set; }// الشئون المالية
        public string Department { get; set; }// القسم
        public string InsideReferences { get; set; }// مراجع الداخل
        public string FinancialDepartment { get; set; }// رئيس القسم المالي
        public string CollectionPaymentUnit { get; set; }// وحدة صرف التحصيل


    }
}