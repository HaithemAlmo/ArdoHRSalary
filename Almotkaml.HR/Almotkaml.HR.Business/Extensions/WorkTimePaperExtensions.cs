using Almotkaml.HR.Domain;
using Almotkaml.HR.Models;
using System.Collections.Generic;
using System.Linq;

namespace Almotkaml.HR.Business.Extensions
{
    public static class WorkTimePaperExtensions
    {
        public static IEnumerable<WorkTimePaperListItem> ToList(this IEnumerable<WorkTimePaper> WorkTimePapers)
            => WorkTimePapers.Select(d => new WorkTimePaperListItem()
            {
                Name = d.Employee.GetFullName(),
                WorkTimePaperId = d.WorkTimePaperId
            });

        public static IEnumerable<WorkTimePaperGridRow> ToGrid(this IEnumerable<WorkTimePaper> WorkTimePapers)
            => WorkTimePapers.Select(d => new WorkTimePaperGridRow()
            {
                WorkTimePaperId = d.WorkTimePaperId,
                EmployeeId = d.EmployeeId,
                EmployeeName = d.Employee?.GetFullName(),
                DayWork = d.DayWork,
                MonthYear=d.ThisMonth.ToString("00")+"-"+d.ThisYear.ToString("0000")
            });
    }
}