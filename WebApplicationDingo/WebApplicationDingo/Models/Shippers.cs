//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationDingo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shippers
    {
        public Shippers()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public Nullable<int> RegionID { get; set; }
    
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Region Region { get; set; }
    }
}
