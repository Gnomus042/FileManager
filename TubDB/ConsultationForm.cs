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
    public partial class ConsultationForm : Form
    {

        DataLibrary.TubDataBaseEntities ctx;
       Consultation con;
        mode m;
        int test;

        public ConsultationForm(int testid, DateTime date, int sel_type, mode _m)
        {
            InitializeComponent();

            
            ctx = new TubDataBaseEntities();
            m = _m;
            ctx.ConsultationType.Load();
            consultationTypeBindingSource.DataSource = ctx.ConsultationType.Local.ToBindingList();
            test = testid;
            typeCB.SelectedValue = sel_type;
            typeCB.Enabled = false;
            con = (from c in ctx.Consultation where (c.cons_id == testid) select c).FirstOrDefault();
            if (m == mode.Redact)
            {
                this.StatusL.Text = "Завершено " + date.ToShortDateString();
                LoadTest(testid);
            }
            else if (m == mode.Create)
            {
                this.StatusL.Text = "Закінчити тест за " + date.ToShortDateString();
            }
            else if (m == mode.Losed)
            {
                this.StatusL.Text = "Пропущений тест за " + date.ToShortDateString();
            }
        }

        private void LoadTest(int testid)
        {

            CommentRTB.Text =con.cons_komment.ToString();
           

        }



        private void OKbut_Click(object sender, EventArgs e)
        {
            OKClicked();
        }

        private void OKClicked()
        {
            try
            {
                if (m == mode.Create)
                {
                    FillCons(con);
                    var q = (from c in ctx.Consult___Patient where (c.cp_consid == test) select c).FirstOrDefault();
                    q.cp_state = (from c in ctx.State where (c.state_value == "завершено") select c.state_id).FirstOrDefault();
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FillCons(con);
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Введено неправильну інформацію");
            }
        }

        private void FillCons(Consultation c)
        {

                c.cons_komment = CommentRTB.Text;

      
        }

        private void consultationTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void OKbut_Click_1(object sender, EventArgs e)
        {
            OKClicked();
        }
    }
}
