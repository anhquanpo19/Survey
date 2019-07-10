using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class ClassModels
    {
        public int Class_ID { get; set; }
        public string Class_name { get; set; }
        public bool Class_status { get; set; }

        public virtual Class_user Class_user { get; set; }
    }
}