//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Payment_type { get; set; }
        public string Payment_status { get; set; }
        public int Card_no { get; set; }
        public int CVC { get; set; }
        public System.DateTime Payment_date { get; set; }
        public int Total_amount { get; set; }
        public int Paid_amount { get; set; }
        public int Due_amount { get; set; }
        public Nullable<int> User_Id { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }
}
