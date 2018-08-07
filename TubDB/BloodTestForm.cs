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
    public partial class BloodTestForm : Form
    {

        DataLibrary.TubDataBaseEntities ctx;
        BloodTest bl;
        mode m;
        int test;

        public BloodTestForm(int testid, DateTime date, mode _m)
        {
            InitializeComponent();

            ctx = new TubDataBaseEntities();
            m = _m;
            test = testid;
            bl = (from c in ctx.BloodTest where (c.bltest_id == testid) select c).FirstOrDefault();
            if (m == mode.Redact)
            {
                this.StatusL.Text = "Завершено " + date.ToShortDateString();
                LoadTest(testid);
            }
            else if (m == mode.Create)
            {
                this.StatusL.Text = "Закінчити тест за "+ date.ToShortDateString();
            }
            else if (m == mode.Losed)
            {
                this.StatusL.Text = "Пропущений тест за " + date.ToShortDateString();
            }

        }

        private void LoadTest(int testid)
        {
    
            leuTB.Text = bl.bltest_leu.ToString();
            hemTB.Text = bl.bltest_hem.ToString();
            erTB.Text = bl.bltest_er.ToString();
            grTB.Text = bl.bltest_gran.ToString();
            limfTB.Text = bl.bltest_limf.ToString();
            monoTB.Text = bl.bltest_mono.ToString();
            soyTB.Text = bl.bltest_soy.ToString();

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
                    FillBlTest(bl);
                    var q = (from c in ctx.BlTest___Patient where (c.bltp_testid == test) select c).FirstOrDefault();
                    q.bltp_state = (from c in ctx.State where (c.state_value == "завершено") select c.state_id).FirstOrDefault();
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FillBlTest(bl);
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Введено неправильну інформацію");
            }
        }

        private void FillBlTest(BloodTest bl)
        {
            if (leuTB.Text.Trim()!="")
            {
                bl.bltest_leu = Convert.ToDouble(leuTB.Text.Replace('.', ','));
            }
            else
            {
                bl.bltest_leu = null;
            }
            if (hemTB.Text.Trim()!="")
            {
                bl.bltest_hem = Convert.ToInt32(hemTB.Text);
            }
            else
            {
                bl.bltest_hem = null;
            }
            if (erTB.Text.Trim()!="")
            {
                bl.bltest_er = Convert.ToDouble(erTB.Text.Replace('.', ','));
            }
            else
            {
                bl.bltest_er = null;
            }
            if (grTB.Text.Trim()!="")
            {
                bl.bltest_gran = Convert.ToInt32(grTB.Text);
            }
            else
            {
                bl.bltest_gran = null;
            }
            if (limfTB.Text.Trim()!="")
            {
                bl.bltest_limf = Convert.ToInt32(limfTB.Text);
            }
            else
            {
                bl.bltest_limf = null;
            }
            if (monoTB.Text.Trim()!="")
            {
                bl.bltest_mono = Convert.ToInt32(monoTB.Text);
            }
            else
            {
                bl.bltest_mono = null;
            }
            if (soyTB.Text.Trim()!="")
            {
                bl.bltest_soy = Convert.ToInt32(soyTB.Text);
            }
            else
            {
                bl.bltest_soy = null;
            }
        }
    }
}
