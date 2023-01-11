using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LogBook
{
    [Table("Errorlog", Schema = "LogBook")]
    public partial class Errorlog
    {
        [Key]
        public long idLog { get; set; }
        public long idSesionLog { get; set; }
        [Required]
        [StringLength(15)]
        public string codAplicacion { get; set; }
        [Required]
        [StringLength(25)]
        public string nbAlias { get; set; }
        [StringLength(50)]
        public string dsHost { get; set; }
        public string dsNotification { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime feCreacion { get; set; }
    }
}
