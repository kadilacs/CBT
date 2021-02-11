using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CBT.Dtos
{
    public class Candidatez
    {

        public int id { get; set; }
        [Display(Name = "Candidate Name")]
        public string Name { get; set; }
        [Display(Name = "Candidate Email")]
        public string Email { get; set; }
        [Display(Name = "Candidate Mobile Number")]
        public string Mobile { get; set; }
    }
}