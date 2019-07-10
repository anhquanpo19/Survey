using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSurvey1.Models
{
    public class User_metaModels
    {
        public int usermeta_ID { get; set; }
        public int user_ID { get; set; }
        public string meta_key { get; set; }
        public string meta_value { get; set; }

        public virtual User User { get; set; }
    }
}