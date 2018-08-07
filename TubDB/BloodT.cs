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
    public class Blood : AbstractTest
    {

        public Blood(Patients _pat, DataGridView d, ComboBox box):base( _pat, d, box)
        {
            Renew();
        }

        public override void Renew()
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var bloodQuery = ctx.BlTest___Patient.Where(p => p.bltp_patid == pat.p_id&&p.bltp_state==state);
            bloodQuery.Load();
            data.DataSource = ctx.BlTest___Patient.Local.ToBindingList();
        }

        public override void RenewWithDate(DateTime date)
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var bloodQuery = ctx.BlTest___Patient.Where(p => p.bltp_patid == pat.p_id && p.bltp_state == state&&p.bltp_date == date.Date);
            bloodQuery.Load();
            data.DataSource = ctx.BlTest___Patient.Local.ToBindingList();
        }

        public override void Plan(DateTime date)
        {
            try
            {
                BlTest___Patient b = new BlTest___Patient();
                BloodTest test = new BloodTest();
                ctx.BloodTest.Add(test);
               
                b.bltp_patid = pat.p_id;
                b.bltp_state = (from c in ctx.State where (c.state_value == "заплановано") select c.state_id).FirstOrDefault();
                b.bltp_date = date.Date;
                b.bltp_testid = test.bltest_id;
                ctx.BlTest___Patient.Add(b);
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
            if (((BlTest___Patient)data.Current).bltp_date > DateTime.Today.Date && State() == 1)
            { }
            else
            {
                BloodTestForm f = new BloodTestForm(((BlTest___Patient)data.Current).bltp_testid, ((BlTest___Patient)data.Current).bltp_date, m);
                f.ShowDialog();
                Renew();
            }
        }

        public override void Delete()
        {
            ctx = new TubDataBaseEntities();
            ctx.BlTest___Patient.Load();
            var b = (from c in ctx.BlTest___Patient where (c.bltp_id == ((BlTest___Patient)data.Current).bltp_id) select c).FirstOrDefault();
            ctx.BlTest___Patient.Remove(b);
            ctx.SaveChanges();
            Renew();
        }
    }
}
