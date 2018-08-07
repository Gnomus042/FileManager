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
    public partial class UrinaTestForm : Form
    {

        DataLibrary.TubDataBaseEntities ctx;
        UrineTest ur;
        mode m;
        int test;

        public UrinaTestForm(int testid, DateTime date, mode _m)
        {
            InitializeComponent();

            ctx = new TubDataBaseEntities();
            m = _m;
            test = testid;
            ur = (from c in ctx.UrineTest where (c.urtest_id == testid) select c).FirstOrDefault();
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

            protTB.Text = ur.urtest_protein.ToString();
            SugarTB.Text = ur.urtest_sugar.ToString();
            lminTB.Text = ur.urtest_leumin.ToString();
            lmaxTB.Text = ur.urtest_leumax.ToString();
            erminTB.Text = ur.urtest_ermin.ToString();
            ermaxTB.Text = ur.urtest_ermax.ToString();
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
                    FillUrTest(ur);
                    var q = (from c in ctx.UrTest__Patient where (c.utp_testid == test) select c).FirstOrDefault();
                    q.utp_state = (from c in ctx.State where (c.state_value == "завершено") select c.state_id).FirstOrDefault();
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FillUrTest(ur);
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                MessageBox.Show("Введено неправильну інформацію");
            }
        }

        private void FillUrTest(UrineTest u)
        {
            if (protTB.Text.Trim() != "")
            {
               u.urtest_protein = Convert.ToDouble(protTB.Text.Replace('.', ','));
            }
            else
            {
                u.urtest_protein = null;
            }
            if (SugarTB.Text.Trim() != "")
            {
                u.urtest_sugar = SugarTB.Text;
            }
            else
            {
                u.urtest_sugar = "";
            }
            if (lminTB.Text.Trim() != "")
            {
               u.urtest_leumin = Convert.ToInt32(lminTB.Text.Replace('.', ','));
            }
            else
            {
                u.urtest_leumin = null;
            }
            if (lmaxTB.Text.Trim() != "")
            {
                u.urtest_leumax = Convert.ToInt32(lmaxTB.Text);
            }
            else
            {
                u.urtest_leumax = null;
            }
            if (erminTB.Text.Trim() != "")
            {
               u.urtest_ermin = Convert.ToInt32(erminTB.Text);
            }
            else
            {
                u.urtest_ermin = null;
            }
            if (ermaxTB.Text.Trim() != "")
            {
                u.urtest_ermax = Convert.ToInt32(ermaxTB.Text);
            }
            else
            {
                u.urtest_ermax = null;
            }
           
        }
    }

}


