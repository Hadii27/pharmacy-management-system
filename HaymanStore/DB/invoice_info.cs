//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaymanStore.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoice_info
    {
        public int id { get; set; }
        public Nullable<int> Agent_id { get; set; }
        public Nullable<int> Amount { get; set; }
        public string Product_name { get; set; }
        public Nullable<int> Cust_num { get; set; }
        public Nullable<int> bill_id { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual invoice invoice { get; set; }
    }
}