//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioWebOrtopediaVelásquez
{
    using System;
    using System.Collections.Generic;
    
    public partial class consulta
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int idHorario { get; set; }
        public int idPaciente { get; set; }
        public Nullable<int> idProtesis { get; set; }
        public Nullable<int> idOrtesis { get; set; }
        public Nullable<int> idMedico { get; set; }
    
        public virtual horarios horarios { get; set; }
        public virtual medico medico { get; set; }
        public virtual ortesis ortesis { get; set; }
        public virtual paciente paciente { get; set; }
        public virtual protesis protesis { get; set; }
    }
}
