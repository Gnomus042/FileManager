using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary
{
    [MetadataType(typeof(GenderMD))]
    partial class Gender
    {
        public class GenderMD
        {
            [HiddenInput(DisplayValue = false)]
            public int gen_id { get; set; }

            [Display(Name ="Тип")]
            public string gen_value { get; set; }
        }
    }
}
