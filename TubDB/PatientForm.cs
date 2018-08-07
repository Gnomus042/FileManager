using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataLibrary;

namespace TubDB
{
    public partial class PatientForm : Form
    {
        mode m;
        private DataLibrary.TubDataBaseEntities ctx;
        DataLibrary.Patients patient;

        public PatientForm(DataLibrary.Patients _patient, DataLibrary.TubDataBaseEntities _ctx)
        {
            InitializeComponent();
            m = mode.View;
            patient = _patient;
         
            ctx = _ctx;
        }

        public PatientForm(DataLibrary.TubDataBaseEntities _ctx)
        {
            InitializeComponent();
            m = mode.Create;
            ctx = _ctx;
        }

      

        private void PatientForm_Load(object sender, EventArgs e)
        {
            
            ctx.Gender.Load();
            ctx.Diagnosis.Load();
            ctx.Type.Load();
            ctx.BK.Load();
            ctx.Destruction.Load();
            ctx.Patients.Load();

            this.genderBindingSource.DataSource = ctx.Gender.Local.ToBindingList();
            this.diagnosisBindingSource.DataSource = ctx.Diagnosis.Local.ToBindingList();
            this.typeBindingSource.DataSource = ctx.Type.Local.ToBindingList();
            this.bKBindingSource.DataSource = ctx.BK.Local.ToBindingList();
            this.destructionBindingSource.DataSource = ctx.Destruction.Local.ToBindingList();
            Configure();
        }

        private void Configure()
        {

            BirtdayDT.MaxDate = DateTime.Today;
            BegDT.MaxDate = DateTime.Today;
            EndDT.MaxDate = DateTime.Today;
            if (m == mode.Create)
            {
               ModeLabel.Text = "Новий пацієнт";
                SavePatientBut.Enabled = false;
                SavePatientBut.Visible = false;
                DeletePatientBut.Enabled = false;
                DeletePatientBut.Visible = false;
            }
            else
            {
                ModeLabel.Text = "Редаування";
                LoadPatientInForm();
                CreatePatientBut.Enabled = false;
                CreatePatientBut.Visible = false;
                SavePatientBut.Enabled =true;
                SavePatientBut.Visible = true;
                DeletePatientBut.Enabled = true;
                DeletePatientBut.Visible = true;
            }
            
        }

        private void LoadPatientInForm()
        {

            SurnameTB.Text = patient.p_surname;
            NameTB.Text = patient.p_name;
            SecnameTB.Text = patient.p_secname;
            GenderCB.SelectedValue = patient.p_genderId;
            if (patient.p_birthday != null)
            {
                BirtdayDT.Value = (DateTime)patient.p_birthday;
            }
            PhoneTB.Text = patient.p_phones;
            FactAddRTB.Text = patient.p_factAddress;
            RegAddRTB.Text = patient.p_regAddress;

            DiagnosisCB.SelectedValue = patient.p_diagnosisId;
            TypeCB.SelectedValue = patient.p_typeId;
            BKCB.SelectedValue = patient.p_bkID;
            DestrCB.SelectedValue = patient.p_destructionId;
            OtherDisTB.Text = patient.p_otherDiseases;
            if (patient.p_firstVisit != null)
            {
                BegDT.Value = (DateTime)patient.p_firstVisit;
            }
            if (patient.p_lastVisit != null)
            {
                EndDT.Value = (DateTime)patient.p_lastVisit;
            }
            CommentRTB.Text = patient.p_komment;
            ResultTB.Text = patient.p_result;
            LoadTests();
        }
 

        private void GenderCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadTests()
        {
            int planed = (from q in ctx.State where q.state_value == "заплановано" select q.state_id).FirstOrDefault();
            int losed = (from q in ctx.State where q.state_value == "пропущено" select q.state_id).FirstOrDefault();

            int PlBloodCount = (from c in ctx.BlTest___Patient where (c.bltp_patid == patient.p_id && c.bltp_date == DateTime.Today && c.bltp_state == planed) select c).Count();
            int MiBloodCount = (from c in ctx.BlTest___Patient where (c.bltp_patid == patient.p_id && c.bltp_state == losed) select c).Count();
            TestsDGV.Rows.Add("Аналіз крові", PlBloodCount, MiBloodCount);

            int PlUrinaCount = (from c in ctx.UrTest__Patient where (c.utp_patid == patient.p_id && c.utp_date == DateTime.Today && c.utp_state == planed) select c).Count();
            int MiUrinaCount = (from c in ctx.UrTest__Patient where (c.utp_patid == patient.p_id && c.utp_state == losed) select c).Count();
            TestsDGV.Rows.Add("Аналіз сечі", PlUrinaCount, MiUrinaCount);

            int PlHepatCount = (from c in ctx.HepTest___Patient where (c.htp_patid == patient.p_id && c.htp_date == DateTime.Today && c.htp_state == planed) select c).Count();
            int MiHepatCount = (from c in ctx.HepTest___Patient where (c.htp_patid == patient.p_id && c.htp_state == losed) select c).Count();
            TestsDGV.Rows.Add("Печінкові проби", PlHepatCount, MiHepatCount);

            int PlSputumCount = (from c in ctx.SputumTest___Patient where (c.sptp_patid == patient.p_id && c.sptp_date == DateTime.Today && c.sptp_state == planed) select c).Count();
            int MiSputumCount = (from c in ctx.SputumTest___Patient where (c.sptp_patid == patient.p_id && c.sptp_state == losed) select c).Count();
            TestsDGV.Rows.Add("Аналіз мокроти", PlSputumCount, MiSputumCount);

            int PlConsCount = (from c in ctx.Consult___Patient where (c.cp_patid == patient.p_id && c.cp_date == DateTime.Today && c.cp_state == planed) select c).Count();
            int MiConsCount = (from c in ctx.Consult___Patient where (c.cp_patid == patient.p_id && c.cp_state == losed) select c).Count();
            TestsDGV.Rows.Add("Консультації", PlConsCount, MiConsCount);
        }

        private void SavePatientBut_Click(object sender, EventArgs e)
        {
            UpdatePatient();
        }

        private void UpdatePatient()
        {
                var pat = ctx.Patients.Where(c => c.p_id == patient.p_id).FirstOrDefault();
                LoadFormInPatient(pat);
                ctx.SaveChanges();
                MessageBox.Show("Зміни збережено");
        }

        private void LoadFormInPatient(Patients pat)
        {
            if (NameTB.Text.Trim() != "")
            {
                pat.p_name = NameTB.Text;
            }
            if (SurnameTB.Text.Trim() != "")
            {
                pat.p_surname = SurnameTB.Text;
            }
            if (SecnameTB.Text.Trim() != "")
            {
                pat.p_secname = SecnameTB.Text;
            }
           
            pat.p_genderId = (int)GenderCB.SelectedValue;

            if (BirtdayDT.Value.Date != DateTime.Today.Date)
            {
                pat.p_birthday = BirtdayDT.Value.Date;
            }
            if (PhoneTB.Text.Trim() != "")
            {
                pat.p_phones = PhoneTB.Text;
            }
            if (FactAddRTB.Text.Trim() != "")
            {
                pat.p_factAddress = FactAddRTB.Text;
            }
            if (RegAddRTB.Text.Trim() != "")
            {
                pat.p_regAddress = RegAddRTB.Text;
            }
            pat.p_diagnosisId = (int)DiagnosisCB.SelectedValue;
            pat.p_typeId = (int)TypeCB.SelectedValue;
            pat.p_bkID = (int)BKCB.SelectedValue;
            pat.p_destructionId = (int)DestrCB.SelectedValue;
            if (OtherDisTB.Text.Trim() != "")
            {
                pat.p_otherDiseases = OtherDisTB.Text;
            }

            if (BegDT.Value.Date != DateTime.Today.Date || m == mode.Create)
            {
                pat.p_firstVisit = BegDT.Value.Date;
            }
            if (EndDT.Value.Date != DateTime.Today.Date)
            {
                pat.p_lastVisit = EndDT.Value.Date;
            }
            if (CommentRTB.Text.Trim() != "")
            {
                pat.p_komment = CommentRTB.Text;
            }
            if (ResultTB.Text.Trim()!= "")
            {
                pat.p_result = ResultTB.Text;
            }
        }

        private void CreatePatientBut_Click(object sender, EventArgs e)
        {
            //try
            //{
                Patients pat = new Patients();
                LoadFormInPatient(pat);
                ctx.Patients.Add(pat);
                ctx.SaveChanges();
                MessageBox.Show("Пацієнта створено");
                patient = pat;
                m = mode.Redact;
                Configure();
            //}
            //catch
            //{
                MessageBox.Show("Для створення нового пацієнта необхідно заповнити прізвище та ім'я");
                SurnameTB.Select();
           // }
        }

        private void DeletePatientBut_Click(object sender, EventArgs e)
        {

            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            ctx.Patients.Load();
            DialogResult d = MessageBox.Show("Ви впевнені, що бажаєте видалити цього пацієнта?", "Видалення", MessageBoxButtons.YesNo);
            if (d==DialogResult.Yes)
            {
                var p = (from c in ctx.Patients where (c.p_id == patient.p_id) select c).FirstOrDefault();
                int a = (from c in ctx.BlTest___Patient where (c.bltp_patid == patient.p_id) select c).Count()+
                    (from c in ctx.UrTest__Patient where (c.utp_patid== patient.p_id) select c).Count()+
                    (from c in ctx.HepTest___Patient where (c.htp_patid == patient.p_id) select c).Count()+
                    (from c in ctx.SputumTest___Patient where (c.sptp_patid == patient.p_id) select c).Count()+
                    (from c in ctx.Consult___Patient where (c.cp_patid== patient.p_id) select c).Count();
                
                if (a == 0)
                {
                    ctx.Patients.Remove(p);
                    ctx.SaveChanges();
                    MessageBox.Show("Пацієнта видалено");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("До пацієнта прив'язані аналізи, видаляти заборонено");
                }
               
                
            }
        }

        

        private void TestsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AnalysisShowBut_Click(object sender, EventArgs e)
        {
            AnalysisViewer v = new AnalysisViewer(ctx, patient);
            v.ShowDialog();
            if (v.DialogResult==DialogResult.OK)
            {
                LoadTests();
            }
        }
    }
}
