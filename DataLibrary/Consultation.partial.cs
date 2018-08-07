using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(ConsultationMD))]
    partial class Consultation
    {
        public class ConsultationMD
        {
            [HiddenInput(DisplayValue =false)]
            public int cons_id { get; set; }

            [Display(Name ="Тип консультації")]
            public int cons_type { get; set; }

            [Display(Name = "Коментар")]
            public string cons_komment { get; set; }
        }
    }
}
