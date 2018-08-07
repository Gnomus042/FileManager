using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using TubNet2.Models;
using System.Data.Entity;
using TubNet2.ControllerHelpers;

namespace TubNet2.Controllers
{
    public class TestController : Controller
    {
        private TubDataBaseEntities db = new TubDataBaseEntities();
        private static int pid = 0;
        private static ViewTestsModel model;
        private static int activeTest;
        private static SelectList ConsType;

        // GET: Test
        public ActionResult TestsList(int p_id = 0, string viewName = "BloodTest", string type = "Plan")
        {
            pid = p_id;
            if (model == null || model.ViewName!=viewName)
            {
                model = new ViewTestsModel();
                ConsType = new SelectList(db.ConsultationType, "ct_id", "ct_value");
            }
            if (model.filter == null)
            {
                model.filter = new FilterModel();

            }

                ViewBag.SelectType = ConsType;

            Patients pat = (from p in db.Patients where p.p_id == p_id select p).FirstOrDefault();
            model.Patient = pat;
            model.ViewName = viewName;
            model.ViewCollection = GetList(viewName, type, p_id);
            model.filter.ViewType = type;
            return View(model);
        }

        [HttpPost]
        public ActionResult Filter(FilterModel filter = null)
        {
            if (filter.UseDate == false)
            {
                model.filter.UseDate = false;
                model.filter.borderDate = null;
                model.filter.ViewType = filter.ViewType;
            }
            else
            {
                model.filter.ViewType = filter.ViewType;
                model.filter.borderDate = filter.borderDate;
                model.filter.UseDate = true;
            }
          
            return redirect();
        }

        public ActionResult PlanTest(DateTime date)
        {
            HelperSelector.get(model.ViewName).PlanNewTest(date, pid);
            return redirect();
        }

        public ActionResult PlanConsultation(DateTime date, int ct_id)
        {
            ((ConsultationHelper)HelperSelector.get("Consultation")).PlanNewTest(date, ct_id, pid);
            return redirect();
        }

        [HttpPost]
        public ActionResult UpdateBloodTest(BloodTest blood)
        {
            HelperSelector.get(model.ViewName).UpdateTest(blood);
            model.Single = null;
            return redirect();
        }

        [HttpPost]
        public ActionResult UpdateUrinaTest(UrineTest urina)
        {
            HelperSelector.get(model.ViewName).UpdateTest(urina);
            model.Single = null;
            return redirect();
        }

        [HttpPost]
        public ActionResult UpdateHepaticTest(HepaticTest hepat)
        {
            HelperSelector.get(model.ViewName).UpdateTest(hepat);
            model.Single = null;
            return redirect();
        }

        [HttpPost]
        public ActionResult UpdateSputumTest(SputumTest sputum)
        {
            HelperSelector.get(model.ViewName).UpdateTest(sputum);
            model.Single = null;
            return redirect();
        }

        [HttpPost]
        public ActionResult UpdateConsultation(Consultation consultation)
        {
            HelperSelector.get(model.ViewName).UpdateTest(consultation);
            model.Single = null;
            return redirect();
        }

        public ActionResult DeleteTest(int id = 0)
        {
            int a = HelperSelector.get(model.ViewName).DeleteTest(id);
            if(a == activeTest)
            {
                model.Single = null;
            }
            return redirect();
        }

        public ActionResult ChangeActiveTest(int id = 0)
        {
            model.Single = HelperSelector.get(model.ViewName).GetActiveTest(id);
            model.SingleDate = HelperSelector.get(model.ViewName).GetActiveTestDate(id);
            activeTest = id;
            return redirect();
        }

        private RedirectToRouteResult redirect()
        {
            return RedirectToAction("TestsList", new { p_id = model.Patient.p_id, viewName = model.ViewName, type = model.filter.ViewType });
        }

        private object GetList(string view, string type, int p_id)
        {
            string sort = "";
            switch(type)
            {
                case "Close": sort = "завершено";
                    break;
                case "Plan":sort = "заплановано";
                    break;
                case "Lose":sort = "пропущено";
                    break;
            }
            if (model.filter.borderDate == null)
            {
                return HelperSelector.get(view).GetSortedCollection(sort, p_id);
            }
            else
            {
                return HelperSelector.get(view).GetSortedCollection(sort, p_id, model.filter.borderDate ?? default(DateTime));
            }
        }
    }
}