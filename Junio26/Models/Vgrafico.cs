using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Keyless]
    public partial class Vgrafico
    {
        [Column(TypeName = "decimal(38, 2)")]
        public decimal? Total { get; set; }
        public int? NumMes { get; set; }
        public int? NumAnyo { get; set; }
    }
}
