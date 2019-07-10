using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class Questions_metaModels
    {
        public int ID { get; set; }
        public int question_ID { get; set; }
        public string question_key { get; set; }
        public string question_value { get; set; }

        public virtual Question Question { get; set; }
    }
}