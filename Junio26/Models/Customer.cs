using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("customer")]
    [Index(nameof(AddressId), Name = "idx_fk_address_id")]
    [Index(nameof(StoreId), Name = "idx_fk_store_id")]
    [Index(nameof(LastName), Name = "idx_last_name")]
    public partial class Customer
    {
        public Customer()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
        }

        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("store_id")]
        public int StoreId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("address_id")]
        public int AddressId { get; set; }
        [Required]
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Customers")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Customers")]
        public virtual Store Store { get; set; }
        [InverseProperty(nameof(Payment.Customer))]
        public virtual ICollection<Payment> Payments { get; set; }
        [InverseProperty(nameof(Rental.Customer))]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
