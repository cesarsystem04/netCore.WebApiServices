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
    
    public partial class MenuMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuMaster()
        {
            this.MenuMaster1 = new HashSet<MenuMaster>();
        }
    
        public int idMenuMaster { get; set; }
        public int idFuncionalidad { get; set; }
        public Nullable<int> idMenuMasterParent { get; set; }
        public string codAplicacion { get; set; }
        public Nullable<int> idCodigoCategoria { get; set; }
        public string nbOpcion { get; set; }
        public int noOrden { get; set; }
        public string dsRutaImagen { get; set; }
        public string dsToolTip { get; set; }
        public string codOpcionValue { get; set; }
    
        public virtual Aplicacion Aplicacion { get; set; }
        public virtual Funcionalidad Funcionalidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuMaster> MenuMaster1 { get; set; }
        public virtual MenuMaster MenuMaster2 { get; set; }
    }
}
