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
    
    public partial class tbContactoProv
    {
        public int intContactoId { get; set; }
        public string strContacto { get; set; }
        public string strTelefono { get; set; }
        public string strTelefono2 { get; set; }
        public string strDepartamento { get; set; }
        public string strEmail { get; set; }
        public Nullable<int> intProveedor { get; set; }
        public string strUsuarioAlta { get; set; }
        public string strMaquinaAlta { get; set; }
        public Nullable<System.DateTime> datFechaAlta { get; set; }
        public string strUsuarioMod { get; set; }
        public string strMaquinaMod { get; set; }
        public Nullable<System.DateTime> datFechaMod { get; set; }
        public Nullable<bool> IsBorrado { get; set; }
        public Nullable<bool> IsPredeterminado { get; set; }
        public Nullable<bool> IsActivo { get; set; }
    }
}
