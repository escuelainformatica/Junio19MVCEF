using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("actor")]
    [Index(nameof(LastName), Name = "idx_actor_last_name")]
    public partial class Actor
    {
        public Actor()
        {
            FilmActors = new HashSet<FilmActor>();
        }

        [Key]
        [Column("actor_id")]
        public int ActorId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty(nameof(FilmActor.Actor))]
        public virtual ICollection<FilmActor> FilmActors { get; set; }
    }
}
