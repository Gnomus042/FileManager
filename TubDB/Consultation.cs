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
    class Consultations:AbstractTest
    {

        private ComboBox doc;

        public Consultations(Patients _pat, DataGridView d, ComboBox box, ComboBox _doc) : base(_pat, d, box)
        {
            Renew();
            doc = _doc;
        }

        public override void Renew()
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var consQuery = ctx.Consult___Patient.Where(p => p.cp_patid == pat.p_id && p.cp_state == state);
            consQuery.Load();
            data.DataSource = ctx.Consult___Patient.Local.ToBindingList();
        }

        public override void RenewWithDate(DateTime date)
        {
            int state = State();
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            var consQuery = ctx.Consult___Patient.Where(p => p.cp_patid == pat.p_id && p.cp_state == state&& p.cp_date == date.Date);
            consQuery.Load();
            data.DataSource = ctx.Consult___Patient.Local.ToBindingList();
        }

        public override void Plan(DateTime date)
        {
            try
            {
                Consult___Patient b = new Consult___Patient();
                Consultation test = new Consultation();
                test.cons_type = (int)doc.SelectedValue;
                ctx.Consultation.Add(test);

                b.cp_patid = pat.p_id;
                b.cp_state = (from c in ctx.State where (c.state_value == "заплановано") select c.state_id).FirstOrDefault();
                b.cp_date = date.Date;
                b.cp_consid = test.cons_id;
                ctx.Consult___Patient.Add(b);
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

            if (((Consult___Patient)data.Current).cp_date > DateTime.Today.Date && State() == 1)
            {
            }
            else
            {
                ConsultationForm f = new ConsultationForm(((Consult___Patient)data.Current).cp_consid, ((Consult___Patient)data.Current).cp_date, (int)doc.SelectedValue, m);
                f.ShowDialog();
                Renew();
            }
        }

        public override void Delete()
        {
            ctx = new TubDataBaseEntities();
            ctx.Consult___Patient.Load();
            var b = (from c in ctx.Consult___Patient where (c.cp_consid == ((Consult___Patient)data.Current).cp_consid) select c).FirstOrDefault();
            ctx.Consult___Patient.Remove(b);
            ctx.SaveChanges();
            Renew();
        }

    }
}
