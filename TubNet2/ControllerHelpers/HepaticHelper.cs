using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLibrary;
using System.Data.Entity;

namespace TubNet2.ControllerHelpers
{
    public class HepaticHelper:TestHelper
    {
        TubDataBaseEntities db = new TubDataBaseEntities();

        public void PlanNewTest(DateTime date, int pid)
        {
            HepTest___Patient bl = new HepTest___Patient();
            bl.htp_state = (from q in db.State
                            where q.state_value == "заплановано"
                            select q.state_id).FirstOrDefault();
            bl.htp_date = date;
            HepaticTest test = new HepaticTest();
            db.HepaticTest.Add(test);
            bl.htp_patid = pid;
            bl.htp_testid = test.heptest_id;
            db.HepTest___Patient.Add(bl);
            db.SaveChanges();
        }

        public int DeleteTest(int id)
        {
            HepTest___Patient bl = (from q in db.HepTest___Patient
                                    where (q.htp_id == id)
                                    select q).FirstOrDefault();
            int testid = bl.htp_testid;
            db.HepTest___Patient.Remove(bl);
            db.SaveChanges();
            HepaticTest test = (from q in db.HepaticTest
                                where q.heptest_id == testid
                                select q).FirstOrDefault();
            if (test != null)
            {
                db.HepaticTest.Remove(test);
                db.SaveChanges();
            }
            return testid;
        }

        public object GetActiveTest(int id)
        {
            HepaticTest test = (from q in db.HepaticTest
                                where q.heptest_id == id
                                select q).FirstOrDefault();
            return test;
        }

        public string GetActiveTestDate(int id)
        {
            return (from q in db.HepTest___Patient
                    where q.htp_id == id select q.htp_date).FirstOrDefault().ToShortDateString();
        }

        public object GetSortedCollection(string sort, int p_id)
        {
            return (from b in db.HepTest___Patient.Include(q => q.HepaticTest)
                    where b.htp_patid == p_id && b.State.state_value == sort
                    orderby b.htp_date
                    select b).ToList();
        }

        public object GetSortedCollection(string sort, int p_id, DateTime date)
        {
            List<HepTest___Patient> list = (from b in db.HepTest___Patient.Include(q => q.HepaticTest)
                                           where b.htp_patid == p_id && b.State.state_value == sort
                                           orderby b.htp_date
                                           select b).ToList();
            return list.Where(q => q.htp_date.Date == date);
        }

        public void UpdateTest(object o)
        {
            HepaticTest b = o as HepaticTest;
            HepaticTest oldb = (from q in db.HepaticTest
                              where q.heptest_id == b.heptest_id
                                select q).FirstOrDefault();
            oldb.heptest_bilir = b.heptest_bilir;
            oldb.heptest_kreat = b.heptest_kreat;
            oldb.heptest_timil = b.heptest_timil;
            oldb.heptest_uricasid = b.heptest_uricasid;
            oldb.heptest_alt = b.heptest_alt;
            oldb.heptest_ast = b.heptest_ast;
            ChangeStateToClosed(oldb.heptest_id);
            db.SaveChanges();
        }

        private void ChangeStateToClosed(int id)
        {
            HepTest___Patient bp = (from q in db.HepTest___Patient
                                    where q.htp_testid == id
                                    select q).FirstOrDefault();
            bp.htp_state = (from q in db.State
                            where q.state_value == "завершено"
                            select q.state_id).FirstOrDefault();
            db.SaveChanges();
        }
    }
}
