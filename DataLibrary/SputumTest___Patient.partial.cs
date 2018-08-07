using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(SputumTest___PatientMD))]
    partial class SputumTest___Patient
    {
        public class SputumTest___PatientMD
        {
            [HiddenInput(DisplayValue = false)]
            public int sptp_id { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int sptp_patid { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int sptp_testid { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Дата")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime sptp_date { get; set; }

            [Display(Name = "Стан")]
            public int sptp_state { get; set; }

        }
    }
}
