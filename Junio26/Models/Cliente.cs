using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Column("nombre")]
        [StringLength(255)]
        public string Nombre { get; set; }
    }
}
