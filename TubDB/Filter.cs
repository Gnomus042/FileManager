using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;
using System.Data.Entity;
using System.Xml.Linq;

namespace TubDB
{
    public partial class Filter : UserControl
    {
        
        DataGridView dgv;
        DataLibrary.TubDataBaseEntities ctx;
        BindingSource bind;

        public Filter()
        {
            InitializeComponent();
            BirthDT.MaxDate = DateTime.Today;
            BegDT.MaxDate = DateTime.Today;
            EndDT.MaxDate = DateTime.Today;
        }

        public void Init(DataGridView _dgv)
        {
            dgv = _dgv;
            bind = (BindingSource)dgv.DataSource;
            LoadCtx();
            ClearFilter();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

          
        }

        private void LoadCtx()
        {
            ctx = new TubDataBaseEntities();
            ctx.Gender.Load();
            this.genderBindingSource.DataSource = ctx.Gender.Local.ToBindingList();

            ctx.Diagnosis.Load();
            this.diagnosisBindingSource.DataSource = ctx.Diagnosis.Local.ToBindingList();

            ctx.Type.Load();
            this.typeBindingSource.DataSource = ctx.Type.Local.ToBindingList();

            ctx.BK.Load();
            this.bKBindingSource.DataSource = ctx.BK.Local.ToBindingList();

            ctx.Destruction.Load();
            this.destructionBindingSource.DataSource = ctx.Destruction.Local.ToBindingList();
        }

        public void ClearFilter()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                    c.Enabled = false;
                }

                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Today.Date;
                    c.Enabled = false;
                }
            }
            ctx.Dispose();
            ctx = new TubDataBaseEntities();
            ctx.Patients.Load();

            bind.DataSource = ctx.Patients.Local.ToBindingList();
        }



        private void EnableCont(Control c)
        {
           
            c.Enabled = !(c.Enabled);
        }

        private void OKFBut_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void FormXml(List<Patients> p)
        {
            XDocument x = new XDocument();
            XElement el = new XElement("main");
            el.Add(new XElement("form_time",DateTime.Today));
            foreach (Patients q in p)
            {
                XElement pat = FormPatXml(q);
                el.Add(pat);
            }
            x.Add(el);
            x.Save(String.Format(@"E:\TubDB\xml_search\{0}_{1}_{2}_{3}_{4}.xml", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Hour, DateTime.Now.Minute));
        }

        private XElement FormPatXml(Patients p)
        {
            XElement x = new XElement("patient", new XElement("surname", p.p_surname), new XElement("name", p.p_name),
                new XElement("secname", p.p_secname), new XElement("gender", (from c in ctx.Gender where (c.gen_id == p.p_genderId) select c.gen_value).FirstOrDefault()),
                new XElement("birthday", p.p_birthday), new XElement("phone", p.p_phones), new XElement("factAddress", p.p_factAddress),
                new XElement("regAddress", p.p_regAddress),
                new XElement("diagnosis", (from c in ctx.Diagnosis where (c.diag_id == p.p_diagnosisId) select c.diag_value).FirstOrDefault()),
                new XElement("type", (from c in ctx.Type where (c.type_id == p.p_typeId) select c.type_value).FirstOrDefault()),
                new XElement("bk", (from c in ctx.BK where (c.bk_id == p.p_bkID) select c.bk_value).FirstOrDefault()),
                new XElement("destruction", (from c in ctx.Destruction where (c.destr_id == p.p_destructionId) select c.destr_value).FirstOrDefault()),
                new XElement("other_diseases", p.p_otherDiseases),
                new XElement("cure_beginning", p.p_firstVisit), new XElement("cure_end", p.p_lastVisit),
                new XElement("result", p.p_result));
            return x;
        }

        private void Search()
        {
            ctx.Dispose();

            ctx = new TubDataBaseEntities();
            var query = (from c in ctx.Patients select c);
            if (SurnameTB.Enabled == true)
            {
                query = query.Where(c => c.p_surname.Contains(SurnameTB.Text));
            }
            if (NameTB.Enabled == true)
            {
                query = query.Where(c => c.p_name.Contains(NameTB.Text));
            }
            if (GenderCB.Enabled==true)
            {
                query = query.Where(c => c.p_genderId == (int)GenderCB.SelectedValue);
            }
            if (BirthDT.Enabled == true)
            {
                query = query.Where(c => c.p_birthday == (DateTime)BirthDT.Value.Date);
            }
            if (DiagnosisCB.Enabled==true)
            {
                query = query.Where(c => c.p_diagnosisId == (int)DiagnosisCB.SelectedValue);
            }
            if (TypeCB.Enabled == true)
            {
                query = query.Where(c => c.p_typeId == (int)TypeCB.SelectedValue);
            }
            if (BKCB.Enabled == true)
            {
                query = query.Where(c => c.p_bkID == (int)BKCB.SelectedValue);
            }
            if (DestructionCB.Enabled == true)
            {
                query = query.Where(c => c.p_destructionId == (int)DestructionCB.SelectedValue);
            }
            if(BegDT.Enabled == true)
            {
                query = query.Where(c => c.p_firstVisit == (DateTime)BegDT.Value.Date);
            }
            if (EndDT.Enabled == true)
            {
                query = query.Where(c => c.p_firstVisit == (DateTime)EndDT.Value.Date);
            }
            if (ResultDT.Enabled == true)
            {
                query = query.Where(c => c.p_result == ResultDT.Text);
            }
            query.Load();

            bind.DataSource = ctx.Patients.Local.ToBindingList();
            if (xmlChB.Checked == true)
            {
                FormXml(query.ToList());
            }
        }

        public void DGVrenew()
        {
            Search();
        }

        private void SurnameL_Click(object sender, EventArgs e)
        {
            EnableCont(SurnameTB);
        }

        private void NameL_Click(object sender, EventArgs e)
        {
            EnableCont(NameTB);
        }

        private void GenderL_Click(object sender, EventArgs e)
        {
            EnableCont(GenderCB);
        }

        private void BirthL_Click(object sender, EventArgs e)
        {
            EnableCont(BirthDT);
        }

        private void DiagnosisL_Click(object sender, EventArgs e)
        {
            EnableCont(DiagnosisCB);
        }

        private void TypeL_Click(object sender, EventArgs e)
        {
            EnableCont(TypeCB);
        }

        private void BKL_Click(object sender, EventArgs e)
        {
            EnableCont(BKCB);
        }

        private void DestrL_Click(object sender, EventArgs e)
        {
            EnableCont(DestructionCB);
        }

        private void BegL_Click(object sender, EventArgs e)
        {
            EnableCont(BegDT);

        }

        private void EndL_Click(object sender, EventArgs e)
        {
            EnableCont(EndDT);
        }

        private void ResL_Click(object sender, EventArgs e)
        {
            EnableCont(ResultDT);
        }

        private void ClearFBut_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }
    }
}
