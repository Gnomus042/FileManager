using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;
using System.Data.Entity;

namespace TubDB
{
    public partial class AnalysisViewer : Form
    {

        private DataLibrary.TubDataBaseEntities ctx;
        private Patients pat;

        Blood blood;
        Urina urina;
        Hepatic hepatic;
        Sputum sputum;
        Consultations cons;

        public AnalysisViewer(DataLibrary.TubDataBaseEntities _ctx, Patients _pat)
        {
            InitializeComponent();

            ctx = _ctx;
            pat = _pat;

            ctx.ConsultationType.Load();
            docCB.DataSource = ctx.ConsultationType.Local.ToBindingList();

            blood = new Blood(pat,BloodDGV, StateFCB);
            urina = new Urina(pat, UrinaDGV, StateFCB);
            hepatic = new Hepatic(pat, HepaticDGV, StateFCB);
            sputum = new Sputum(pat, SputumDGV, StateFCB);
            cons = new Consultations(pat, ConsDGV, StateFCB, docCB);

            StateFCB.SelectedIndex = 0;

            PlanBloodDT.MinDate = DateTime.Today;
            PlanUrDT.MinDate = DateTime.Today;
            PlanHepatDT.MinDate = DateTime.Today;
            PlanSputDT.MinDate = DateTime.Today;
            PlanConsDT.MinDate = DateTime.Today;

            this.BloodDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BloodDGV_CellContentClick);
            this.UrinaDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrinaDGV_CellContentClick);
            this.HepaticDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HepaticDGV_CellContentClick);
            this.SputumDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SputumDGV_CellContentClick);
            this.ConsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsDGV_CellContentClick);

            Renew();
        }

        private void Renew()
        {
            if (DateChB.Checked == true)
            {
                blood.RenewWithDate(FDT.Value.Date);
                urina.RenewWithDate(FDT.Value.Date);
                hepatic.RenewWithDate(FDT.Value.Date);
                sputum.RenewWithDate(FDT.Value.Date);
                cons.RenewWithDate(FDT.Value.Date);
            }
            else
            {
                blood.Renew();
                urina.Renew();
                hepatic.Renew();
                sputum.Renew();
                cons.Renew();
            }
        }

        private void ShowFBut_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void BloodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            blood.Show(GetMode()); 
        }

        private void UrinaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            urina.Show(GetMode());
        }

        private void HepaticDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hepatic.Show(GetMode());
        }

        private void SputumDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sputum.Show(GetMode());
        }

        private void ConsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cons.Show(GetMode());
        }

        private mode GetMode()
        {
            if (StateFCB.SelectedIndex == 0)
            {
                return mode.Create;
            }
            else if (StateFCB.SelectedIndex == 1)
            {
                return mode.Redact;
            }
            else
            {
                return mode.Losed;
            }

        }

        private void PlanBloodBut_Click(object sender, EventArgs e)
        {
            blood.Plan(PlanBloodDT.Value);
        }

        private void PlanUrBut_Click(object sender, EventArgs e)
        {
            urina.Plan(PlanUrDT.Value);
        }

        private void PlanHepatBut_Click(object sender, EventArgs e)
        {
            hepatic.Plan(PlanHepatDT.Value);
        }

        private void PlanSputBut_Click(object sender, EventArgs e)
        {
            sputum.Plan(PlanSputDT.Value);
        }

        private void PlanConsBut_Click(object sender, EventArgs e)
        {
            cons.Plan(PlanConsDT.Value);
        }


        private void DeleteBloodBut_Click(object sender, EventArgs e)
        {
            try
            {
                blood.Delete();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні");
            }
        }

        private void DeleteUrBut_Click(object sender, EventArgs e)
        {
            try
            {
                urina.Delete();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні");
            }
        }

        private void DeleteHepatBut_Click(object sender, EventArgs e)
        {
            try
            {
                hepatic.Delete();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні");
            }
        }

        private void DeleteSputBut_Click(object sender, EventArgs e)
        {
            try
            {
                sputum.Delete();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні");
            }
        }



        private void DeleteConsBut_Click(object sender, EventArgs e)
        {
            try
            {
                cons.Delete();
            }
            catch
            {
                MessageBox.Show("Помилка при видаленні");
            }
        }

        private void StateFCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StateFCB.SelectedIndex == 0)
            {
                FDT.MinDate = DateTime.Today;
                FDT.MaxDate = DateTimePicker.MaximumDateTime;
            }
            else
            {
                FDT.MaxDate = DateTime.Today;
                FDT.MinDate = DateTimePicker.MinimumDateTime;
            }
        }

        

    }
}
