using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    public partial class Compania
    {
        [Key]
        public int IdCompania { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
