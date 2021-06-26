using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("city")]
    [Index(nameof(CountryId), Name = "idx_fk_country_id")]
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        [Key]
        [Column("city_id")]
        public int CityId { get; set; }
        [Required]
        [Column("city")]
        [StringLength(50)]
        public string City1 { get; set; }
        [Column("country_id")]
        public short CountryId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Cities")]
        public virtual Country Country { get; set; }



        [InverseProperty(nameof(Address.City))]
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
