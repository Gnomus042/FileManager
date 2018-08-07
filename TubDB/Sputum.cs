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
    class Sputum:AbstractTest
    {

        public Sputum(Patients _pat, DataGridView d, ComboBox box) : base(_pat, d, box)
        {
            Renew();
        }

        public override void Renew()
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var sputQuery = ctx.SputumTest___Patient.Where(p => p.sptp_patid == pat.p_id && p.sptp_state == state);
            sputQuery.Load();
            data.DataSource = ctx.SputumTest___Patient.Local.ToBindingList();
        }

        public override void RenewWithDate(DateTime date)
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var sputQuery = ctx.SputumTest___Patient.Where(p => p.sptp_patid == pat.p_id && p.sptp_state == state && p.sptp_date == date.Date);
            sputQuery.Load();
            data.DataSource = ctx.SputumTest___Patient.Local.ToBindingList();
        }

        public override void Plan(DateTime date)
        {
            try
            {
                SputumTest___Patient b = new SputumTest___Patient();
                SputumTest test = new SputumTest();
                ctx.SputumTest.Add(test);

                b.sptp_patid = pat.p_id;
                b.sptp_state = (from c in ctx.State where (c.state_value == "заплановано") select c.state_id).FirstOrDefault();
                b.sptp_date = date.Date;
                b.sptp_testid = test.sputtest_id;
                ctx.SputumTest___Patient.Add(b);
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
            if (((SputumTest___Patient)data.Current).sptp_date > DateTime.Today.Date && State() == 1)
            {
            }
            else
            {
                SputumTestForm f = new SputumTestForm(((SputumTest___Patient)data.Current).sptp_testid, ((SputumTest___Patient)data.Current).sptp_date, m);
                f.ShowDialog();
                Renew();
            }
        }

        public override void Delete()
        {
            ctx = new TubDataBaseEntities();
            ctx.SputumTest___Patient.Load();
            var b = (from c in ctx.SputumTest___Patient where (c.sptp_id== ((SputumTest___Patient)data.Current).sptp_id) select c).FirstOrDefault();
            ctx.SputumTest___Patient.Remove(b);
            ctx.SaveChanges();
            Renew();
        }
    }
}
