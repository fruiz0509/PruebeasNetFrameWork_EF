//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebeasNetFrameWork_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TbRol
    {
        public int IDRol { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public bool IsActivo { get; set; }
        public string UsuarioAlta { get; set; }
        public string MaquinaAlta { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string UsuarioMod { get; set; }
        public string MaquinaMod { get; set; }
        public Nullable<System.DateTime> FechaMod { get; set; }
    }
}
