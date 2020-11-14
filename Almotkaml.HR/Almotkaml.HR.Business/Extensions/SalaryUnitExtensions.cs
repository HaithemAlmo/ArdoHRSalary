using Almotkaml.Extensions;
using Almotkaml.HR.Domain;
using Almotkaml.HR.Models;
using System.Collections.Generic;
using System.Linq;

namespace Almotkaml.HR.Business.Extensions
{
    public static class SalaryUnitExtensions
    {
        public static IList<SalaryUnitGridRow> ToGrid(this IEnumerable<SalaryUnit> salaryUnits)
        {
            var list = new List<SalaryUnitGridRow>();
            var units = salaryUnits.AsIList();

            for (var i = 1; i < 15; i++)
            {
                var unit = units.FirstOrDefault(u => u.Degree == i);
                if (unit == null)
                    list.Add(new SalaryUnitGridRow()
                    {
                        Degree = i,
                    });
                else
                    list.Add(new SalaryUnitGridRow()
                    {
                        Degree = unit.Degree,
                        BeginningValue = unit.BeginningValue,
                        PremiumValue = unit.PremiumValue,
                        SalaryUnitId = unit.SalaryUnitId,
                        ExtraValue = unit.ExtraValue,
                        ExtraGeneralValue = unit.ExtraGeneralValue
                    });
            }

            return list;
        }
        public static IList<SalaryUnitGridRow> ToGridClamp(this IEnumerable<SalaryUnit> salaryUnits)
        {
            var list = new List<SalaryUnitGridRow>();
            var units = salaryUnits.AsIList();

            foreach (var degree in SalaryUnit.ClampDegrees())
            {
                var unit = units.FirstOrDefault(u => u.Degree == (int)degree);
                if (unit == null)
                    list.Add(new SalaryUnitGridRow()
                    {
                        Degree = (int)degree,
                    });
                else
                    list.Add(new SalaryUnitGridRow()
                    {
                        Degree = unit.Degree,
                        BeginningValue = unit.BeginningValue,
                        PremiumValue = unit.PremiumValue,
                        SalaryUnitId = unit.SalaryUnitId,
                        ExtraValue = unit.ExtraValue,
                        ExtraGeneralValue = unit.ExtraGeneralValue
                    });
            }

            return list;
        }
    }
}