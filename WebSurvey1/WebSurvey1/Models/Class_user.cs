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
    
    public partial class Class_user
    {
        public int Class_ID { get; set; }
        public int User_ID { get; set; }
        public bool status { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual User User { get; set; }
    }
}
