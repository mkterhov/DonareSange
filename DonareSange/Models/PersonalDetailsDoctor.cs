//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DonareSange.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonalDetailsDoctor
    {
        public int PersonalDetailsId { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string DoctorId { get; set; }
        public Nullable<int> ClinicId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Clinic Clinic { get; set; }
    }
}
