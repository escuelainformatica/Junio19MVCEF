using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Junio19MVCEF.Models
{
    public partial class Parte
    {
        [Key]
        public int IdParte { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
