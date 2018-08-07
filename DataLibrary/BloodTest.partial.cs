using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(BloodTestMD))]
    partial class BloodTest
    {
        public class BloodTestMD
        {
            [HiddenInput(DisplayValue = false)]
            public int bltest_id { get; set; }

            [Display(Name = "Лейкоцити")]
            public double bltest_leu { get; set; }

            [Display(Name = "Гемоглобін")]
            public int bltest_hem { get; set; }

            [Display(Name = "Еретроцити")]
            public double bltest_er { get; set; }

            [Display(Name = "Гранулоцити")]
            public int bltest_gran { get; set; }

            [Display(Name = "Лімфоцити")]
            public int bltest_limf { get; set; }

            [Display(Name = "Моноцити")]
            public int bltest_mono { get; set; }

            [Display(Name = "СОЕ")]
            public int bltest_soy { get; set; }
        }
    }
}
