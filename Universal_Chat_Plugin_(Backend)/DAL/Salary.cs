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
    
    public partial class Salary
    {
        public int Id { get; set; }
        public string Paid_Month { get; set; }
        public string Salary_status { get; set; }
        public int Card_no { get; set; }
        public int CVC { get; set; }
        public System.DateTime Payment_date { get; set; }
        public int Total_Salary { get; set; }
        public int Paid_Salary { get; set; }
        public int Due_Salary { get; set; }
        public int AdminId { get; set; }
    
        public virtual Admin Admin { get; set; }
    }
}
