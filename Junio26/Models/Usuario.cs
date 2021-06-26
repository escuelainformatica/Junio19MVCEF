using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        [Column("rut")]
        [StringLength(255)]
        public string Rut { get; set; }
        [Column("apellido")]
        [StringLength(255)]
        public string Apellido { get; set; }
        [Column("nombre")]
        [StringLength(255)]
        public string Nombre { get; set; }
    }
}
