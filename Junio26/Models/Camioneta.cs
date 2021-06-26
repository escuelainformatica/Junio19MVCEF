using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("camionetas")]
    public partial class Camioneta
    {
        [Key]
        [Column("patente")]
        [StringLength(50)]
        public string Patente { get; set; }
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Column("edad")]
        public int? Edad { get; set; }
    }
}
