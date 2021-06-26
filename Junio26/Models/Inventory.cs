using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("inventory")]
    [Index(nameof(FilmId), Name = "idx_fk_film_id")]
    [Index(nameof(StoreId), nameof(FilmId), Name = "idx_fk_film_id_store_id")]
    public partial class Inventory
    {
        public Inventory()
        {
            Rentals = new HashSet<Rental>();
        }

        [Key]
        [Column("inventory_id")]
        public int InventoryId { get; set; }
        [Column("film_id")]
        public int FilmId { get; set; }
        [Column("store_id")]
        public int StoreId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(FilmId))]
        [InverseProperty("Inventories")]
        public virtual Film Film { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Inventories")]
        public virtual Store Store { get; set; }
        [InverseProperty(nameof(Rental.Inventory))]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
