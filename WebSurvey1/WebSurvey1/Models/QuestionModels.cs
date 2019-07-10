using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class QuestionModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionModels()
        {
            this.Questions_metaModel = new HashSet<Questions_metaModels>();
        }

        public int question_ID { get; set; }
        public string question_Date { get; set; }
        public string question_tile { get; set; }
        public string question_status { get; set; }
        public string question_type { get; set; }
        public int question_resuit { get; set; }
        public int survey_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Questions_metaModels> Questions_metaModel { get; set; }
        public virtual Survey Survey { get; set; }
    }
}
}