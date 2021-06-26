using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    public partial class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [StringLength(200)]
        public string Nombre { get; set; }
        [StringLength(200)]
        public string Imagen { get; set; }
    }
}
