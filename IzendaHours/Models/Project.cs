//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IzendaHours.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Project
    {
        public Project()
        {
            this.Records = new HashSet<Record>();
        }
    
        public int ProjectId { get; set; }

        [Display(Name = "Customer")]
        public string Project1 { get; set; }
    
        public virtual ICollection<Record> Records { get; set; }
    }
}