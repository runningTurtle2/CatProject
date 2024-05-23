using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CatProject.Models;

public partial class CatDbContext : DbContext
{
    public CatDbContext()
    {
    }

    public CatDbContext(DbContextOptions<CatDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivityLevel> ActivityLevels { get; set; }

    public virtual DbSet<Breed> Breeds { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Playfullness> Playfullnesses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=CatDB;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivityLevel>(entity =>
        {
            entity.Property(e => e.ActivityLevelId).HasColumnName("ActivityLevelID");
        });

        modelBuilder.Entity<Breed>(entity =>
        {
            entity.ToTable("Breed");

            entity.Property(e => e.BreedId).HasColumnName("BreedID");
            entity.Property(e => e.Breed1)
                .HasMaxLength(50)
                .HasColumnName("Breed");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.ToTable("Inventory");

            entity.Property(e => e.InventoryId).HasColumnName("InventoryID");
            entity.Property(e => e.ActivityLevelId).HasColumnName("ActivityLevelID");
            entity.Property(e => e.BreedId).HasColumnName("BreedID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.PlayfullnessId).HasColumnName("PlayfullnessID");

            entity.HasOne(d => d.ActivityLevel).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ActivityLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_ActivityLevels");

            entity.HasOne(d => d.Breed).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.BreedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Breed");

            entity.HasOne(d => d.Color).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Colors");

            entity.HasOne(d => d.Playfullness).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.PlayfullnessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventory_Playfullness");
        });

        modelBuilder.Entity<Playfullness>(entity =>
        {
            entity.HasKey(e => e.PlayfullnessId).HasName("PK_Playfullnesses");

            entity.ToTable("Playfullness");

            entity.Property(e => e.PlayfullnessId).HasColumnName("PlayfullnessID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
