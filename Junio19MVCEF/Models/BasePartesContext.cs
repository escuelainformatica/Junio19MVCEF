using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Junio19MVCEF.Models
{
    public partial class BasePartesContext : DbContext
    {
        public BasePartesContext()
        {
        }

        public BasePartesContext(DbContextOptions<BasePartesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Parte> Partes { get; set; }
        public virtual DbSet<Repuesto> Repuestos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(local)\\SQLEXPRESS;Initial Catalog=BasePartes;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Parte>(entity =>
            {
                entity.Property(e => e.IdParte).ValueGeneratedNever();
            });

            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.Property(e => e.IdRepuesto).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
