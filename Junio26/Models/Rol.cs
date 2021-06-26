using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("Rol")]
    public partial class Rol
    {
        [Key]
        [Column("idRol")]
        public int IdRol { get; set; }
        [Column("nombreRol")]
        [StringLength(255)]
        public string NombreRol { get; set; }
    }
}
