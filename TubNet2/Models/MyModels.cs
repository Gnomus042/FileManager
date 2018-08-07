using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DataLibrary;
using System.ComponentModel.DataAnnotations;

namespace TubNet2.Models
{
    public class PatientsListViewModel
    {
        public IEnumerable<Patients> PatientsList { get; set; }
        public SelectList Genders { get; set; }
        
    }

    public class PatientAnalsis
    {
        public Patients patient { get; set; }
        public string name { get; set; }
    }

    public class AddPatientModel
    {
        public Patients Patient;
        public SelectList Genders { get; set; }
    }

   public class ViewTestsModel
    {
        public Patients Patient;
        public string ViewName;
        public object ViewCollection;
        public object Single;
        public string SingleDate;
        public FilterModel filter;
    }

    public class ViewPatientsModel
    {
        public List<Patients> collection;
        public PatientsFilterModel filter;
    }

    public class FilterModel
    {
        [Display(Name = "Тип")]
        public string ViewType { get; set; }

        [Display(Name = "UseDate")]
        public bool UseDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? borderDate { get; set; }
    }

    public class PartialViewModel
    {
        public object Collection;
        public object Single;
    }

    public class PatientsFilterModel
    {

        [Display(Name = "Прізвище")]
        public string p_surname { get; set; } = "";

        [Display(Name = "Ім'я")]
        public string p_name { get; set; } = "";

        [Display(Name = "По батькові")]
        public string p_secname { get; set; } = "";

        public bool UseGender { get; set; }
        
        [Display(Name = "Стать")]
        public int p_genderId { get; set; }

        public bool UseBirthday { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата народження")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime p_birthday { get; set; }

        public bool UseDiagnosis { get; set; }

        [Display(Name = "Діагноз")]
        public int p_diagnosisId { get; set; }

        public bool UseType { get; set; }

        [Display(Name = "Тип")]
        public int p_typeId { get; set; }

        public bool UseBK { get; set; }

        [Display(Name = "БК")]
        public int p_bkID { get; set; }

        public bool UseDestruction { get; set; }

        [Display(Name = "Деструкція")]
        public int p_destructionId { get; set; }

        
    }
}