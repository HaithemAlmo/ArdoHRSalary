using Almotkaml.HR.Domain;
using Almotkaml.HR.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almotkaml.HR.EntityCore.Repositories
{

    public class CourtRepository : Repository<Court>, ICourtRepository
    {
        private HrDbContext Context { get; }

        internal CourtRepository(HrDbContext context)
            : base(context)
        {
            Context = context;
        }

        public bool NameIsExisted(string name) => Context.Courts 
            .Any(e => e.CourtName == name);

        public bool NameIsExisted(string name, int idToExcept) => Context.Courts
            .Any(e => e.CourtName == name && e.CourtId != idToExcept);
    }
}
