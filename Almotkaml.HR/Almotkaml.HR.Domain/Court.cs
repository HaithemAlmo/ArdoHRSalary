using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almotkaml.HR.Domain
{
   public  class Court
    {
        public static Court New(string courtName)
        {
            Check.NotEmpty(courtName, nameof(courtName));

            var court = new Court()
            {
                CourtName = courtName,
            };

            return court;
        }

        private Court()
        {

        }
        public int CourtId { get; private set; }
        public string CourtName { get; private set; }
        public ICollection<SalaryInfo > SalaryInfos { get; } = new HashSet<SalaryInfo>();
        public void Modify(string courtName)
        {
            Check.NotEmpty(courtName, nameof(courtName));

            CourtName = courtName;
        }
    }
}
