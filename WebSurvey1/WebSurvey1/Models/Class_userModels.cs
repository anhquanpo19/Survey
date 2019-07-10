using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class Class_userModels
    {
        public int Class_ID { get; set; }
        public int User_ID { get; set; }
        public bool status { get; set; }

        public virtual Class Class { get; set; }
        public virtual User User { get; set; }
    }
}