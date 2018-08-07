using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLibrary;
using System.Data.Entity;


namespace TubNet2.ControllerHelpers
{
    public class ConsultationHelper:TestHelper
    {
        TubDataBaseEntities db = new TubDataBaseEntities();

        public void PlanNewTest(DateTime date, int pid)
        {
            Consult___Patient bl = new Consult___Patient();
            bl.cp_state = (from q in db.State
                             where q.state_value == "заплановано"
                             select q.state_id).FirstOrDefault();
            bl.cp_date = date;
            Consultation test = new Consultation();
            
            db.Consultation.Add(test);
            bl.cp_patid = pid;
            bl.cp_consid = test.cons_id;
            db.Consult___Patient.Add(bl);
            db.SaveChanges();
        }


        public void PlanNewTest(DateTime date, int type, int pid)
        {
            Consult___Patient bl = new Consult___Patient();
            bl.cp_state = (from q in db.State
                           where q.state_value == "заплановано"
                           select q.state_id).FirstOrDefault();
            bl.cp_date = date;
            Consultation test = new Consultation();
            test.cons_type = type;
            db.Consultation.Add(test);
            bl.cp_patid = pid;
            bl.cp_consid = test.cons_id;
            db.Consult___Patient.Add(bl);
            db.SaveChanges();
        }

        public int DeleteTest(int id)
        {
            Consult___Patient bl = (from q in db.Consult___Patient
                                       where (q.cp_id == id)
                                       select q).FirstOrDefault();
            int testid = bl.cp_consid;
            db.Consult___Patient.Remove(bl);
            db.SaveChanges();
            Consultation test = (from q in db.Consultation
                               where q.cons_id == testid
                               select q).FirstOrDefault();
            if (test != null)
            {
                db.Consultation.Remove(test);
                db.SaveChanges();
            }
            return testid;
        }

        public object GetActiveTest(int id)
        {
            Consultation test = (from q in db.Consultation
                               where q.cons_id == id
                               select q).FirstOrDefault();
            return test;
        }

        public string GetActiveTestDate(int id)
        {
           string s = (from q in db.Consult___Patient
                    where q.cp_consid == id
                    select q.cp_date).FirstOrDefault().ToShortDateString();
            return s;
        }

        public object GetSortedCollection(string sort, int p_id)
        {
            return (from b in db.Consult___Patient.Include(q => q.Consultation)
                    where b.cp_patid == p_id && b.State.state_value == sort
                    orderby b.cp_date
                    select b).ToList();
        }

        public object GetSortedCollection(string sort, int p_id, DateTime date)
        {
            List<Consult___Patient> list = (from b in db.Consult___Patient.Include(q => q.Consultation)
                                               where b.cp_patid == p_id && b.State.state_value == sort
                                               orderby b.cp_date
                                               select b).ToList();
            return list.Where(q => q.cp_date.Date == date);
        }

        public void UpdateTest(object o)
        {
            Consultation b = o as Consultation;
            Consultation oldb = (from q in db.Consultation
                               where q.cons_id == b.cons_id
                               select q).FirstOrDefault();
            oldb.cons_komment = b.cons_komment;
          
            ChangeStateToClosed(oldb.cons_id);
            db.SaveChanges();
        }

        private void ChangeStateToClosed(int id)
        {
            Consult___Patient bp = (from q in db.Consult___Patient
                                       where q.cp_consid == id
                                       select q).FirstOrDefault();
            bp.cp_state = (from q in db.State
                             where q.state_value == "завершено"
                             select q.state_id).FirstOrDefault();
            db.SaveChanges();
        }
    }
}