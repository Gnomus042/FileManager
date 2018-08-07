using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Data.Entity;
using System.Windows.Forms;

namespace TubDB
{
    class Hepatic:AbstractTest
    {
        public Hepatic(Patients _pat, DataGridView d, ComboBox box) : base(_pat, d, box)
        {
            Renew();
        }

        public override void Renew()
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var hepQuery = ctx.HepTest___Patient.Where(p => p.htp_patid == pat.p_id && p.htp_state == state);
            hepQuery.Load();
            data.DataSource = ctx.HepTest___Patient.Local.ToBindingList();
        }

        public override void RenewWithDate(DateTime date)
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var hepQuery = ctx.HepTest___Patient.Where(p => p.htp_patid == pat.p_id && p.htp_state == state&&p.htp_date == date.Date);
            hepQuery.Load();
            data.DataSource = ctx.HepTest___Patient.Local.ToBindingList();
        }

        public override void Plan(DateTime date)
        {
            try
            {
                HepTest___Patient b = new HepTest___Patient();
                HepaticTest test = new HepaticTest();
                ctx.HepaticTest.Add(test);

                b.htp_patid = pat.p_id;
                b.htp_state = (from c in ctx.State where (c.state_value == "заплановано") select c.state_id).FirstOrDefault();
                b.htp_date = date.Date;
                b.htp_testid = test.heptest_id;
                ctx.HepTest___Patient.Add(b);
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
            if (((HepTest___Patient)data.Current).htp_date > DateTime.Today.Date && State() == 1)
            {
            }
            else
            {
                HepatTestForm f = new HepatTestForm(((HepTest___Patient)data.Current).htp_testid, ((HepTest___Patient)data.Current).htp_date, m);
                f.ShowDialog();
                Renew();
            }
        }

        public override void Delete()
        {
            ctx = new TubDataBaseEntities();
            ctx.HepTest___Patient.Load();
            var b = (from c in ctx.HepTest___Patient where (c.htp_id == ((HepTest___Patient)data.Current).htp_id) select c).FirstOrDefault();
            ctx.HepTest___Patient.Remove(b);
            ctx.SaveChanges();
            Renew();
        }
    }


}
