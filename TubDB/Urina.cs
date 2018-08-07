using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Windows.Forms;
using System.Data.Entity;

namespace TubDB
{
    class Urina:AbstractTest
    {
        public Urina(Patients _pat, DataGridView d, ComboBox box) : base(_pat, d, box)
        {
            Renew();
        }

        public override void Renew()
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var urinaQuery = ctx.UrTest__Patient.Where(p => p.utp_patid == pat.p_id && p.utp_state == state);
            urinaQuery.Load();
            data.DataSource = ctx.UrTest__Patient.Local.ToBindingList();
        }

        public override void RenewWithDate(DateTime date)
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var urinaQuery = ctx.UrTest__Patient.Where(p => p.utp_patid == pat.p_id && p.utp_state == state&&p.utp_date==date.Date);
            urinaQuery.Load();
            data.DataSource = ctx.UrTest__Patient.Local.ToBindingList();
        }

        public override void Plan(DateTime date)
        {
            try
            {
                UrTest__Patient u = new UrTest__Patient();
                UrineTest test = new UrineTest();
                ctx.UrineTest.Add(test);

                u.utp_patid = pat.p_id;
                u.utp_state = (from c in ctx.State where (c.state_value == "заплановано") select c.state_id).FirstOrDefault();
                u.utp_date = date.Date;
                u.utp_testid = test.urtest_id;
                ctx.UrTest__Patient.Add(u);
                ctx.SaveChanges();
                Renew();
            }
            catch
            {
                MessageBox.Show("Помилка при плануванні");
            }
        }

        public override void Show(mode m)
        {
            if (((UrTest__Patient)data.Current).utp_date > DateTime.Today.Date && State() == 1)
            {
            }
            else
            {
                UrinaTestForm f = new UrinaTestForm((int)(((UrTest__Patient)data.Current).utp_testid), ((UrTest__Patient)data.Current).utp_date, m);
                f.ShowDialog();
                Renew();
            }
        }

        public override void Delete()
        {
            ctx = new TubDataBaseEntities();
            ctx.UrTest__Patient.Load();
            var b = (from c in ctx.UrTest__Patient where (c.utp_id == ((UrTest__Patient)data.Current).utp_id) select c).FirstOrDefault();
            ctx.UrTest__Patient.Remove(b);
            ctx.SaveChanges();
            Renew();
        }

    }
}
