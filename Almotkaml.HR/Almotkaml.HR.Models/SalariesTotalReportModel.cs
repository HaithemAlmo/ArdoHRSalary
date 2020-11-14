using System.Collections.Generic;

namespace Almotkaml.HR.Models
{
    public class SalariesTotalReportModel
    {
        public IEnumerable<SalariesTotalReportGridRow> Grid { get; set; } = new HashSet<SalariesTotalReportGridRow>();
        public int Month { get; set; }
        public int Year { get; set; }
    }
    public class SalariesTotalReportGridRow
    {
        public decimal BasicSalaries { get; set; }
        public decimal EmployeeShare { get; set; }
        public decimal CompanyShare{ get; set; }
        public decimal SolidarityFund { get; set; }
        public decimal JihadTax { get; set; }
        public decimal MawadaFund { get; set; }
        public decimal SalariesTotal { get; set; }
        public decimal SalariesNet { get; set; }
        public decimal DeducationTotal { get; set; }
        public int SalariesNumber { get; set; }
        public decimal SafeShare { get; set; }
        public decimal ContributionInSecurity { get; set; }
        public decimal StampTax { get; set; }
    }

}