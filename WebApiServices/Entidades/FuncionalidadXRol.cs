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
    
    public partial class FuncionalidadXRol
    {
        public int codRol { get; set; }
        public int idFuncionalidad { get; set; }
        public string cvDominio { get; set; }
        public bool esConsultar { get; set; }
        public bool esActualizar { get; set; }
        public bool esAgregar { get; set; }
        public bool esImprimir { get; set; }
        public bool esEspecial { get; set; }
    
        public virtual Funcionalidad Funcionalidad { get; set; }
    }
}