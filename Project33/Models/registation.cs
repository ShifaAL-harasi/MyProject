//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project33.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class registation
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string major { get; set; }
        public int course_id { get; set; }
        public int batch_id { get; set; }
        public int phone_number { get; set; }
    
        public virtual batch batch { get; set; }
        public virtual course course { get; set; }
    }
}
