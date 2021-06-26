using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Index(nameof(AddressId), Name = "idx_fk_address_id")]
    [Index(nameof(StoreId), Name = "idx_fk_store_id")]
    public partial class staff
    {
        public staff()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
        }

        [Key]
        [Column("staff_id")]
        public byte StaffId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("address_id")]
        public int AddressId { get; set; }
        [Column("picture", TypeName = "image")]
        public byte[] Picture { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("store_id")]
        public int StoreId { get; set; }
        [Required]
        [Column("active")]
        public bool? Active { get; set; }
        [Required]
        [Column("username")]
        [StringLength(16)]
        public string Username { get; set; }
        [Column("password")]
        [StringLength(40)]
        public string Password { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("staff")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("staff")]
        public virtual Store StoreNavigation { get; set; }
        [InverseProperty("ManagerStaff")]
        public virtual Store Store { get; set; }
        [InverseProperty(nameof(Payment.Staff))]
        public virtual ICollection<Payment> Payments { get; set; }
        [InverseProperty(nameof(Rental.Staff))]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
