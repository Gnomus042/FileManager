using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLibrary;
using System.Data.Entity;

namespace TubNet2.ControllerHelpers
{
    public class UrinaHelper:TestHelper
    {
        TubDataBaseEntities db = new TubDataBaseEntities();

        public void PlanNewTest(DateTime date, int pid)
        {
            UrTest__Patient ur = new UrTest__Patient();
            ur.utp_state = (from q in db.State
                            where q.state_value == "заплановано"
                            select q.state_id).FirstOrDefault();
            ur.utp_date = date;
            UrineTest test = new UrineTest();
            db.UrineTest.Add(test);
            ur.utp_patid = pid;
            ur.utp_testid = test.urtest_id;
            db.UrTest__Patient.Add(ur);
            db.SaveChanges();
        }

        public int DeleteTest(int id)
        {
            UrTest__Patient ur = (from q in db.UrTest__Patient
                                  where (q.utp_id == id)
                                  select q).FirstOrDefault();
            int testid = ur.utp_testid ?? default(int);
            db.UrTest__Patient.Remove(ur);
            db.SaveChanges();
            UrineTest test = (from q in db.UrineTest
                              where q.urtest_id == testid
                              select q).FirstOrDefault();
            if (test != null)
            {
                db.UrineTest.Remove(test);
                db.SaveChanges();
            }
            return testid;
        }

        public object GetActiveTest(int id)
        {
            UrineTest test = (from q in db.UrineTest
                              where q.urtest_id == id
                              select q).FirstOrDefault();
            return test;
        }

        public string GetActiveTestDate(int id)
        {
            return (from q in db.UrTest__Patient
                    where q.utp_testid == id
                    select q.utp_date).FirstOrDefault().ToShortDateString();
        }

        public object GetSortedCollection(string sort, int p_id)
        {
            return (from b in db.UrTest__Patient.Include(q => q.UrineTest)
                    where b.utp_patid == p_id && b.State.state_value == sort
                    orderby b.utp_date
                    select b).ToList();
        }

        public object GetSortedCollection(string sort, int p_id, DateTime date)
        {
            List<UrTest__Patient> list = (from b in db.UrTest__Patient.Include(q => q.UrineTest)
                                           where b.utp_patid == p_id && b.State.state_value == sort
                                           orderby b.utp_date
                                           select b).ToList();
            return list.Where(q => q.utp_date.Date == date);
        }


        public void UpdateTest(object o)
        {
            UrineTest b = o as UrineTest;
            UrineTest oldb = (from q in db.UrineTest where q.urtest_id == b.urtest_id select q).FirstOrDefault();
            oldb.urtest_protein = b.urtest_protein;
            oldb.urtest_sugar = b.urtest_sugar;
            oldb.urtest_leumin = b.urtest_leumin;
            oldb.urtest_leumax = b.urtest_leumax;
            oldb.urtest_ermin = b.urtest_ermin;
            oldb.urtest_ermax = b.urtest_ermax;
            ChangeStateToClosed(oldb.urtest_id);
            db.SaveChanges();
        }

        private void ChangeStateToClosed(int id)
        {
            UrTest__Patient bp = (from q in db.UrTest__Patient where q.utp_testid == id select q).FirstOrDefault();
            bp.utp_state = (from q in db.State where q.state_value == "завершено" select q.state_id).FirstOrDefault();
            db.SaveChanges();
        }
    }
}