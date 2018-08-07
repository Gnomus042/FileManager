using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLibrary;
using System.Data.Entity;

namespace TubNet2.ControllerHelpers
{
    public class SputumHelper:TestHelper
    {
        TubDataBaseEntities db = new TubDataBaseEntities();

        public void PlanNewTest(DateTime date, int pid)
        {
            SputumTest___Patient bl = new SputumTest___Patient();
            bl.sptp_state = (from q in db.State
                            where q.state_value == "заплановано"
                            select q.state_id).FirstOrDefault();
            bl.sptp_date = date;
            SputumTest test = new SputumTest();
            db.SputumTest.Add(test);
            bl.sptp_patid = pid;
            bl.sptp_testid = test.sputtest_id;
            db.SputumTest___Patient.Add(bl);
            db.SaveChanges();
        }

        public int DeleteTest(int id)
        {
            SputumTest___Patient bl = (from q in db.SputumTest___Patient
                                    where (q.sptp_id == id)
                                    select q).FirstOrDefault();
            int testid = bl.sptp_testid;
            db.SputumTest___Patient.Remove(bl);
            db.SaveChanges();
            SputumTest test = (from q in db.SputumTest
                                where q.sputtest_id == testid
                                select q).FirstOrDefault();
            if (test != null)
            {
                db.SputumTest.Remove(test);
                db.SaveChanges();
            }
            return testid;
        }

        public object GetActiveTest(int id)
        {
            SputumTest test = (from q in db.SputumTest
                                where q.sputtest_id == id
                                select q).FirstOrDefault();
            return test;
        }

        public string GetActiveTestDate(int id)
        {
            return (from q in db.SputumTest___Patient
                    where q.sptp_id == id
                    select q.sptp_date).FirstOrDefault().ToShortDateString();
        }

        public object GetSortedCollection(string sort, int p_id)
        {
            return (from b in db.SputumTest___Patient.Include(q => q.SputumTest)
                    where b.sptp_patid == p_id && b.State.state_value == sort
                    orderby b.sptp_date
                    select b).ToList();
        }

        public object GetSortedCollection(string sort, int p_id, DateTime date)
        {
            List<SputumTest___Patient> list = (from b in db.SputumTest___Patient.Include(q => q.SputumTest)
                                            where b.sptp_patid == p_id && b.State.state_value == sort
                                            orderby b.sptp_date
                                            select b).ToList();
            return list.Where(q => q.sptp_date.Date == date);
        }

        public void UpdateTest(object o)
        {
            SputumTest b = o as SputumTest;
            SputumTest oldb = (from q in db.SputumTest
                                where q.sputtest_id == b.sputtest_id
                                select q).FirstOrDefault();
            oldb.sputtest_inocul = b.sputtest_inocul;
            oldb.sputtest_scopy = b.sputtest_scopy;
            ChangeStateToClosed(oldb.sputtest_id);
            db.SaveChanges();
        }

        private void ChangeStateToClosed(int id)
        {
            SputumTest___Patient bp = (from q in db.SputumTest___Patient
                                    where q.sptp_testid == id
                                    select q).FirstOrDefault();
            bp.sptp_state = (from q in db.State
                            where q.state_value == "завершено"
                            select q.state_id).FirstOrDefault();
            db.SaveChanges();
        }
    }
}
