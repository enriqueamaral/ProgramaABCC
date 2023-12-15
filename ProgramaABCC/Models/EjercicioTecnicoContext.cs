using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProgramaABCC.Models;

public partial class EjercicioTecnicoContext : DbContext
{
    public EjercicioTecnicoContext()
    {
    }

    public EjercicioTecnicoContext(DbContextOptions<EjercicioTecnicoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<Clase> Clases { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Familia> Familias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SADGLORY-PC\\SQLEXPRESS;Database=Ejercicio_Tecnico;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.Sku);

            entity.Property(e => e.Sku).HasColumnType("numeric(6, 0)");
            entity.Property(e => e.Articulo1)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("Articulo");
            entity.Property(e => e.Cantidad).HasColumnType("numeric(9, 0)");
            entity.Property(e => e.Clase).HasColumnType("numeric(2, 0)");
            entity.Property(e => e.Departamento).HasColumnType("numeric(1, 0)");
            entity.Property(e => e.Descontinuado).HasColumnType("numeric(1, 0)");
            entity.Property(e => e.Familia).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.FechaAlta).HasColumnType("date");
            entity.Property(e => e.FechaBaja).HasColumnType("date");
            entity.Property(e => e.Marca)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.Modelo)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Stock).HasColumnType("numeric(9, 0)");
        });

        modelBuilder.Entity<Clase>(entity =>
        {
            entity.Property(e => e.NombreClase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroClase).HasColumnType("numeric(2, 0)");
            entity.Property(e => e.NumeroDepartamento).HasColumnType("numeric(1, 0)");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.Property(e => e.NombreDepartamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDepartamento).HasColumnType("numeric(1, 0)");
        });

        modelBuilder.Entity<Familia>(entity =>
        {
            entity.Property(e => e.NombreClase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreFamilia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroClase).HasColumnType("numeric(2, 0)");
            entity.Property(e => e.NumeroFamilia).HasColumnType("numeric(3, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
