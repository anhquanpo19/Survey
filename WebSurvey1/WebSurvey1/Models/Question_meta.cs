//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSurvey1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question_meta
    {
        public int ID { get; set; }
        public int question_ID { get; set; }
        public string question_key { get; set; }
        public string question_value { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
