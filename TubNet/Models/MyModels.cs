using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DataLibrary;

namespace TubNet.Models
{
    public class PatientsListViewModel
    {
        public IEnumerable<Patients> PatientsList { get; set; }
        public SelectList Genders { get; set; }
        
    }
}