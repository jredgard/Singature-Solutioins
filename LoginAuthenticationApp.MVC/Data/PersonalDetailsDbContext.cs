using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoginAuthenticationApp.MVC.Data;

public partial class PersonalDetailsDbContext : DbContext
{
    public PersonalDetailsDbContext(DbContextOptions<PersonalDetailsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Info> Infos { get; set; }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>(entity =>
        {
            entity.HasKey(e => e.PersonId);

            entity.ToTable("Info");

            entity.Property(e => e.PersonId)
                .ValueGeneratedNever()
                .HasColumnName("PersonID");
            entity.Property(e => e.AddressCode).HasMaxLength(50);
            entity.Property(e => e.AddressLine1).HasMaxLength(50);
            entity.Property(e => e.AddressLine2).HasMaxLength(50);
            entity.Property(e => e.AddressLine3).HasMaxLength(50);
            entity.Property(e => e.CellNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PostalAddress1).HasMaxLength(50);
            entity.Property(e => e.PostalAddress2).HasMaxLength(50);
            entity.Property(e => e.PostalAddress3).HasMaxLength(50);
            entity.Property(e => e.TellNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Person).WithOne(p => p.Info)
                .HasForeignKey<Info>(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonID");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("Person");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PersonNavigation)
                .HasForeignKey<Person>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Info_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
