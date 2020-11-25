using Almotkaml.HR.Domain;
using Almotkaml.Repository;
using System;
using System.Collections.Generic;

namespace Almotkaml.HR.Repository
{
    public interface IWorkTimePaperRepository : IRepository<WorkTimePaper>
    {
        IEnumerable<WorkTimePaper> GetWorkTimePaperWithEmployee(int EmployeeId);
        IEnumerable<WorkTimePaper> GetWorkTimePaperIDWithEmployee(int EmployeeId);
        IEnumerable<WorkTimePaper> GetWorkTimePaperWithEmployee();
        IEnumerable<WorkTimePaper> GetWorkTimePaperWithEmployeeID(int EmployeeId);

        bool WorkTimePaperExisted(string name, int EmployeeId);

        bool WorkTimePaperExisted(int EmployeeId) ;
        bool WorkTimePaperExisted(int month, int year, int EmployeeId);
    }
}