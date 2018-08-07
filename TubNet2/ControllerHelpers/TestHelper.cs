using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;

namespace TubNet2.ControllerHelpers
{
    public interface TestHelper
    {
        void PlanNewTest(DateTime date, int pid);
        int DeleteTest(int id);
        object GetActiveTest(int id);
        string GetActiveTestDate(int id);
        object GetSortedCollection(string sort, int p_id);
        object GetSortedCollection(string sort, int p_id, DateTime date);
        void UpdateTest(object o);
        
    }
}
