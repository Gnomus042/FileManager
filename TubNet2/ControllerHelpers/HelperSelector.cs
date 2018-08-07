using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TubNet2.ControllerHelpers
{
    public static class HelperSelector
    {

        public static TestHelper get(string name)
        {
            if (name == "BloodTest")
            {
                return new BloodHelper();
            }
            if (name == "UrinaTest")
            {
                return new UrinaHelper();
            }
            if (name=="HepaticTest")
            {
                return new HepaticHelper();
            }
            if (name=="SputumTest")
            {
                return new SputumHelper();
            }
            if (name == "Consultation")
            {
                return new ConsultationHelper();
            }
            return null;
        }
    }
}