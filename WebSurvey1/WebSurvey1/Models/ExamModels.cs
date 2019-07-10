using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class ExamModels
    {
        public int exm_ID { get; set; }
        public int survey_ID { get; set; }
        public int user_ID { get; set; }
        public int number_question { get; set; }
        public double total_score { get; set; }
        public System.TimeSpan time_score { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual User User { get; set; }
    }
}