using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("category")]
    public partial class Category
    {
        public Category()
        {
            FilmCategories = new HashSet<FilmCategory>();
        }

        [Key]
        [Column("category_id")]
        public byte CategoryId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty(nameof(FilmCategory.Category))]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }
    }
}
