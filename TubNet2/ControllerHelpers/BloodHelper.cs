using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLibrary;
using System.Data.Entity;

namespace TubNet2.ControllerHelpers
{
    public class BloodHelper: TestHelper
    {
        TubDataBaseEntities db = new TubDataBaseEntities();

        public void PlanNewTest(DateTime date, int pid)
        {
            BlTest___Patient bl = new BlTest___Patient();
            bl.bltp_state = (from q in db.State where q.state_value == "заплановано" select q.state_id).FirstOrDefault();
            bl.bltp_date = date;
            BloodTest test = new BloodTest();
            db.BloodTest.Add(test);
            bl.bltp_patid = pid;
            bl.bltp_testid = test.bltest_id;
            db.BlTest___Patient.Add(bl);
            db.SaveChanges();
        }

        public int DeleteTest(int id)
        {
            BlTest___Patient bl = (from q in db.BlTest___Patient where (q.bltp_id == id) select q).FirstOrDefault();
            int testid = bl.bltp_testid;
            db.BlTest___Patient.Remove(bl);
            db.SaveChanges();
            BloodTest test = (from q in db.BloodTest where q.bltest_id == testid select q).FirstOrDefault();
            if (test != null)
            {
                db.BloodTest.Remove(test);
                db.SaveChanges();
            }
            return testid;
        }

        public object GetActiveTest(int id)
        {
            BloodTest test = (from q in db.BloodTest where q.bltest_id == id select q).FirstOrDefault();
            return test;
        }

        public string GetActiveTestDate(int id)
        {
            return (from q in db.BlTest___Patient where q.bltp_testid == id select q.bltp_date).FirstOrDefault().ToShortDateString();
        }

        public object GetSortedCollection(string sort, int p_id)
        {
            return (from b in db.BlTest___Patient.Include(q => q.BloodTest) where b.bltp_patid == p_id && b.State.state_value == sort orderby b.bltp_date select b).ToList();
        }

        public object GetSortedCollection(string sort, int p_id, DateTime date)
        {
            List<BlTest___Patient> list = (from b in db.BlTest___Patient.Include(q => q.BloodTest)
                                           where b.bltp_patid == p_id && b.State.state_value == sort
                                           orderby b.bltp_date
                                           select b).ToList();
            return list.Where(q => q.bltp_date.Date == date);
        }


        public void UpdateTest(object o)
        {
            BloodTest b = o as BloodTest;
            BloodTest oldb = (from q in db.BloodTest where q.bltest_id == b.bltest_id select q).FirstOrDefault();
            oldb.bltest_er = b.bltest_er;
            oldb.bltest_gran = b.bltest_gran;
            oldb.bltest_hem = b.bltest_hem;
            oldb.bltest_leu = b.bltest_leu;
            oldb.bltest_limf = b.bltest_limf;
            oldb.bltest_mono = b.bltest_mono;
            oldb.bltest_soy = b.bltest_soy;
            ChangeStateToClosed(oldb.bltest_id);
            db.SaveChanges();
        }

        private void ChangeStateToClosed(int id)
        {
            BlTest___Patient bp = (from q in db.BlTest___Patient where q.bltp_testid == id select q).FirstOrDefault();
            bp.bltp_state = (from q in db.State where q.state_value == "завершено" select q.state_id).FirstOrDefault();
            db.SaveChanges();
        }
    }
}