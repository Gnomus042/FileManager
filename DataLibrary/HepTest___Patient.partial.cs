using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(HepTest___PatientMD))]
    partial class HepTest___Patient
    {
        public class HepTest___PatientMD
        {
            [HiddenInput(DisplayValue = false)]
            public int htp_id { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int htp_patid { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int htp_testid { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Дата")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime htp_date { get; set; }

            [Display(Name = "Стан")]
            public int htp_state { get; set; }
        }
    }
}
