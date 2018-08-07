using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataLibrary
{
    [MetadataType(typeof(UrTest__PatientMD))]
    partial class UrTest__Patient
    {
        public class UrTest__PatientMD
        {
            [HiddenInput(DisplayValue = false)]
            public int utp_id { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int utp_patid { get; set; }

            [HiddenInput(DisplayValue = false)]
            public int utp_testid { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Дата")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime utp_date { get; set; }

            [Display(Name = "Стан")]
            public int utp_state { get; set; }
        }
    }
}
