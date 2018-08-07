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
    public partial class HepatTestForm : Form
    {

        DataLibrary.TubDataBaseEntities ctx;
        HepaticTest hp;
        mode m;
        int test;

        public HepatTestForm(int testid, DateTime date, mode _m)
        {
            InitializeComponent();

            ctx = new TubDataBaseEntities();
            m = _m;
            test = testid;
            hp = (from c in ctx.HepaticTest where (c.heptest_id == testid) select c).FirstOrDefault();
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

            bilTB.Text = hp.heptest_bilir.ToString();
            timTB.Text = hp.heptest_timil.ToString();
            astTB.Text =hp.heptest_ast.ToString();
            altTB.Text = hp.heptest_alt.ToString();
            uraTB.Text =  hp.heptest_uricasid.ToString();
            kreatTB.Text = hp.heptest_kreat.ToString();
            

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
                    FillBlTest(hp);
                    var q = (from c in ctx.HepTest___Patient where (c.htp_testid == test) select c).FirstOrDefault();
                    q.htp_state = (from c in ctx.State where (c.state_value == "завершено") select c.state_id).FirstOrDefault();
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FillBlTest(hp);
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Введено неправильну інформацію");
            }
        }

        private void FillBlTest(HepaticTest h)
        {
            if (bilTB.Text.Trim() != "")
            {
                h.heptest_bilir = Convert.ToDouble(bilTB.Text.Replace('.', ','));
            }
            else
            {
                h.heptest_bilir = null;
            }
            if (timTB.Text.Trim() != "")
            {
                h.heptest_timil = Convert.ToInt32(timTB.Text);
            }
            else
            {
                h.heptest_timil = null;
            }
            if (altTB.Text.Trim() != "")
            {
                h.heptest_alt = Convert.ToDouble(altTB.Text.Replace('.', ','));
            }
            else
            {
                h.heptest_alt = null;
            }
            if (astTB.Text.Trim() != "")
            {
                h.heptest_ast = Convert.ToInt32(astTB.Text);
            }
            else
            {
                h.heptest_ast = null;
            }
            if (uraTB.Text.Trim() != "")
            {
                h.heptest_uricasid = Convert.ToInt32(uraTB.Text);
            }
            else
            {
                h.heptest_uricasid = null;
            }
            if (kreatTB.Text.Trim() != "")
            {
                h.heptest_kreat = Convert.ToInt32(kreatTB.Text);
            }
            else
            {
                h.heptest_kreat = null;
            }
           
        }
    }
}
