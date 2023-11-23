using Domain;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Persistence;

// public class DataContext : DbContext
// {
//     public DataContext()
//     {
//     }
//     public DataContext(DbContextOptions options) : base(options)
//     {

//     }

//     public DbSet<Studentbasic> Studentbasics { get; set; }
//     public DbSet<Advising> Advisings { get; set; }

//     public DbSet<Studentdetail> Studentdetails { get; set; }
    
//     //add new tables
// }

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

    public virtual DbSet<Advising> Advisings { get; set; }

    // public virtual DbSet<College> Colleges { get; set; }

    // public virtual DbSet<E11> E11s { get; set; }

    // public virtual DbSet<Major> Majors { get; set; }

    // public virtual DbSet<Recommender> Recommenders { get; set; }

    // public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Studentbasic> Studentbasics { get; set; }

    public virtual DbSet<Studentdetail> Studentdetails { get; set; }

    // public virtual DbSet<T10> T10s { get; set; }

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
        // modelBuilder
        //     .UseCollation("utf8mb4_0900_ai_ci")
        //     .HasCharSet("utf8mb4");

        modelBuilder.Entity<Advising>(entity =>
        {
            entity.HasKey(e => e.PrepId).HasName("PRIMARY");
        });

        // modelBuilder.Entity<College>(entity =>
        // {
        //     entity.HasKey(e => e.Id).HasName("PRIMARY");
        // });

        // modelBuilder.Entity<E11>(entity =>
        // {
        //     entity.HasKey(e => e.CaliforniaCap).HasName("PRIMARY");

        //     entity.Property(e => e.CaliforniaCap).ValueGeneratedNever();
        // });

        // modelBuilder.Entity<Major>(entity =>
        // {
        //     entity.HasKey(e => e.MajorId).HasName("PRIMARY");
        // });

        // modelBuilder.Entity<Recommender>(entity =>
        // {
        //     entity.HasKey(e => new { e.RecomId, e.StudentbasicStudentId, e.StudentbasicStudentdetailDetailId })
        //         .HasName("PRIMARY")
        //         .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        // });

        // modelBuilder.Entity<Result>(entity =>
        // {
        //     entity.HasKey(e => new { e.CurStatus, e.StudentbasicStudentId, e.StudentbasicStudentdetailDetailId })
        //         .HasName("PRIMARY")
        //         .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
        // });

        modelBuilder.Entity<Studentbasic>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PRIMARY");

            // entity.HasOne(d => d.AdvisingPrep).WithMany(p => p.Studentbasics)
            //     .OnDelete(DeleteBehavior.ClientSetNull)
            //     .HasConstraintName("fk_studentbasic_advising1");

            entity.HasOne(d => d.StudentdetailDetail).WithMany(p => p.Studentbasics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_studentbasic_studentdetail1");
        });

        modelBuilder.Entity<Studentdetail>(entity =>
        {
            entity.HasKey(e => e.DetailId).HasName("PRIMARY");
        });

        // modelBuilder.Entity<T10>(entity =>
        // {
        //     entity.HasKey(e => e.Idt10).HasName("PRIMARY");
        // });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
