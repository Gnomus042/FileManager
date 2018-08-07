using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace DataLibrary
{
    [MetadataType(typeof(PatientsMD))]
    partial class Patients
    {
        public class PatientsMD
        {
            [HiddenInput(DisplayValue = false)]
            public int p_id { get; set; }  

            [Display(Name = "Прізвище")]
            public string p_surname { get; set; }

            [Display(Name ="Ім'я")]
            public string p_name { get; set; }

            [Display(Name = "По батькові")]
            public string p_secname { get; set; }


            [Display(Name = "Стать")]
            public int p_genderId { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Дата народження")]
            [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
            public DateTime p_birthday { get; set; }

            [Display(Name = "Адреса проживання")]
            [DataType(DataType.MultilineText)]
            public string p_factAddress { get; set; }

            [Display(Name = "Адреса реєстрації")]
            [DataType(DataType.MultilineText)]
            public string p_regAddress { get; set; }

            [Display(Name = "Діагноз")]
            public int p_diagnosisId { get; set; }

            [Display (Name = "Тип")]
            public int p_typeId { get; set; }

            [Display(Name = "БК")]
            public int p_bkID { get; set; }

            [Display (Name = "Деструкція")]
            public int p_destructionId { get; set; }

            [Display (Name ="Інші захворювання")]
            [DataType(DataType.MultilineText)]
            public string p_otherDiseases { get; set; }

            [DataType(DataType.Date)]
            [Display (Name = "Початок лікування")]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime p_firstVisit { get; set; }

            [Display(Name = "Закінчення лікування")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime p_lastVisit { get; set; }

            [Display (Name = "Коментар")]
            [DataType(DataType.MultilineText)]
            public string p_komment { get; set; }

            [Display (Name = "Телефон")]
            public string p_phones { get; set; }

            [Display (Name = "Результат лікування")]
            public string p_result { get; set; }
        }
    }
}
