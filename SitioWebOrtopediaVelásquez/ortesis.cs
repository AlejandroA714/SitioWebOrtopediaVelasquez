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
    
    public partial class ortesis
    {
        public ortesis()
        {
            this.consulta = new HashSet<consulta>();
        }
    
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public Nullable<int> tipo { get; set; }
        public string descripcion { get; set; }
        public byte[] foto { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        public virtual ICollection<consulta> consulta { get; set; }
        public virtual tipoOrtesis tipoOrtesis { get; set; }
    }
}
