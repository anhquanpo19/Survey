using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "You need give us your name or roll Id")]
        public string user_name { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need give us your Password")]
        [DataType(DataType.Password)]
        public string user_password { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "You need give us your Email")]
        [DataType(DataType.EmailAddress)]
        public string user_email { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please give us your Name!")]
        
        public string user_nicename { get; set; }
         

        public bool User_status { get; set; }


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
