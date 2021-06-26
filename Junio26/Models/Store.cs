using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Junio26.Models
{
    [Table("store")]
    [Index(nameof(ManagerStaffId), Name = "idx_fk_address_id", IsUnique = true)]
    [Index(nameof(AddressId), Name = "idx_fk_store_address")]
    public partial class Store
    {
        public Store()
        {
            Customers = new HashSet<Customer>();
            Inventories = new HashSet<Inventory>();
            staff = new HashSet<staff>();
        }

        [Key]
        [Column("store_id")]
        public int StoreId { get; set; }
        [Column("manager_staff_id")]
        public byte ManagerStaffId { get; set; }
        [Column("address_id")]
        public int AddressId { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Stores")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(ManagerStaffId))]
        [InverseProperty("Store")]
        public virtual staff ManagerStaff { get; set; }
        [InverseProperty(nameof(Customer.Store))]
        public virtual ICollection<Customer> Customers { get; set; }
        [InverseProperty(nameof(Inventory.Store))]
        public virtual ICollection<Inventory> Inventories { get; set; }
        [InverseProperty("StoreNavigation")]
        public virtual ICollection<staff> staff { get; set; }
    }
}
