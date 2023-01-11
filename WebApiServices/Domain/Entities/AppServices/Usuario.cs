using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.AppServices
{
    [Table("Usuario", Schema = "Security")]
    public partial class Usuario
    {
        public Usuario()
        {

        }

        [Key]
        public string nbAlias { get; set; }
        public int idCodigoTipoCuenta { get; set; }
        public string nbLanguageCulture { get; set; }
        public string noEmpleado { get; set; }
        public string nbEmpleado { get; set; }
        public string dsMail { get; set; }
        public bool esActivo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? feRegistro { get; set; }
        public bool esSuperUsuario { get; set; }
        public string dsEmpresa { get; set; }
        public bool esNCPermitido { get; set; }


    }
}
