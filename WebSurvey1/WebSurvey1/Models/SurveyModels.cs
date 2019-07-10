using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class SurveyModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SurveyModels()
        {
            this.ExamModel = new HashSet<ExamModels>();
            this.QuestionModel = new HashSet<QuestionModels>();
        }

        public int ID { get; set; }
        public int survey_author { get; set; }
        public string survey_name { get; set; }
        public string survey_type { get; set; }
        public string survey_depcript { get; set; }
        public bool survey_status { get; set; }
        public int survey_score { get; set; }
        public System.DateTime survey_register { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamModels> ExamModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionModels> QuestionModel { get; set; }
        public virtual User User { get; set; }
    }
}