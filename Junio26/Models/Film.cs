using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("film")]
    [Index(nameof(LanguageId), Name = "idx_fk_language_id")]
    [Index(nameof(OriginalLanguageId), Name = "idx_fk_original_language_id")]
    public partial class Film
    {
        public Film()
        {
            FilmActors = new HashSet<FilmActor>();
            FilmCategories = new HashSet<FilmCategory>();
            Inventories = new HashSet<Inventory>();
        }

        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("description", TypeName = "text")]
        public string Description { get; set; }
        [Column("release_year")]
        [StringLength(4)]
        public string ReleaseYear { get; set; }
        [Column("language_id")]
        public byte LanguageId { get; set; }
        [Column("original_language_id")]
        public byte? OriginalLanguageId { get; set; }
        [Column("rental_duration")]
        public byte RentalDuration { get; set; }
        [Column("rental_rate", TypeName = "decimal(4, 2)")]
        public decimal RentalRate { get; set; }
        [Column("length")]
        public short? Length { get; set; }
        [Column("replacement_cost", TypeName = "decimal(5, 2)")]
        public decimal ReplacementCost { get; set; }
        [Column("rating")]
        [StringLength(10)]
        public string Rating { get; set; }
        [Column("special_features")]
        [StringLength(255)]
        public string SpecialFeatures { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [InverseProperty("FilmLanguages")]
        public virtual Language Language { get; set; }
        [ForeignKey(nameof(OriginalLanguageId))]
        [InverseProperty("FilmOriginalLanguages")]
        public virtual Language OriginalLanguage { get; set; }
        [InverseProperty(nameof(FilmActor.Film))]
        public virtual ICollection<FilmActor> FilmActors { get; set; }
        [InverseProperty(nameof(FilmCategory.Film))]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }
        [InverseProperty(nameof(Inventory.Film))]
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
