using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(Consult___PatientMD))]
    partial class Consult___Patient
    {
        public class Consult___PatientMD
        {
            [HiddenInput(DisplayValue = false)]
            public int cp_id { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int cp_patid { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int cp_consid { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Дата")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime cp_date { get; set; }

            [Display(Name = "Стан")]
            public int cp_state { get; set; }
        }
    }
}
