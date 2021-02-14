using Almotkaml.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almotkaml.HR.Mvc.Controllers
{


    public class CourtController : BaseController
    {
        // GET: CostCenter
        public ActionResult Index()
        {
            var model = HumanResource.Court.Prepare();

            if (model == null)
                return HumanResourceState();

            SaveModel(model);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CourtModel model, FormCollection form)
        {
            LoadModel(model, form["savedModel"]);

            HumanResource.Court.Refresh(model);

            if (!Request.IsAjaxRequest())
                return AjaxNotWorking();

            return AjaxIndex(model, form);
        }

        private PartialViewResult AjaxIndex(CourtModel model, FormCollection form)
        {
            var editCourtId = IntValue(form["editCourtId"]);
            var deleteCourtId = IntValue(form["deleteCourtId"]);

            // Select
            if (editCourtId > 0)
                return Select(model, editCourtId);

            // Delete
            if (deleteCourtId > 0)
                return Delete(model, deleteCourtId);

            // Insert
            if (!ModelState.IsValid)
                return PartialView("_Form", model);

            if (model.CourtId == 0)
            {
                if (!HumanResource.Court.Create(model))
                    return AjaxHumanResourceState("_Form", model);
            }

            if (model.CourtId > 0)
            {
                if (!HumanResource.Court.Edit(model))
                    return AjaxHumanResourceState("_Form", model);
            }

            CallRedirect();
            return PartialView("_Form", model);
        }
        private PartialViewResult Select(CourtModel model, int editCourtId)
        {
            ModelState.Clear();
            model.CourtId = editCourtId;

            if (!HumanResource.Court.Select(model))
                return AjaxHumanResourceState("_Form", model);

            return PartialView("_Form", model);
        }
        private PartialViewResult Delete(CourtModel model, int deleteCourtId)
        {
            ModelState.Clear();
            model.CourtId = deleteCourtId;

            if (!HumanResource.Court.Delete(model))
                return AjaxHumanResourceState("_Form", model);
            CallRedirect();

            return PartialView("_Form", model);
        }

        private void LoadModel(CourtModel model, string savedModel)
        {
            var loadedModel = LoadSavedModel<CourtModel>(savedModel);

            if (loadedModel == null)
                return;

            model.CanCreate = loadedModel.CanCreate;
            model.CanEdit = loadedModel.CanEdit;
            model.CanDelete = loadedModel.CanDelete;
            model.CourtGrid = loadedModel.CourtGrid;
        }
    }
}