namespace Almotkaml.HR.Reports
{
    public class SalariesTotalReport
    {
        public decimal BasicSalaries { get; set; }                  //ÇáãÑÊÈ ÇáÇÓÇÓí

        //public decimal SocialSecurityFund { get; set; }            //  ÕäÏæÞ ÇáÖÇãä ÇáÇÌÊãÇÚí
        public decimal CompanyShare { get; set; }                    //خصم الجهة من الضمان
        public decimal SafeShare { get; set; }                      //خصم الخزانة من الضمان
        public decimal EmployeeShare { get ; set; }                  //خصم الضمان
        public decimal SolidarityFund { get; set; }                 // صندوق التضامن
        public decimal JihadTax { get; set; }                       //ضريبة الجهاد
        //public decimal MawadaFund { get; set; }                     //ÇáãæÏÉ
        public decimal SalariesTotal { get; set; }                  //ÇÌãÇáí ÇáãÑÊÈ
        public decimal SalariesNet { get; set; }                    //ÕÇÝí ÇáãÑÊÈ
        public decimal DeducationTotal { get; set; }                //ãÌãæÚ ÇáÎÕã
        public int    SalariesNumber { get; set; }                     //ÚÏÏ ÇáãÑÊÈÇÈ
        public decimal ContributionInSecurity { get; set; }         //ÇáãÓÇåãÉ Ýí ÇáÖãÇä
        public decimal StampTax { get; set; }                       //ÖÑíÈÉ ÇáÏãÛÉ
        public decimal Absence { get; set; }                        //ÎÕã ÇáÛíÇÈ
        public decimal Sanction { get; set; }                       // ÎÕã ÇáÌÒÇÁ
        public decimal OtherDiscount { get; set; }                  //ÎÕãíÇÊ ÇÎÑí
        public decimal IncomeTax { get; set; }                 // ضريبة الدخل
        public decimal GroupLife { get; set; }                       //الحياة الجماعي
        public decimal AdvancePayment { get; set; }               // السلف
        public decimal Clamp { get; set; }                        //åíÆÇÊ ÞÖÇÆíÉ
        public decimal Subsistence { get; set; }                       // ÇÚÇÔÉ
        public decimal Premium { get; set; }                  //ãßÇÝÆÇÊ
        public decimal Mwada { get; set; }                        //دعم صندوق المودة
        public decimal MwadaPaymentValue { get; set; }            //مجموع اقساط سلف صندوق المودة المسترجعة
        public decimal LibyanArmyPaymentValue { get; set; }       //مجموع اقساط سلف صندوق الجيش الليبي المسترجعة
        public decimal ExtraWork { get; set; }        //العمل الإضافي
        public decimal ExtraGeneralValue { get; set; }     //الزيادة العامة 
        public decimal RewardValue { get; set; } //المكافآة
        public decimal ExtraValue { get; set; }
        public decimal PremiumActive { get; set; }
       // public decimal TotalDiscound { get; set; }
    }
}