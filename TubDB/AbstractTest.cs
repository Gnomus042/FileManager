using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Windows.Forms;

namespace TubDB
{
    public abstract class AbstractTest
    {
        protected DataLibrary.TubDataBaseEntities ctx;
        protected Patients pat;
        protected DataGridView dgv;
        protected BindingSource data;
        ComboBox box;

        public AbstractTest(Patients _pat,DataGridView d, ComboBox c)
        {
            ctx = new DataLibrary.TubDataBaseEntities();
            pat = _pat;
            dgv = d;
            box = c;
            data = (BindingSource)dgv.DataSource; 
        }

        public abstract void Renew();
        public abstract void RenewWithDate(DateTime date);
        public abstract void Plan(DateTime date);
        public abstract void Show(mode m);
        public abstract void Delete();

        protected int State()
        {
            int st = (from c in ctx.State where (c.state_value == box.SelectedItem) select c.state_id).FirstOrDefault();
            return st;
        }

    }
}
