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
    
    public partial class tbPaises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbPaises()
        {
            this.tbPartner = new HashSet<tbPartner>();
        }
    
        public int intPais { get; set; }
        public string strPaisCodigo { get; set; }
        public string strPaisNombre { get; set; }
        public string strPaisContinente { get; set; }
        public string strPaisRegion { get; set; }
        public string strPaisCodigo2 { get; set; }
        public string strUsuarioAlta { get; set; }
        public string strMaquinaAlta { get; set; }
        public Nullable<System.DateTime> datFechaAlta { get; set; }
        public string strUsuarioMod { get; set; }
        public string strMaquinaMod { get; set; }
        public Nullable<System.DateTime> datFechaMod { get; set; }
        public Nullable<int> intActivo { get; set; }
        public Nullable<bool> IsBorrado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPartner> tbPartner { get; set; }
    }
}
