using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Junio19MVCEF.Models
{
    public partial class Repuesto
    {
        [Key]
        public int IdRepuesto { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Nombre { get; set; }
    }
}
