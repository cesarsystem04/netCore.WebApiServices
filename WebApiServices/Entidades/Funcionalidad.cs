//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcionalidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionalidad()
        {
            this.Funcionalidad1 = new HashSet<Funcionalidad>();
            this.FuncionalidadXRol = new HashSet<FuncionalidadXRol>();
            this.MenuMaster = new HashSet<MenuMaster>();
        }
    
        public int idFuncionalidad { get; set; }
        public string codAplicacion { get; set; }
        public int idCodigoCategoria { get; set; }
        public string nbFuncionalidad { get; set; }
        public string dsFuncionalidad { get; set; }
        public string nbComponente { get; set; }
        public string dsTitulo { get; set; }
        public string dsRutaImagen { get; set; }
        public bool esActivo { get; set; }
        public bool esConsultar { get; set; }
        public bool esActualizar { get; set; }
        public bool esAgregar { get; set; }
        public bool esImprimir { get; set; }
        public bool esEspecial { get; set; }
        public bool esContent { get; set; }
        public string urlRutaContent { get; set; }
        public Nullable<short> noFilasVisionGeneral { get; set; }
        public Nullable<int> idFuncionalidadPadre { get; set; }
        public Nullable<int> idCodigoTipoOperacion { get; set; }
        public Nullable<int> noOrden { get; set; }
    
        public virtual Aplicacion Aplicacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionalidad> Funcionalidad1 { get; set; }
        public virtual Funcionalidad Funcionalidad2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuncionalidadXRol> FuncionalidadXRol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuMaster> MenuMaster { get; set; }
    }
}
