using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiProveedorCL1.Models
{
    public partial class cibertec2023Context : DbContext
    {
        public cibertec2023Context()
        {
        }

        public cibertec2023Context(DbContextOptions<cibertec2023Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.ToTable("Proveedor");

                entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");

                entity.Property(e => e.Email)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorLastName)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.ProveeedorName)
                    .HasMaxLength(260)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
