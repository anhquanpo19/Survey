using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class UserModels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserModels()
        {
            this.Class_user = new HashSet<Class_user>();
            this.ExamModel = new HashSet<ExamModels>();
            this.SurveyModel = new HashSet<SurveyModels>();
            this.User_metaModel = new HashSet<User_metaModels>();
        }


        public int ID { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public string user_email { get; set; }
        public string user_nicename { get; set; }
        public bool user_status { get; set; }
        public string display_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class_user> Class_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamModels> ExamModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyModels> SurveyModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_metaModels> User_metaModel { get; set; }
    }
}
}