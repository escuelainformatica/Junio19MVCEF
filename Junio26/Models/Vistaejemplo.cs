using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Keyless]
    public partial class Vistaejemplo
    {
        [Required]
        [Column("country")]
        [StringLength(50)]
        public string Country { get; set; }
        [Column("cantidad")]
        public int? Cantidad { get; set; }
    }
}
