using Almotkaml.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Almotkaml.HR.Resources;

namespace Almotkaml.HR.Models
{
    public class SalaryUnitModel
    {
        public IList<SalaryUnitGridRow> SalaryUnitGrid { get; set; } = new List<SalaryUnitGridRow>();
        public bool CanSave { get; set; }
        public int SalaryUnitId { get; set; }

        [Required(ErrorMessageResourceType = typeof(SharedMessages),
            ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
            Name = nameof(Title.Degree))]
        public int Degree { get; set; }

        [Required(ErrorMessageResourceType = typeof(SharedMessages),
            ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
            Name = nameof(Title.BeginningValue))]
        public decimal BeginningValue { get; set; }

        [Required(ErrorMessageResourceType = typeof(SharedMessages),
            ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
            Name = nameof(Title.PremiumValue))]
        public decimal PremiumValue { get; set; }

        [Required(ErrorMessageResourceType = typeof(SharedMessages),
            ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
            Name = nameof(Title.SalayClassification))]
        public SalayClassification SalayClassification { get; set; }

        //[Required(ErrorMessageResourceType = typeof(SharedMessages),
        //    ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
            Name = nameof(Title.ExtraValue))]
        public decimal ExtraValue { get; set; }

        [Required(ErrorMessageResourceType = typeof(SharedMessages),
            ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
            Name = nameof(Title.ExtraGeneralValue))]
        public decimal ExtraGeneralValue { get; set; }

        public decimal GetPremium(int premium, int degree)
        {
            var salaryUnit = SalaryUnitGrid.FirstOrDefault(s => s.Degree == degree);
            return salaryUnit.BeginningValue + salaryUnit.PremiumValue * premium;
        }
        public decimal GetExtraValue(int premium, int degree)
        {
            var salaryUnit = SalaryUnitGrid.FirstOrDefault(s => s.Degree == degree);
            return (salaryUnit.BeginningValue + salaryUnit.PremiumValue * premium) * 40 / 100;
        }
    }

    public class SalaryUnitGridRow
    {
        public int SalaryUnitId { get; set; }
        public int Degree { get; set; }
        public decimal BeginningValue { get; set; }
        public decimal PremiumValue { get; set; }
        public decimal ExtraValue { get; set; }
        public decimal ExtraGeneralValue { get; set; }
    }
}
