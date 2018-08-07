using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using TubNet2.Models;


namespace TubNet2.Controllers
{
    public class PatientController : Controller
    {

        private TubDataBaseEntities db = new TubDataBaseEntities();
        private static ViewPatientsModel model;

        // GET: Patient
        public ActionResult PatientsTable()
        {
            if (model == null)
            {
                model = new ViewPatientsModel();
                model.collection = db.Patients
                    .Include(c => c.Gender).ToList();
                model.filter = new PatientsFilterModel();

            }
            else
            {
                model.collection = FilterPatient();
            }


            SelectList gender = new SelectList(db.Gender.ToList(), "gen_id", "gen_value");
            ViewBag.Gender = gender;
            SelectList diagnosis = new SelectList(db.Diagnosis, "diag_id", "diag_value");
            ViewBag.Diagnosis = diagnosis;
            SelectList type = new SelectList(db.Type, "type_id", "type_value");
            ViewBag.Type = type;
            SelectList bk = new SelectList(db.BK, "bk_id", "bk_value");
            ViewBag.BK = bk;
            SelectList dest = new SelectList(db.Destruction, "destr_id", "destr_value");
            ViewBag.Destruction = dest;
            return View(model);
        }

        [HttpPost]
        public ActionResult SetFilter(PatientsFilterModel f)
        {
            model.filter = f;
            return RedirectToAction("PatientsTable");
        }

        private List<Patients> FilterPatient()
        {
            PrepareFilter();
            PatientsFilterModel f = model.filter;
            var query = (from q in db.Patients select q);
            if (f.p_surname!=null)
            {
                query = query.Where(q => q.p_surname.Contains(f.p_surname));
            }
            if (f.p_name != null)
            {
                query = query.Where(q => q.p_name.Contains(f.p_name));
            }
            if (f.p_secname != null)
            {
                query = query.Where(q => q.p_secname.Contains(f.p_secname));
            }
            if (f.UseBirthday == true)
            {
                query = query.Where(q => q.p_birthday == f.p_birthday);
            }
            if (f.UseGender == true)
            {
                query = query.Where(q => q.p_genderId == f.p_genderId);
            }
            if (f.UseDiagnosis == true)
            {
                query = query.Where(q => q.p_diagnosisId == f.p_diagnosisId);
            }
            if (f.UseType == true)
            {
                query = query.Where(q => q.p_typeId == f.p_typeId);
            }
            if (f.UseBK == true)
            {
                query = query.Where(q => q.p_bkID == f.p_bkID);
            }
            if (f.UseDestruction == true)
            {
                query = query.Where(q => q.p_destructionId == f.p_destructionId);
            }
            return query.ToList();
        }

        private void PrepareFilter()
        {
            if (model.filter.p_surname != null)
            {
                model.filter.p_surname = model.filter.p_surname.Trim();
            }
            if (model.filter.p_name != null)
            {
                model.filter.p_name = model.filter.p_name.Trim();
            }
            if (model.filter.p_secname != null)
            {
                model.filter.p_secname = model.filter.p_secname.Trim();
            }
        }

        [HttpGet]
        public ActionResult AddPatient()
        {
            SelectList gender = new SelectList(db.Gender, "gen_id", "gen_value");
            ViewBag.Gender = gender;
            SelectList diagnosis = new SelectList(db.Diagnosis, "diag_id", "diag_value");
            ViewBag.Diagnosis = diagnosis;
            SelectList type = new SelectList(db.Type, "type_id", "type_value");
            ViewBag.Type = type;
            SelectList bk = new SelectList(db.BK, "bk_id", "bk_value");
            ViewBag.BK = bk;
            SelectList dest = new SelectList(db.Destruction, "destr_id", "destr_value");
            ViewBag.Destruction = dest;
            return View();
        }

        [HttpPost]
        public ActionResult AddPatient(Patients p)
        {
            if(ModelState.IsValid)
            {
                db.Patients.Add(p);
                db.SaveChanges();

                return RedirectToAction("PatientsTable");
            }
            else
            {
                return View(p);
            }
        }

        public ActionResult SinglePatient(int p_id = 0)
        {
           
            Patients pat = (from p in db.Patients where (p.p_id == p_id) select p).FirstOrDefault();
            if (pat==null)
            {
                return HttpNotFound();
            }
            return View(pat);
        }

        [HttpGet]
        public ActionResult SinglePatientEdit(int p_id = 0)
        {
            db = new TubDataBaseEntities();
            
            SelectList gender = new SelectList(db.Gender.ToList(), "gen_id", "gen_value");
            ViewBag.Gender = gender;
            SelectList diagnosis = new SelectList(db.Diagnosis, "diag_id", "diag_value");
            ViewBag.Diagnosis = diagnosis;
            SelectList type = new SelectList(db.Type, "type_id", "type_value");
            ViewBag.Type = type;
            SelectList bk = new SelectList(db.BK, "bk_id", "bk_value");
            ViewBag.BK = bk;
            SelectList dest = new SelectList(db.Destruction, "destr_id", "destr_value");
            ViewBag.Destruction = dest;

            Patients pat = (from p in db.Patients where (p.p_id == p_id) select p).FirstOrDefault();
            if (pat == null)
            {
                return HttpNotFound();
            }
            return View(pat);
        }

        [HttpPost]
        public ActionResult SinglePatientEdit(Patients update)
        {
            if (ModelState.IsValid)
            {
                Patients pat = (from p in db.Patients where p.p_id == update.p_id select p).FirstOrDefault();
                pat.p_surname = update.p_surname.Trim();
                pat.p_name = update.p_name.Trim();
                pat.p_secname = update.p_secname.Trim();
                pat.p_birthday = update.p_birthday;
                pat.p_genderId = update.p_genderId;
                pat.p_factAddress = update.p_factAddress;
                pat.p_regAddress = update.p_regAddress;
                pat.p_phones = update.p_phones;
                pat.p_diagnosisId = update.p_diagnosisId;
                pat.p_typeId = update.p_typeId;
                pat.p_bkID = update.p_bkID;
                pat.p_destructionId = update.p_destructionId;
                pat.p_otherDiseases = update.p_otherDiseases;
                pat.p_firstVisit = update.p_firstVisit;
                pat.p_lastVisit = update.p_lastVisit;
                pat.p_result = update.p_result;
                pat.p_komment = update.p_komment;
                db.SaveChanges();
                return RedirectToAction("PatientsTable");
            }
            else
            {
                return View(update);
            }
        }

        public ActionResult SinglePatientDelete(int p_id)
        {
            Patients pat = (from p in db.Patients where p.p_id == p_id select p).FirstOrDefault();
            db.Patients.Remove(pat);
            db.SaveChanges();

            return RedirectToAction("PatientsTable");
        }
    }
}