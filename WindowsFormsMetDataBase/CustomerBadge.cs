//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsMetDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerBadge
    {
        public int BadgeId { get; set; }
        public int CustomerId { get; set; }
        public int Id { get; set; }
    
        public virtual Badge Badge { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
