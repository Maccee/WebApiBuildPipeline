using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Azure_02_Web_API_Build_Pipeline.Models;

public partial class PaavontunnitsqldatabaseContext : DbContext
{
    public PaavontunnitsqldatabaseContext()
    {
    }

    public PaavontunnitsqldatabaseContext(DbContextOptions<PaavontunnitsqldatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Paavontunnit> Paavontunnits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=tcp:paavontunnitsqlserver.database.windows.net,1433;Initial Catalog=paavontunnitsqldatabase;Persist Security Info=False;User ID=paavontunnitsqlserver;Password=6KV)f#xx89;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Paavontunnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__paavontu__3213E83FF62CBB3B");

            entity.ToTable("paavontunnit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Msg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("msg");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
