using Almotkaml.HR.Abstraction;
using Almotkaml.HR.Business.Extensions;
using Almotkaml.HR.Domain;
using Almotkaml.HR.Models;
using System.Linq;

namespace Almotkaml.HR.Business.App_Business.MainSettings
{
    public class WorkTimePaperBusiness : Business, IWorkTimePaperBusiness
    {
        public WorkTimePaperBusiness(HumanResource humanResource)
            : base(humanResource)
        {
        }

        private bool HavePermission(bool permission = true)
            => ApplicationUser.Permissions.WorkTimePaper && permission;




        public WorkTimePaperModel Prepare()
        {
            if (!HavePermission(ApplicationUser.Permissions.WorkTimePaper_Create))
                return Null<WorkTimePaperModel>(RequestState.NoPermission);

            //var x = UnitOfWork.FingerPrinters.GetAllByMonth(2019, 5);
        
            return new WorkTimePaperModel()
            {
                CanCreate = ApplicationUser.Permissions.WorkTimePaper_Create,
                CanEdit = ApplicationUser.Permissions.WorkTimePaper_Edit,
                CanDelete = ApplicationUser.Permissions.WorkTimePaper_Delete,
                WorkTimePaperGrid = UnitOfWork.WorkTimePapers.GetWorkTimePaperWithEmployee().ToGrid(),
                EmployeeGrid= UnitOfWork.Employees.GetAll().ToGrid()
                   
            };
        }

        public void Refresh(WorkTimePaperModel model)
        {
            model.WorkTimePaperGrid = UnitOfWork.WorkTimePapers.GetWorkTimePaperWithEmployee().ToGrid();

            var WorkTimePaper = UnitOfWork.WorkTimePapers.Find(model.WorkTimePaperId);
            var employee = UnitOfWork.Employees.GetEmployeeNameById(model.EmployeeId);
            if (employee == null)
                return;
            model.EmployeeName = employee.GetFullName();
        

        }

        public bool Select(WorkTimePaperModel model)
        {
            if (!HavePermission(ApplicationUser.Permissions.WorkTimePaper_Edit))
                return Fail(RequestState.NoPermission);
            if (model.WorkTimePaperId <= 0 && model.EmployeeId <=0)
                return Fail(RequestState.BadRequest);

            if (model.CanSave == true)
            {
                if (model.CanSave == true)
                {
                    var WorkTimePaperE = UnitOfWork.WorkTimePapers.GetWorkTimePaperWithEmployeeID(model.EmployeeId);
                var WorkTimePaperEMP = WorkTimePaperE.FirstOrDefault(e => e.EmployeeId == model.EmployeeId);

                if (WorkTimePaperEMP == null) return Create(model); 
                model.WorkTimePaperId = WorkTimePaperEMP.WorkTimePaperId;
                
                return Edit(model);
                }
                if (model.CanSave == false)
                { return Create(model); }
             
            }
        
            if (model.WorkTimePaperId > 0)
            {
                var WorkTimePaperSF = UnitOfWork.WorkTimePapers.Find(model.WorkTimePaperId);
                var FullName = UnitOfWork.Employees.Find(WorkTimePaperSF.EmployeeId).GetFullName();

                if (WorkTimePaperSF == null)
                    return Fail(RequestState.NotFound);

                model.EmployeeId = WorkTimePaperSF.EmployeeId;
                model.EmployeeName = FullName;
                model.DayWork = WorkTimePaperSF.DayWork;
                model.Saturday = WorkTimePaperSF.Saturday;
                model.Sunday = WorkTimePaperSF.Sunday;
                model.Monday = WorkTimePaperSF.Monday;
                model.Tuesday = WorkTimePaperSF.Tuesday;
                model.Wednesday = WorkTimePaperSF.Wednesday;
                model.Thursday = WorkTimePaperSF.Thursday;
                model.Friday = WorkTimePaperSF.Friday;
                model.ThisMonth = WorkTimePaperSF.ThisMonth;
                model.ThisYear = WorkTimePaperSF.ThisYear;


                Prepare();
                return true;

            }
            

            var WorkTimePaperxx = UnitOfWork.WorkTimePapers.GetWorkTimePaperWithEmployeeID(model.EmployeeId);
            var WorkTimePaper = WorkTimePaperxx.FirstOrDefault(e=>e.EmployeeId==model.EmployeeId); 

            if (WorkTimePaper == null)
                return Fail(RequestState.NotFound);

            var fullName = UnitOfWork.Employees.Find(WorkTimePaper.EmployeeId).GetFullName();

            model.WorkTimePaperId = WorkTimePaper.WorkTimePaperId;
            model.EmployeeId = WorkTimePaper.EmployeeId;
            model.EmployeeName = fullName;
            model.DayWork = WorkTimePaper.DayWork;
            model.Saturday = WorkTimePaper.Saturday;
            model.Sunday = WorkTimePaper.Sunday;
            model.Monday = WorkTimePaper.Monday;
            model.Tuesday = WorkTimePaper.Tuesday;
            model.Wednesday = WorkTimePaper.Wednesday;
            model.Thursday = WorkTimePaper.Thursday;
            model.Friday = WorkTimePaper.Friday;
            model.ThisMonth = WorkTimePaper.ThisMonth;
            model.ThisYear = WorkTimePaper.ThisYear;
            Prepare(); 
            return true;
          
        }
     
        public bool Create(WorkTimePaperModel model)
        {

            if (!HavePermission(ApplicationUser.Permissions.WorkTimePaper_Create))
                return Fail(RequestState.NoPermission);

            if (!ModelState.IsValid(model))
                return false;

            if (UnitOfWork.WorkTimePapers.WorkTimePaperExisted(model.ThisMonth , model.ThisYear , model.WorkTimePaperId))
                return NameExisted();
            // تغير من موظف الي ايام العمل
            var _WorkTimePaper = WorkTimePaper.New(model.DayWork, model.EmployeeId,model.Saturday,model.Sunday,model.Monday,model.Tuesday,model.Wednesday,model.Thursday,model.Friday,model.ThisMonth,model.ThisYear);
            UnitOfWork.WorkTimePapers.Add(_WorkTimePaper);
            
            UnitOfWork.Complete(n => n.WorkTimePaper_Create);
            Prepare();
            model.EmployeeId = 0;
            model.EmployeeName = "";
            model.Saturday = false;
            model.Sunday = false;
            model.Monday = false;
            model.Tuesday = false;
            model.Wednesday = false;
            model.Thursday = false;
            model.Friday = false;
            model.ThisMonth = 0;
            model.ThisYear =0;
            return SuccessCreate();
        }
        public bool Edit(WorkTimePaperModel model)
        {
            if (model.WorkTimePaperId <= 0)
                return Fail(RequestState.BadRequest);

            if (!HavePermission(ApplicationUser.Permissions.WorkTimePaper_Edit))
                return Fail(RequestState.NoPermission);

            if (!ModelState.IsValid(model))
                return false;

            var workTimePapers = UnitOfWork.WorkTimePapers.Find(model.WorkTimePaperId);

            if (workTimePapers == null)
                return Fail(RequestState.NotFound);

            workTimePapers.Modify(model.DayWork, model.EmployeeId, model.Saturday, model.Sunday, model.Monday, model.Tuesday, model.Wednesday, model.Thursday, model.Friday,model.ThisMonth,model.ThisYear);
            // تغيير 
            UnitOfWork.Complete(n => n.WorkTimePaper_Edit);

      Prepare();
            model.EmployeeId = 0;
            model.EmployeeName = "";
            model.Saturday = false;
            model.Sunday = false;
            model.Monday = false;
            model.Tuesday = false;
            model.Wednesday = false;
            model.Thursday = false;
            model.Friday = false;
            model.ThisMonth = 0;
            model.ThisYear = 0;
            return SuccessEdit();
        }

        public bool Delete(WorkTimePaperModel model)
        {
            if (!HavePermission(ApplicationUser.Permissions.WorkTimePaper_Delete))
                return Fail(RequestState.NoPermission);

            if (model.WorkTimePaperId <= 0)
                return Fail(RequestState.BadRequest);

            var _WorkTimePaper = UnitOfWork.WorkTimePapers.Find(model.WorkTimePaperId);

            if (_WorkTimePaper == null)
                return Fail(RequestState.NotFound);

            UnitOfWork.WorkTimePapers.Remove(_WorkTimePaper);

            if (!UnitOfWork.TryComplete(n => n.WorkTimePaper_Delete))
                return Fail(UnitOfWork.Message);

            Prepare();
            model.EmployeeId = 0;
            model.EmployeeName = "";
            model.Saturday = false;
            model.Sunday = false;
            model.Monday = false;
            model.Tuesday = false;
            model.Wednesday = false;
            model.Thursday = false;
            model.Friday = false;
            model.ThisMonth = 0;
            model.ThisYear = 0;
            return SuccessDelete();
        }
    }
}