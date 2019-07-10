using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class ClassModels
    {
        [Required]
        public int Class_ID { get; set; }

        [Display(Name ="Class Name")]
        [Required(ErrorMessage ="You need give us your class name")]
        public string Class_name { get; set; }
        public bool Class_status { get; set; }

        public virtual Class_user Class_user { get; set; }
    }
}