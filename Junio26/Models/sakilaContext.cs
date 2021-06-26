using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Junio26.Models
{
    public partial class sakilaContext : DbContext
    {
        public sakilaContext()
        {
        }

        public sakilaContext(DbContextOptions<sakilaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Camioneta> Camionetas { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Cliente1> Clientes1 { get; set; }
        public virtual DbSet<Compania> Companias { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerList> CustomerLists { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmActor> FilmActors { get; set; }
        public virtual DbSet<FilmCategory> FilmCategories { get; set; }
        public virtual DbSet<FilmList> FilmLists { get; set; }
        public virtual DbSet<FilmText> FilmTexts { get; set; }
        public virtual DbSet<Indicadore> Indicadores { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<SalesByFilmCategory> SalesByFilmCategories { get; set; }
        public virtual DbSet<SalesByStore> SalesByStores { get; set; }
        public virtual DbSet<StaffList> StaffLists { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vgrafico> Vgraficos { get; set; }
        public virtual DbSet<Vistaejemplo> Vistaejemplos { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(local)\\SQLEXPRESS;Initial Catalog=sakila;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Address1).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.District).IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_address_city");
            });

            modelBuilder.Entity<Camioneta>(entity =>
            {
                entity.Property(e => e.Patente).IsUnicode(false);

                entity.Property(e => e.Modelo).IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.City1).IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_city_country");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__885457EE1BC821DD");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Cliente1>(entity =>
            {
                entity.Property(e => e.Apellido).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Compania>(entity =>
            {
                entity.Property(e => e.IdCompania).ValueGeneratedNever();

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Country1).IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_customer_address");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_customer_store");
            });

            modelBuilder.Entity<CustomerList>(entity =>
            {
                entity.ToView("customer_list");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.ZipCode).IsUnicode(false);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rating)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('G')");

                entity.Property(e => e.ReleaseYear).IsUnicode(false);

                entity.Property(e => e.RentalDuration).HasDefaultValueSql("((3))");

                entity.Property(e => e.RentalRate).HasDefaultValueSql("((4.99))");

                entity.Property(e => e.ReplacementCost).HasDefaultValueSql("((19.99))");

                entity.Property(e => e.SpecialFeatures).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FilmLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_language");

                entity.HasOne(d => d.OriginalLanguage)
                    .WithMany(p => p.FilmOriginalLanguages)
                    .HasForeignKey(d => d.OriginalLanguageId)
                    .HasConstraintName("fk_film_language_original");
            });

            modelBuilder.Entity<FilmActor>(entity =>
            {
                entity.HasKey(e => new { e.ActorId, e.FilmId })
                    .HasName("PK__film_act__086D31FE38996AB5");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.FilmActors)
                    .HasForeignKey(d => d.ActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_actor_actor");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmActors)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_actor_film");
            });

            modelBuilder.Entity<FilmCategory>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.CategoryId })
                    .HasName("PK__film_cat__69C38A323F466844");

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FilmCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_category_category");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmCategories)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_film_category_film");
            });

            modelBuilder.Entity<FilmList>(entity =>
            {
                entity.ToView("film_list");

                entity.Property(e => e.Actors).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<FilmText>(entity =>
            {
                entity.HasKey(e => e.FilmId)
                    .HasName("PK__film_tex__349764A945F365D3");

                entity.Property(e => e.FilmId).ValueGeneratedNever();

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<Indicadore>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inventory_film");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_inventory_store");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payment_customer");

                entity.HasOne(d => d.Rental)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.RentalId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_payment_rental");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payment_staff");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.Imagen).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rental_customer");

                entity.HasOne(d => d.Inventory)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.InventoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rental_inventory");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Rentals)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rental_staff");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__3C872F762A164134");

                entity.Property(e => e.IdRol).ValueGeneratedNever();

                entity.Property(e => e.NombreRol).IsUnicode(false);
            });

            modelBuilder.Entity<SalesByFilmCategory>(entity =>
            {
                entity.ToView("sales_by_film_category");

                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<SalesByStore>(entity =>
            {
                entity.ToView("sales_by_store");

                entity.Property(e => e.Manager).IsUnicode(false);

                entity.Property(e => e.Store).IsUnicode(false);
            });

            modelBuilder.Entity<StaffList>(entity =>
            {
                entity.ToView("staff_list");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.ZipCode).IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_store_address");

                entity.HasOne(d => d.ManagerStaff)
                    .WithOne(p => p.Store)
                    .HasForeignKey<Store>(d => d.ManagerStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_store_staff");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Rut)
                    .HasName("PK__Usuario__C2B74E773493CFA7");

                entity.Property(e => e.Rut).IsUnicode(false);

                entity.Property(e => e.Apellido).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<Vgrafico>(entity =>
            {
                entity.ToView("VGRAFICO");
            });

            modelBuilder.Entity<Vistaejemplo>(entity =>
            {
                entity.ToView("vistaejemplo");

                entity.Property(e => e.Country).IsUnicode(false);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.Property(e => e.StaffId).ValueGeneratedOnAdd();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_staff_address");

                entity.HasOne(d => d.StoreNavigation)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_staff_store");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
