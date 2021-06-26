using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("country")]
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        [Key]
        [Column("country_id")]
        public short CountryId { get; set; }


        [Required]
        [Column("country")]
        [StringLength(50)]
        public string Country1 { get; set; }


        [Column("last_update", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }

        [InverseProperty(nameof(City.Country))]
        public virtual ICollection<City> Cities { get; set; }

    }
}
