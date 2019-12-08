using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PIZZAPORTAL.Models
{
    public partial class s17874Context : DbContext
    {
        public s17874Context()
        {
        }

        public s17874Context(DbContextOptions<s17874Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s17874;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.IdCustomer).ValueGeneratedNever();

                entity.Property(e => e.Buildingno)
                    .HasColumnName("BUILDINGNO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Flatno)
                    .HasColumnName("FLATNO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Street)
                    .HasColumnName("STREET")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza);

                entity.ToTable("PIZZA");

                entity.Property(e => e.IdPizza).ValueGeneratedNever();

                entity.Property(e => e.Pizzaname)
                    .HasColumnName("PIZZANAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
