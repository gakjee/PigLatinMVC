using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PigLatinMVC.Models
{
    public class English_PigLatin
    {
        [Display(Name = "Text is English")]
        [Required(ErrorMessage = "Please enter a text")]
        public string English_text { get; set; }

        [Display(Name = "Text in Pig Latin")]
        public string PigLatin_text { get; set; }
    }
}