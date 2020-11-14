using Almotkaml.HR.Business.Extensions;
using Almotkaml.HR.Domain;
using Almotkaml.HR.Models;
using System.Collections.Generic;
using System.Linq;
using Almotkaml.HR.Abstraction;

namespace Almotkaml.HR.Business.App_Business.MainSettings
{
    public class SalaryUnitBusiness : Business, ISalaryUnitBusiness
    {
        public SalaryUnitBusiness(HumanResource humanResource)
            : base(humanResource)
        {
        }

        private bool HavePermission(bool permission = true)
            => ApplicationUser.Permissions.SalaryUnit && permission;

        public SalaryUnitModel Prepare()
        {
            if (!HavePermission(ApplicationUser.Permissions.SalaryUnit))
                return Null<SalaryUnitModel>(RequestState.NoPermission);

            return new SalaryUnitModel()
            {
                CanSave = ApplicationUser.Permissions.SalaryUnit_Save,
                SalaryUnitGrid = UnitOfWork.SalaryUnits.GetBySalayClassification(SalayClassification.Default).ToGrid()
            };
        }

        public bool Save(SalaryUnitModel model)
        {
            if (!HavePermission(ApplicationUser.Permissions.SalaryUnit_Save))
                return Fail(RequestState.NoPermission);

            if (!ModelState.IsValid(model))
                return false;

            IList<SalaryUnit> salaryUnits =
                UnitOfWork.SalaryUnits.GetBySalayClassification(model.SalayClassification).ToList();

            foreach (var row in model.SalaryUnitGrid)
            {
                var salaryUnit = salaryUnits.FirstOrDefault(s => s.Degree == row.Degree);
                if (salaryUnit == null)
                {
                    UnitOfWork.SalaryUnits
                        .Add(SalaryUnit.New(row.Degree, row.BeginningValue, row.PremiumValue, model.SalayClassification
                            , row.ExtraValue, row.ExtraGeneralValue));
                    continue;
                }

                salaryUnit.Modify(row.BeginningValue, row.PremiumValue, row.ExtraValue, row.ExtraGeneralValue);
            }

            UnitOfWork.Complete(n => n.SalaryUnit_Save);

            return SuccessCreate();
        }

        public void Refresh(SalaryUnitModel model)
        {
            var salaryUnits = UnitOfWork.SalaryUnits.GetBySalayClassification(model.SalayClassification);
            if (model.SalayClassification == SalayClassification.Default)
                model.SalaryUnitGrid = salaryUnits.ToGrid();
            else
                model.SalaryUnitGrid = salaryUnits.ToGridClamp();
        }
    }
}