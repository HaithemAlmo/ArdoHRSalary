using System.Collections.Generic;

namespace Almotkaml.HR.Domain
{
    public class SalaryUnit
    {
        public static SalaryUnit New(int degree, decimal beginningValue, decimal premiumValue
            , SalayClassification salayClassification, decimal extraValue, decimal extraGeneralValue)
        {
            Check.MoreThanZero(degree, nameof(degree));

            var salaryUnit = new SalaryUnit()
            {
                Degree = degree,
                BeginningValue = beginningValue,
                PremiumValue = premiumValue,
                SalayClassification = salayClassification,
                ExtraValue = extraValue,
                ExtraGeneralValue = extraGeneralValue
            };

            return salaryUnit;
        }

        private SalaryUnit()
        {

        }
        public int SalaryUnitId { get; private set; }
        public int Degree { get; private set; }
        public decimal BeginningValue { get; private set; }
        public decimal PremiumValue { get; private set; }
        public decimal ExtraValue { get; private set; }
        public decimal ExtraGeneralValue { get; private set; }
        public SalayClassification SalayClassification { get; private set; }
        public void Modify(decimal beginningValue, decimal premiumValue, decimal extraValue, decimal extraGeneralValue)
        {
            BeginningValue = beginningValue;
            PremiumValue = premiumValue;
            ExtraValue = extraValue;
            ExtraGeneralValue = extraGeneralValue;

        }

        public static IEnumerable<ClampDegree> ClampDegrees()
            => new HashSet<ClampDegree>()
            {
                ClampDegree.Seven,
                ClampDegree.Nine,
                ClampDegree.TenB,
                ClampDegree.TenA,
                ClampDegree.Eleven,
                ClampDegree.Twelve,
                ClampDegree.ThirteenB,
                ClampDegree.ThirteenA,
                ClampDegree.FourteenB,
                ClampDegree.FourteenA
            };
    }
}
