using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("film_category")]
    [Index(nameof(CategoryId), Name = "idx_fk_film_category_category")]
    [Index(nameof(FilmId), Name = "idx_fk_film_category_film")]
    public partial class FilmCategory
    {
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }
        [Key]
        [Column("category_id")]
        public byte CategoryId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("FilmCategories")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(FilmId))]
        [InverseProperty("FilmCategories")]
        public virtual Film Film { get; set; }
    }
}
