using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(UrineTestMD))]
    partial class UrineTest
    {
        public class UrineTestMD
        {
            [HiddenInput(DisplayValue = false)]
            public int urtest_id { get; set; }

            [Display(Name = "Протеїн")]
            public double urtest_protein { get; set; }

            [Display(Name = "Цукор")]
            public char urtest_sugar { get; set; }

            [Display(Name = "Лейкоцити мін")]
            public int urtest_leumin { get; set; }

            [Display(Name = "Лейкоцити макс")]
            public int urtest_leumax { get; set; }

            [Display(Name = "Еретроити мін")]
            public int urtest_ermin { get; set; }

            [Display(Name = "Еретроцити макс")]
            public int urtest_ermax { get; set; }
        }
    }
}
