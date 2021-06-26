using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("address")]
    [Index(nameof(CityId), Name = "idx_fk_city_id")]
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            Stores = new HashSet<Store>();
            staff = new HashSet<staff>();
        }

        [Key]
        [Column("address_id")]
        public int AddressId { get; set; }
        [Required]
        [Column("address")]
        [StringLength(50)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(50)]
        public string Address2 { get; set; }
        [Required]
        [Column("district")]
        [StringLength(20)]
        public string District { get; set; }
        [Column("city_id")]
        public int CityId { get; set; }
        [Column("postal_code")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CityId))]
        [InverseProperty("Addresses")]
        public virtual City City { get; set; }
        [InverseProperty(nameof(Customer.Address))]
        public virtual ICollection<Customer> Customers { get; set; }
        [InverseProperty(nameof(Store.Address))]
        public virtual ICollection<Store> Stores { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<staff> staff { get; set; }
    }
}
