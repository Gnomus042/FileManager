using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLibrary;
using System.Web.Mvc;

namespace TubNet2
{
    public static class TestsDateConfig
    {
        public static void RefreshTests()
        {
            TubDataBaseEntities db = new TubDataBaseEntities();
            List<BlTest___Patient> blood = (from q in db.BlTest___Patient
                                            where q.State.state_value == "заплановано"
                                            select q).ToList();
            foreach (BlTest___Patient b in blood)
            {
                if (b.bltp_date.Date < DateTime.Now.Date)
                {
                    b.bltp_state = (from q in db.State where q.state_value== "пропущено" select q.state_id).FirstOrDefault();
                }
            }
            List<UrTest__Patient> urina = (from q in db.UrTest__Patient
                                           where q.State.state_value == "заплановано"
                                           select q).ToList();
            foreach (UrTest__Patient u in urina)
            {
                if (u.utp_date.Date < DateTime.Now.Date)
                {
                    u.utp_state = (from q in db.State where q.state_value == "пропущено" select q.state_id).FirstOrDefault();
                }
            }
            List<HepTest___Patient> hepat = (from q in db.HepTest___Patient
                                             where q.State.state_value == "заплановано"
                                             select q).ToList();
            foreach (HepTest___Patient h in hepat)
            {
                if (h.htp_date.Date < DateTime.Now.Date)
                {
                    h.htp_state = (from q in db.State where q.state_value == "пропущено" select q.state_id).FirstOrDefault();
                }
            }
            List<SputumTest___Patient> sputum = (from q in db.SputumTest___Patient
                                                 where q.State.state_value == "заплановано"
                                                 select q).ToList();
            foreach (SputumTest___Patient s in sputum)
            {
                if (s.sptp_date.Date < DateTime.Now.Date)
                {
                    s.sptp_state = (from q in db.State where q.state_value == "пропущено" select q.state_id).FirstOrDefault();
                }
            }
            List<Consult___Patient> consult = (from q in db.Consult___Patient
                                               where q.State.state_value == "заплановано"
                                               select q).ToList();
            foreach (Consult___Patient c in consult)
            {
                if (c.cp_date.Date < DateTime.Now.Date)
                {
                    c.cp_state = (from q in db.State where q.state_value == "пропущено" select q.state_id).FirstOrDefault();
                }
            }
            db.SaveChanges();
        }
    }
}