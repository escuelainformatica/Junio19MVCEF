using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    public partial class Indicadore
    {
        [Key]
        public int IdIndicador { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        public int? Valor { get; set; }
    }
}
