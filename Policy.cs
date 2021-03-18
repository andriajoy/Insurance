//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceDBfirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Policy
    {
        public int PolicyNumber { get; set; }
        public Nullable<int> PlanNumber { get; set; }
        public Nullable<int> InstallmentPremium { get; set; }
        public Nullable<int> Insured { get; set; }
        public Nullable<int> SumAssured { get; set; }
        public string PolicyStatus { get; set; }
        public string PremiumMode { get; set; }
        public Nullable<System.DateTime> PremiumDueDate { get; set; }
        public Nullable<int> Beneficiary { get; set; }
        public Nullable<int> Owner { get; set; }
        public Nullable<int> PolicyTerm { get; set; }
    
        public virtual Participant Participant { get; set; }
        public virtual Participant Participant1 { get; set; }
        public virtual Participant Participant2 { get; set; }
        public virtual PolicyType PolicyType { get; set; }
    }
}