//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTISchedule.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grupa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupa()
        {
            this.SubGrupas = new HashSet<SubGrupa>();
        }
    
        public int Id { get; set; }
        public string Nume { get; set; }
        public int IdGeneratie { get; set; }
    
        public virtual Generatie Generatie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubGrupa> SubGrupas { get; set; }
    }
}
