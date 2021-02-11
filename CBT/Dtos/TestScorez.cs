using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CBT.Dtos
{
    public class TestScorez
    {
        public int id { get; set; }
        [Display(Name = "Candidate Test Score")]
        public int Score { get; set; }
        [Display(Name = "Candidate Test Date")]
        public DateTime Date { get; set; }
        [Display(Name = "Candidate Test Name")]
        public string Name { get; set; }
        [Display(Name = "Candidate ID")]
        public int CandidateId { get; set; }
    }
}