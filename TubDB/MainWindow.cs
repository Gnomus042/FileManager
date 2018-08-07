using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.EntityClient;

namespace TubDB
{
    public partial class MainWindow : Form
    {

        private DataLibrary.TubDataBaseEntities ctx;

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //settings
            this.PatientsListDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsListDGV_CellContentClick);

            ctx = new DataLibrary.TubDataBaseEntities();
           
            ctx.Gender.Load();
            this.genderBindingSource.DataSource = ctx.Gender.Local.ToBindingList();

            filter.Init(PatientsListDGV);
            SetLosed();
        }

        private void SetLosed()
        {
            int st = (from c in ctx.State where (c.state_value == "заплановано") select c.state_id).FirstOrDefault();
            var query = (from c in ctx.BlTest___Patient where (c.bltp_date < DateTime.Today.Date && c.bltp_state == st) select c).ToList();
            foreach (var q in query)
            {
                q.bltp_state = (from c in ctx.State where (c.state_value == "пропущено") select c.state_id).FirstOrDefault();
            }
            ctx.SaveChanges();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            PatientForm form = new PatientForm(ctx);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                filter.DGVrenew();
            }
        }

        private void PatientsListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientForm form = new PatientForm((DataLibrary.Patients)patientsBindingSource.Current, new TubDataBaseEntities());
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel||form.DialogResult==DialogResult.OK)
            {
                filter.DGVrenew();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }
    }
}
