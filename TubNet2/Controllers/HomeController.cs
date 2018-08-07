using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TubNet2.Models;
using DataLibrary;

namespace TubNet2.Controllers
{
    public class HomeController : Controller
    {
        private TubDataBaseEntities db = new TubDataBaseEntities();

        public ActionResult Index()
        {
            ViewBag.actuals = getActual();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<PatientAnalsis> getActual()
        {
            List<PatientAnalsis> res = new List<PatientAnalsis>();

            var bloodquery = db.BlTest___Patient
                     .Where(q => q.bltp_date == DateTime.Today).ToList();
            foreach(BlTest___Patient q in bloodquery)
            {
                PatientAnalsis a = new PatientAnalsis();
                a.name = "аналіз крові";
                a.patient = (from e in db.Patients
                             where e.p_id == q.bltp_patid
                             select e).FirstOrDefault();
                res.Add(a);
            }

            var urinaquery = (from q in db.UrTest__Patient
                              where q.utp_date == DateTime.Today
                              select q).ToList();
            foreach(UrTest__Patient q in urinaquery)
            {
                PatientAnalsis a = new PatientAnalsis();
                a.name = "аналіз сечі";
                a.patient = (from e in db.Patients
                             where e.p_id == q.utp_patid
                             select e).FirstOrDefault();
                res.Add(a);
            }

            var hepaticquery = (from q in db.HepTest___Patient
                              where q.htp_date == DateTime.Today
                              select q).ToList();
            foreach (HepTest___Patient q in hepaticquery)
            {
                PatientAnalsis a = new PatientAnalsis();
                a.name = "печінкові проби";
                a.patient = (from e in db.Patients
                             where e.p_id == q.htp_patid
                             select e).FirstOrDefault();
                res.Add(a);
            }

            var sputumquery = (from q in db.SputumTest___Patient
                              where q.sptp_date == DateTime.Today
                              select q).ToList();
            foreach (SputumTest___Patient q in sputumquery)
            {
                PatientAnalsis a = new PatientAnalsis();
                a.name = "аналіз мокроти";
                a.patient = (from e in db.Patients
                             where e.p_id == q.sptp_patid
                             select e).FirstOrDefault();
                res.Add(a);
            }

            var consquery = (from q in db.Consult___Patient
                               where q.cp_date == DateTime.Today
                               select q).ToList();
            foreach (Consult___Patient q in consquery)
            {
                PatientAnalsis a = new PatientAnalsis();
                a.name = String.Format("консультація ({0})", q.Consultation.ConsultationType.ct_value);
                a.patient = (from e in db.Patients
                             where e.p_id == q.cp_patid
                             select e).FirstOrDefault();
                res.Add(a);
            }

            return res.OrderBy(item => item.name).ToList();
        }
    }
}