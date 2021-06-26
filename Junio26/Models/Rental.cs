using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("rental")]
    [Index(nameof(CustomerId), Name = "idx_fk_customer_id")]
    [Index(nameof(InventoryId), Name = "idx_fk_inventory_id")]
    [Index(nameof(StaffId), Name = "idx_fk_staff_id")]
    [Index(nameof(RentalDate), nameof(InventoryId), nameof(CustomerId), Name = "idx_uq", IsUnique = true)]
    public partial class Rental
    {
        public Rental()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        [Column("rental_id")]
        public int RentalId { get; set; }
        [Column("rental_date", TypeName = "datetime")]
        public DateTime RentalDate { get; set; }
        [Column("inventory_id")]
        public int InventoryId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("return_date", TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        [Column("staff_id")]
        public byte StaffId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Rentals")]
        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(InventoryId))]
        [InverseProperty("Rentals")]
        public virtual Inventory Inventory { get; set; }
        [ForeignKey(nameof(StaffId))]
        [InverseProperty(nameof(staff.Rentals))]
        public virtual staff Staff { get; set; }
        [InverseProperty(nameof(Payment.Rental))]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
