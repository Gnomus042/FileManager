using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(BlTest___PatientMD))]
    partial class BlTest___Patient
    {
        public class BlTest___PatientMD
        {
            [HiddenInput(DisplayValue = false)]
            public int bltp_id { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int bltp_patid { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int bltp_testid { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Дата")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime bltp_date { get; set; }

            [Display(Name = "Стан")]
            public int bltp_state { get; set; }

        }
    }
}
