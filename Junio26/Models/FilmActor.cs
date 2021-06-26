using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("film_actor")]
    [Index(nameof(ActorId), Name = "idx_fk_film_actor_actor")]
    [Index(nameof(FilmId), Name = "idx_fk_film_actor_film")]
    public partial class FilmActor
    {
        [Key]
        [Column("actor_id")]
        public int ActorId { get; set; }
        [Key]
        [Column("film_id")]
        public int FilmId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(ActorId))]
        [InverseProperty("FilmActors")]
        public virtual Actor Actor { get; set; }
        [ForeignKey(nameof(FilmId))]
        [InverseProperty("FilmActors")]
        public virtual Film Film { get; set; }
    }
}
