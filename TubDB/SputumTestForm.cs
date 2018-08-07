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
    public partial class SputumTestForm : Form
    {

        DataLibrary.TubDataBaseEntities ctx;
        SputumTest sp;
        mode m;
        int test;

        public SputumTestForm(int testid, DateTime date, mode _m)
        {
            InitializeComponent();

            ctx = new TubDataBaseEntities();
            m = _m;
            test = testid;
            sp = (from c in ctx.SputumTest where (c.sputtest_id == testid) select c).FirstOrDefault();
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
            skopTB.Text = sp.sputtest_scopy.ToString();
            inoTB.Text = sp.sputtest_inocul.ToString();
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
                    FillBlTest(sp);
                    var q = (from c in ctx.SputumTest___Patient where (c.sptp_testid == test) select c).FirstOrDefault();
                    q.sptp_state = (from c in ctx.State where (c.state_value == "завершено") select c.state_id).FirstOrDefault();
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FillBlTest(sp);
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Введено неправильну інформацію");
            }
        }

        private void FillBlTest(SputumTest s)
        {
            if (skopTB.Text.Trim() != "")
            {
                s.sputtest_scopy = Convert.ToDouble(skopTB.Text.Replace('.', ','));
            }
            else
            {
                s.sputtest_scopy = null;
            }
            if (inoTB.Text.Trim() != "")
            {
               s.sputtest_inocul = inoTB.Text;
            }
            else
            {
                s.sputtest_inocul = null;
            }
           
        }
    }
}
