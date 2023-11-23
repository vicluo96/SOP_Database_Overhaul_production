using Domain;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Persistence;

public partial class DataContext  : DbContext
{
    private readonly IConfiguration _configuration;
    public DataContext ()
    {
    }

    public DataContext (DbContextOptions<DataContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Studentbasic> Studentbasics { get; set; }
    public virtual DbSet<Studentdetail> Studentdetails { get; set; }
    public virtual DbSet<Advising> Advisings { get; set; }



   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(_configuration.GetConnectionString("Schl"), 
                                    ServerVersion.AutoDetect(_configuration.GetConnectionString("Schl")));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Studentbasic>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Studentdetail>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Studentdetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_studentdetail_studentbasic1");
        });
        modelBuilder.Entity<Advising>(entity =>
        {
            entity.HasKey(e => new { e.PrepId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Advisings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_advising_studentbasic1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
