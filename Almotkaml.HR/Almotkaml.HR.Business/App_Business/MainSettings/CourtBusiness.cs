using Almotkaml.HR.Abstraction;
using Almotkaml.HR.Domain;
using Almotkaml.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almotkaml.HR.Business.App_Business.MainSettings
{

    public class CourtBusiness : Business, ICourtBusiness
    {
        public CourtBusiness(HumanResource humanResource)
            : base(humanResource)
        {
        }

        private bool HavePermission(bool permission = true)
            => ApplicationUser.Permissions.Court && permission;


        public CourtModel Prepare()
        {
            if (!HavePermission(ApplicationUser.Permissions.Court_Create))
                return Null<CourtModel>(RequestState.NoPermission);

            return new CourtModel()
            {
                CanCreate = ApplicationUser.Permissions.Court_Create,
                CanEdit = ApplicationUser.Permissions.Court_Edit,
                CanDelete = ApplicationUser.Permissions.Court_Delete,
                CourtGrid = UnitOfWork.Courts
                    .GetAll()
                    .Select(a => new CourtGridRow()
                    {
                        CourtId = a.CourtId,
                        CourtName = a.CourtName
                    }),
            };
        }

        public void Refresh(CourtModel model)
        {

        }

        public bool Select(CourtModel model)
        {
            if (!HavePermission(ApplicationUser.Permissions.Court_Edit))
                return Fail(RequestState.NoPermission);
            if (model.CourtId <= 0)
                return Fail(RequestState.BadRequest);

            var court = UnitOfWork.Courts.Find(model.CourtId);

            if (court == null)
                return Fail(RequestState.NotFound);

            model.CourtName = court.CourtName;
            return true;

        }

        public bool Create(CourtModel model)
        {
            if (!HavePermission(ApplicationUser.Permissions.Court_Create))
                return Fail(RequestState.NoPermission);

            if (!ModelState.IsValid(model))
                return false;

            if (UnitOfWork.Courts.NameIsExisted(model.CourtName))
                return NameExisted();
            var court = Court.New(model.CourtName);
            UnitOfWork.Courts.Add(court);

            UnitOfWork.Complete(n => n.Court_Create);

            return SuccessCreate();


        }

        public bool Edit(CourtModel model)
        {
            if (model.CourtId <= 0)
                return Fail(RequestState.BadRequest);

            if (!HavePermission(ApplicationUser.Permissions.Court_Edit))
                return Fail(RequestState.NoPermission);

            if (!ModelState.IsValid(model))
                return false;

            var court = UnitOfWork.Courts.Find(model.CourtId);

            if (court == null)
                return Fail(RequestState.NotFound);

            if (UnitOfWork.Countries.NameIsExisted(model.CourtName, model.CourtId))
                return NameExisted();
            court.Modify(model.CourtName);

            UnitOfWork.Complete(n => n.Court_Edit);

            return SuccessEdit();
        }

        public bool Delete(CourtModel model)
        {
            if (!HavePermission(ApplicationUser.Permissions.Court_Delete))
                return Fail(RequestState.NoPermission);

            if (model.CourtId <= 0)
                return Fail(RequestState.BadRequest);

            var court = UnitOfWork.Courts.Find(model.CourtId);

            if (court == null)
                return Fail(RequestState.NotFound);

            UnitOfWork.Courts.Remove(court);

            if (!UnitOfWork.TryComplete(n => n.Court_Delete))
                return Fail(UnitOfWork.Message);

            return SuccessDelete();
        }

    }
}
