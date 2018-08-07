using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(HepaticTestMD))]
    partial class HepaticTest
    {
        public class HepaticTestMD
        {
            [HiddenInput(DisplayValue = false)]
            public int heptest_id { get; set; }

            [Display(Name = "Білірубин")]
            public float heptest_bilir { get; set; }

            [Display(Name = "Тіміл")]
            public int heptest_timil { get; set; }

            [Display(Name = "АЛТ")]
            public float heptest_alt { get; set; }

            [Display(Name = "АСТ")]
            public float heptest_ast { get; set; }

            [Display(Name = "Сечовина")]
            public int heptest_uricasid { get; set; }

            [Display(Name = "Креатинін")]
            public float heptest_kreat { get; set; }
        }
    }
}
