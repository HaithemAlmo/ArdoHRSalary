using Almotkaml.HR.Domain;
using Almotkaml.HR.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Almotkaml.HR.EntityCore.Repositories
{
    public class WorkTimePaperRepository : Repository<WorkTimePaper>, IWorkTimePaperRepository
    {
        private HrDbContext Context { get; }

        internal WorkTimePaperRepository(HrDbContext context)
                : base(context)
        {
            Context = context;
        }
       
        public IEnumerable<WorkTimePaper> GetWorkTimePaperWithEmployee(int EmployeeId)
        {
            return Context.WorkTimePapers
                .Include(d => d.Employee)
                .Where(d => d.EmployeeId == EmployeeId);
        }
        public IEnumerable<WorkTimePaper> GetWorkTimePaperIDWithEmployee(int EmployeeId)
        {
            return Context.WorkTimePapers
                .Include(d => d.Employee)
                .Where(d => d.EmployeeId == EmployeeId);
        }

        public IEnumerable<WorkTimePaper> GetWorkTimePaperWithEmployee()
        {
            return Context.WorkTimePapers
                .Include(d => d.Employee);
        }
        public IEnumerable<WorkTimePaper> GetWorkTimePaperWithEmployeeID(int EmployeeId)
        {
            return Context.WorkTimePapers
                  .Include(d => d.Employee)
                   .Where(d => d.EmployeeId == EmployeeId);

        }

        public bool WorkTimePaperExisted(string name, int EmployeeId) => Context.WorkTimePapers
            .Any(e => e.DayWork == name && e.EmployeeId == EmployeeId);

        public bool WorkTimePaperExisted( int EmployeeId) => Context.WorkTimePapers
            .Any(e =>  e.EmployeeId == EmployeeId);
        public bool WorkTimePaperExisted(int month,int year, int WorkTimePaperId) => Context.WorkTimePapers
           .Any(e => e.ThisMonth == month && e.ThisYear==year && e.WorkTimePaperId == WorkTimePaperId);

    }


}
