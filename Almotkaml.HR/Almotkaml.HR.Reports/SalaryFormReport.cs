using Almotkaml.HR.Models;
using System.Collections.Generic;

namespace Almotkaml.HR.Reports
{
    public class SalaryFormReport
    {
        public string DateSalary { get; set; }

        public string JobNumber { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Absence { get; set; }
        public decimal SickVacation { get; set; }
        public decimal WithoutPay { get; set; }
        public decimal Sanction { get; set; }
        public decimal ExtraWork { get; set; }
        public decimal ExtraWorkVacation { get; set; }
        public decimal ExtraWorkConst { get; set; }
        public decimal SituationOnTotal { get; set; }
        public decimal TotalSalary { get; set; }
        public decimal SolidarityFund { get; set; }
        public decimal EmployeeShare { get; set; }
        public decimal CompanyShare { get; set; }
        public decimal SubjectSalary { get; set; }
        public decimal Subject { get; set; }
        public decimal JihadTax { get; set; }
        public decimal ExemptionTax { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal PrepaidSalaryAndAdvancePremium { get; set; }
        public decimal SituationOnNet { get; set; }
        public decimal NetSalary { get; set; }
        public decimal StampTax { get; set; }
        public int EmployeeStat { get; set; }
        public string CostCenterName { get; set; }
        public int CostCenterId { get; set; }
        public string Tafkeet { get; set; }
        public decimal AdvancePremiumInside { get; set; }
        public decimal AdvancePremiumOutside { get; set; }
        public decimal PrepaidPremium { get; set; }
        public decimal FinalySalary { get; set; }
        public string NationalNumber { get; set; }
        public string MonyeNumber { get; set; }
        public decimal RewindValue { get; set; }
        public decimal AccumulatedValue { get; set; }
        public decimal GroupLife { get; set; }
        public decimal Discound { get; set; }
        public decimal AllBouns { get; set; }
        public decimal RewardValue { get; set; }
        public int Degree { get; set; }
        public int Boun { get; set; }
        public string CenterName { get; set; } //  الوحدة التنظيمية
        public decimal Catering { get; set; }  //علاوة تموين
        public decimal Distinction { get; set; }   //علاوة تمييز
        public decimal Retention { get; set; }    // علاوة إحتفاظ
        public decimal Scarred { get; set; }   //علاوة ندب
        public decimal ExtraValue { get; set; }   //قيمة الزيادة في الرواتب
        public decimal MawadaFund { get; set; }    // صندوق المودة 
        public decimal MawadaAdvancePayment { get; set; }   //سلفة صندوق المودة
        public decimal LibyanArmyAdvancePayment { get; set; }   //سلفة صندوق الجيش الليبي
        public decimal Alimony { get; set; }   //النفقة الشرعية
        public decimal OtherDiscount { get; set; }   //خصميات اخرى
        public decimal TotalDiscount { get; set; }   //خصميات اخرى
        public string  FinancialNumber { get; set; }
        public string BondNumber { get; set; }
        public string BankName { get; set; }
      


        //public IList<PremiumCheckListItem> PremiumCheckListItem { get; set; } = new List<PremiumCheckListItem>();
        //public IList<PremiumCheckListItemReport> PremiumCheckListItemReport { get; set; } = new List<PremiumCheckListItemReport>();


    }
}