//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCContactBook
{
    using System;
    using System.Collections.Generic;
    
    public partial class State
    {
        public State()
        {
            this.Contacts = new HashSet<Contact>();
        }
    
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string StateName { get; set; }
    
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual Country Country { get; set; }
    }
}
