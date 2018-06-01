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
    
    public partial class Donation
    {
        public int DonationId { get; set; }
        public string DonorId { get; set; }
        public int CentreId { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<bool> passedTests { get; set; }
        public Nullable<double> quantity { get; set; }
        public Nullable<double> trombocite { get; set; }
        public Nullable<double> plasma { get; set; }
        public Nullable<double> globule_rosii { get; set; }
        public string blood_type { get; set; }
        public Nullable<double> greutate { get; set; }
        public Nullable<int> puls { get; set; }
        public Nullable<bool> is_able_to_donate { get; set; }
        public string specific_pacient_cnp { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Centre Centre { get; set; }
    }
}
