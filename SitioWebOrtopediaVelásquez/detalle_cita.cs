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
    
    public partial class detalle_cita
    {
        public int id { get; set; }
        public Nullable<int> idCita { get; set; }
        public Nullable<int> idProtesis { get; set; }
        public Nullable<int> idOrtesis { get; set; }
        public string observaciones { get; set; }
    
        public virtual cita cita { get; set; }
        public virtual ortesis ortesis { get; set; }
        public virtual protesis protesis { get; set; }
    }
}
