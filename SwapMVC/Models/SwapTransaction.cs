//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwapMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SwapTransaction
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int SwapItemID { get; set; }
        public System.DateTime SwapDate { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual SwapItem SwapItem { get; set; }
    }
}