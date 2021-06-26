using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("language")]
    public partial class Language
    {
        public Language()
        {
            FilmLanguages = new HashSet<Film>();
            FilmOriginalLanguages = new HashSet<Film>();
        }

        [Key]
        [Column("language_id")]
        public byte LanguageId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty(nameof(Film.Language))]
        public virtual ICollection<Film> FilmLanguages { get; set; }
        [InverseProperty(nameof(Film.OriginalLanguage))]
        public virtual ICollection<Film> FilmOriginalLanguages { get; set; }
    }
}
