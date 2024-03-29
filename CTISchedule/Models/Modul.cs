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
    
    public partial class Modul
    {
        public int Id { get; set; }
        public int IdZi { get; set; }
        public int IdDisciplina { get; set; }
        public int IdActivitate { get; set; }
        public int IdProfesor { get; set; }
        public int IdSubGrupa { get; set; }
        public int IdSala { get; set; }
        public System.TimeSpan OraStart { get; set; }
        public System.TimeSpan OraStop { get; set; }
        public Nullable<bool> SaptPara { get; set; }
    
        public virtual Activitate Activitate { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual SubGrupa SubGrupa { get; set; }
        public virtual Zile Zile { get; set; }
    }
}
