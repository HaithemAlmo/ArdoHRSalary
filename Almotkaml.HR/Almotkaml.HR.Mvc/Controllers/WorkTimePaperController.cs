using Almotkaml.HR.Models;
using System.Web.Mvc;

namespace Almotkaml.HR.Mvc.Controllers
{
    public class WorkTimePaperController : BaseController
    {
        
        public ActionResult Index()
        {
            var model = HumanResource.WorkTimePaper.Prepare();

            if (model == null)
                return HumanResourceState();

            SaveModel(model);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(WorkTimePaperModel model, FormCollection form)
        {
            LoadModel(model, form["savedModel"]);

            HumanResource.WorkTimePaper.Refresh(model);

            if (!Request.IsAjaxRequest())
                return AjaxNotWorking();

            return AjaxIndex(model, form);
        }

        private PartialViewResult AjaxIndex(WorkTimePaperModel model, FormCollection form)
        {
            var editWorkTimePaperId = IntValue(form["editWorkTimePaperId"]);
            var deleteWorkTimePaperId = IntValue(form["deleteWorkTimePaperId"]);
            var ModalSave = form["save"];



            // Select
            if (editWorkTimePaperId > 0 && deleteWorkTimePaperId>0)
            {
                 Select(model, editWorkTimePaperId);
                return PartialView("_Form", model);

            }
            else if (editWorkTimePaperId > 0)
                {
                    Select(model, editWorkTimePaperId);
                return PartialView("_Form", model);

            }
            else if (deleteWorkTimePaperId > 0)
            {
                 Delete(model, deleteWorkTimePaperId);
                return PartialView("_Form", model);
            }
            else
            {
                if (ModalSave != null && ModalSave != "")
                {
                    model.CanSave = true;
                    DayWork(model);
                    if (!HumanResource.WorkTimePaper.Select(model))
                        return AjaxHumanResourceState("_Form", model);

                    ModelState.Clear();
                    return PartialView("_Form", model);
                }
                else
                {
                    if (model.WorkTimePaperId > 0)
                    {
                        if (!HumanResource.WorkTimePaper.Edit(model))
                            return AjaxHumanResourceState("_Form", model);

                        ModelState.Clear();
                        return PartialView("_Form", model);
                    }
                    else if (model.EmployeeId > 0)
                    {
                        if (model.WorkTimePaperId == 0)
                        {
                            model.CanSave = false;
                            if (!HumanResource.WorkTimePaper.Select(model))
                                return AjaxHumanResourceState("_Form", model);

                            return Select(model, editWorkTimePaperId);
                            //return PartialView("_Form", model);
                        }
                        return Select(model, editWorkTimePaperId);
                    }
                }

            //if (!ModelState.IsValid)
            //    return PartialView("_Form", model);

            }

            ModelState.Clear();
            return PartialView("_Form", model);
        }
        private PartialViewResult Select(WorkTimePaperModel model, int editWorkTimePaperId)
        {
            ModelState.Clear();
            model.WorkTimePaperId = editWorkTimePaperId;

            if (!HumanResource.WorkTimePaper.Select(model))
                return AjaxHumanResourceState("_Form", model);

            return PartialView("_Form", model);
        }

        private PartialViewResult SelectEmployee(WorkTimePaperModel model)
        {
            ModelState.Clear();
            
            if (!HumanResource.WorkTimePaper.Select(model))
                return AjaxHumanResourceState("_Form", model);

            return PartialView("_Form", model);
        }


        public WorkTimePaperModel DayWork(WorkTimePaperModel model)
        {
            string A = " , ";
            if (model.Saturday == true)
            {
                model.DayWork = "Saturday";
            }
            if (model.Sunday == true)
            {
                model.DayWork += A + "Sunday";
            }
            if (model.Monday == true)
            {
                model.DayWork += A + "Monday";
            }
            if (model.Tuesday == true)
            {
                model.DayWork += A + "Tuesday";
            }
            if (model.Wednesday == true)
            {
                model.DayWork += A + "Wednesday";
            }
            if (model.Thursday == true)
            {
                model.DayWork += A + "Thursday";
            }
            if (model.Friday == true)
            {
                model.DayWork += A + "Friday";
            }
        
            return model;
        }
        private PartialViewResult Delete(WorkTimePaperModel model, int deleteWorkTimePaperId)
        {
            ModelState.Clear();
            model.WorkTimePaperId = 0;
            model.WorkTimePaperId = deleteWorkTimePaperId;

            if (!HumanResource.WorkTimePaper.Delete(model))
                return AjaxHumanResourceState("_Form", model);

            return PartialView("_Form", model);
        }
    
      private void LoadModel(WorkTimePaperModel model, string savedModel)
        {
            var loadedModel = LoadSavedModel<WorkTimePaperModel>(savedModel);

            if (loadedModel == null)
                return;
            
            model.CanCreate = loadedModel.CanCreate;
            model.CanEdit = loadedModel.CanEdit;
            model.CanDelete = loadedModel.CanDelete;
            model.WorkTimePaperGrid = loadedModel.WorkTimePaperGrid;
            model.EmployeeGrid = loadedModel.EmployeeGrid;
            //model.ThisMonth = loadedModel.ThisMonth;
            //model.ThisYear = loadedModel.ThisYear;


        }
    }
}
