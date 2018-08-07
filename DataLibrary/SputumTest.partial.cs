using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(SputumTestMD))]
    partial class SputumTest
    {
        public class SputumTestMD
        {
            [HiddenInput(DisplayValue = false)]
            public int sputtest_id { get; set; }

            [Display(Name = "Скопія")]
            public float sputtest_scopy { get; set; }

            [Display(Name = "Інокуляція")]
            public char sputtest_inocul { get; set; }
        }
    }
}
