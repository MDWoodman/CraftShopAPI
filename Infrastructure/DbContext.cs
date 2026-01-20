using Microsoft.EntityFrameworkCore;

namespace CraftShopAPI.Infrastructure
{
    public class CraftShopDbContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Additional configuration can go here
            optionsBuilder.UseSqlite("Data Source=craftshop.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration can go here

            modelBuilder.Entity<Domain.Entities.Order>()
                .Property(c => c.OrderId)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Domain.Entities.Invoice>()
                .HasOne<Domain.Entities.Order>()
                .WithMany()
                .HasForeignKey(i => i.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Domain.Entities.BaseProduct>()
               .HasKey(bp => bp.ProductId);

            modelBuilder.Entity<Domain.Entities.BaseProduct>()
                .Property<int>("ProductId")
                .ValueGeneratedOnAdd(); 

            //modelBuilder.Entity<Domain.Entities.Lamp>()
            //.HasKey(bp => bp.ProductId);

            //modelBuilder.Entity<Domain.Entities.Lamp>()
            //    .Property<int>("ProductId")
            //    .ValueGeneratedOnAdd();

            modelBuilder.Entity<Domain.Entities.Chair>()
                .HasBaseType<Domain.Entities.BaseProduct>();

            modelBuilder.Entity<Domain.Entities.CrystalDecor>()
                .HasBaseType<Domain.Entities.BaseProduct>();

            modelBuilder.Entity<Domain.Entities.Lamp>()
                .HasBaseType<Domain.Entities.BaseProduct>();

            modelBuilder.Entity<Domain.Entities.Lamp>().ToTable("Lamp");

   
            modelBuilder.Entity<Domain.Entities.Chair>().ToTable("Chair");

            modelBuilder.Entity<Domain.Entities.Chair>()
               .Property(c => c.ProductId)
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Domain.Entities.CrystalDecor>().ToTable("CrystalDecor");

            modelBuilder.Entity<Domain.Entities.CrystalDecor>()
              .Property(c => c.ProductId)
              .ValueGeneratedOnAdd();


        }
        public DbSet<Domain.Entities.Chair> Chairs { get; set; }
        public DbSet<Domain.Entities.CrystalDecor> CrystalDecors { get; set; }
        public DbSet<Domain.Entities.Order> Orders { get; set; }
        public DbSet<Domain.Entities.Invoice> Invoices { get; set; }
        public DbSet<Domain.Entities.Lamp> Lamps { get; set; }


    }
}
