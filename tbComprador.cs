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
    
    public partial class tbComprador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbComprador()
        {
            this.tbOrdenCompraEnc = new HashSet<tbOrdenCompraEnc>();
        }
    
        public Nullable<int> intEmpresa { get; set; }
        public int intCompradorId { get; set; }
        public Nullable<int> intNumEmpleado { get; set; }
        public string strNombre { get; set; }
        public string strEmail { get; set; }
        public Nullable<bool> IsBorrado { get; set; }
        public string strUsuarioAlta { get; set; }
        public string strMaquinaAlta { get; set; }
        public Nullable<System.DateTime> datFechaAlta { get; set; }
        public string strUsuarioMod { get; set; }
        public string strMaquinaMod { get; set; }
        public Nullable<System.DateTime> datFechaMod { get; set; }
        public Nullable<bool> IsActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrdenCompraEnc> tbOrdenCompraEnc { get; set; }
    }
}