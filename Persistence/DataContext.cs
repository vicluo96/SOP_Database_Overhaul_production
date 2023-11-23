using Domain;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Persistence;


public partial class DataContext : DbContext
{
    private readonly IConfiguration? _configuration;
    public DataContext ()
    {
    }

    public DataContext (DbContextOptions<DataContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    public virtual DbSet<Advising> Advisings { get; set; }

    // public virtual DbSet<College> Colleges { get; set; }

    // public virtual DbSet<DynamicQuestion> DynamicQuestions { get; set; }

    // public virtual DbSet<E11> E11s { get; set; }

    // public virtual DbSet<Major> Majors { get; set; }

    // public virtual DbSet<Minor> Minors { get; set; }

    // public virtual DbSet<QuestionResponse> QuestionResponses { get; set; }

    // public virtual DbSet<Recommender> Recommenders { get; set; }

    // public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Studentbasic> Studentbasics { get; set; }
    public virtual DbSet<Studentdetail> Studentdetails { get; set; }
    public virtual DbSet<Advising> Advisings { get; set; }



//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseMySql("server=localhost;user=root;database=;password=;port=3306", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));

    // hide the password
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
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Advising>(entity =>
        {
            entity.HasKey(e => new { e.PrepId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Advisings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_advising_studentbasic1");
        });

        // modelBuilder.Entity<College>(entity =>
        // {
        //     entity.HasKey(e => e.CollegeId).HasName("PRIMARY");

        //     entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Colleges)
        //         .OnDelete(DeleteBehavior.ClientSetNull)
        //         .HasConstraintName("fk_colleges_studentbasic1");
        // });

        // modelBuilder.Entity<DynamicQuestion>(entity =>
        // {
        //     entity.HasKey(e => e.QuestionId).HasName("PRIMARY");

        //     entity.HasMany(d => d.E11E11s).WithMany(p => p.DqQuestions)
        //         .UsingEntity<Dictionary<string, object>>(
        //             "E11Question",
        //             r => r.HasOne<E11>().WithMany()
        //                 .HasForeignKey("E11E11Id")
        //                 .OnDelete(DeleteBehavior.ClientSetNull)
        //                 .HasConstraintName("fk_dynamicQuestions_has_e11_e111"),
        //             l => l.HasOne<DynamicQuestion>().WithMany()
        //                 .HasForeignKey("DqQuestionId")
        //                 .OnDelete(DeleteBehavior.ClientSetNull)
        //                 .HasConstraintName("fk_dynamicQuestions_has_e11_dynamicQuestions1"),
        //             j =>
        //             {
        //                 j.HasKey("DqQuestionId", "E11E11Id")
        //                     .HasName("PRIMARY")
        //                     .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        //                 j.ToTable("e11Questions");
        //                 j.HasIndex(new[] { "E11E11Id" }, "fk_dynamicQuestions_has_e11_e111");
        //                 j.IndexerProperty<int>("DqQuestionId").HasColumnName("dq_questionID");
        //                 j.IndexerProperty<int>("E11E11Id").HasColumnName("e11_e11ID");
        //             });
        // });

        // modelBuilder.Entity<E11>(entity =>
        // {
        //     entity.HasKey(e => e.E11Id).HasName("PRIMARY");

        //     entity.HasMany(d => d.StudentbasicStudents).WithMany(p => p.E11E11s)
        //         .UsingEntity<Dictionary<string, object>>(
        //             "E11Selection",
        //             r => r.HasOne<Studentbasic>().WithMany()
        //                 .HasForeignKey("StudentbasicStudentId")
        //                 .OnDelete(DeleteBehavior.ClientSetNull)
        //                 .HasConstraintName("fk_e11_has_studentbasic_studentbasic1"),
        //             l => l.HasOne<E11>().WithMany()
        //                 .HasForeignKey("E11E11Id")
        //                 .OnDelete(DeleteBehavior.ClientSetNull)
        //                 .HasConstraintName("fk_e11_has_studentbasic_e111"),
        //             j =>
        //             {
        //                 j.HasKey("E11E11Id", "StudentbasicStudentId")
        //                     .HasName("PRIMARY")
        //                     .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        //                 j.ToTable("e11Selection");
        //                 j.HasIndex(new[] { "StudentbasicStudentId" }, "fk_e11_has_studentbasic_studentbasic1");
        //                 j.IndexerProperty<int>("E11E11Id").HasColumnName("e11_e11ID");
        //                 j.IndexerProperty<string>("StudentbasicStudentId")
        //                     .HasMaxLength(36)
        //                     .HasColumnName("studentbasic_studentID");
        //             });
        // });

        // modelBuilder.Entity<Major>(entity =>
        // {
        //     entity.HasKey(e => e.MajorId).HasName("PRIMARY");

        //     entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Majors)
        //         .OnDelete(DeleteBehavior.ClientSetNull)
        //         .HasConstraintName("fk_majors_studentbasic1");
        // });

        // modelBuilder.Entity<Minor>(entity =>
        // {
        //     entity.HasKey(e => e.MinorId).HasName("PRIMARY");

        //     entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Minors)
        //         .OnDelete(DeleteBehavior.ClientSetNull)
        //         .HasConstraintName("fk_majors_studentbasic10");
        // });

        // modelBuilder.Entity<QuestionResponse>(entity =>
        // {
        //     entity.HasKey(e => new { e.StudentbasicStudentId, e.DynamicQuestionsQuestionId })
        //         .HasName("PRIMARY")
        //         .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

        //     entity.HasOne(d => d.DynamicQuestionsQuestion).WithMany(p => p.QuestionResponses)
        //         .OnDelete(DeleteBehavior.ClientSetNull)
        //         .HasConstraintName("fk_questionResponse_dynamicQuestions1");

        //     entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.QuestionResponses)
        //         .OnDelete(DeleteBehavior.ClientSetNull)
        //         .HasConstraintName("fk_questionResponse_studentbasic1");
        // });

        // modelBuilder.Entity<Recommender>(entity =>
        // {
        //     entity.HasKey(e => new { e.RecomId, e.StudentbasicStudentId })
        //         .HasName("PRIMARY")
        //         .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

        //     entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Recommenders)
        //         .OnDelete(DeleteBehavior.ClientSetNull)
        //         .HasConstraintName("fk_recommenders_studentbasic1");
        // });

        // modelBuilder.Entity<Result>(entity =>
        // {
        //     entity.HasKey(e => new { e.CurStatus, e.StudentbasicStudentId })
        //         .HasName("PRIMARY")
        //         .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

        //     entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Results)
        //         .OnDelete(DeleteBehavior.ClientSetNull)
        //         .HasConstraintName("fk_results_studentbasic1");
        // });

        modelBuilder.Entity<Studentbasic>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PRIMARY");
        });
        modelBuilder.Entity<Advising>(entity =>
        {
            entity.HasKey(e => new { e.DetailId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Studentdetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_studentdetail_studentbasic1");
        });

        // modelBuilder.Entity<T10>(entity =>
        // {
        //     entity.HasKey(e => e.T10Id).HasName("PRIMARY");

        //     entity.HasMany(d => d.StudentbasicStudents).WithMany(p => p.T10T10s)
        //         .UsingEntity<Dictionary<string, object>>(
        //             "T10Selection",
        //             r => r.HasOne<Studentbasic>().WithMany()
        //                 .HasForeignKey("StudentbasicStudentId")
        //                 .OnDelete(DeleteBehavior.ClientSetNull)
        //                 .HasConstraintName("fk_t10_has_studentbasic_studentbasic1"),
        //             l => l.HasOne<T10>().WithMany()
        //                 .HasForeignKey("T10T10Id")
        //                 .OnDelete(DeleteBehavior.ClientSetNull)
        //                 .HasConstraintName("fk_t10_has_studentbasic_t101"),
        //             j =>
        //             {
        //                 j.HasKey("T10T10Id", "StudentbasicStudentId")
        //                     .HasName("PRIMARY")
        //                     .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
        //                 j.ToTable("t10Selection");
        //                 j.HasIndex(new[] { "StudentbasicStudentId" }, "fk_t10_has_studentbasic_studentbasic1");
        //                 j.IndexerProperty<int>("T10T10Id").HasColumnName("t10_t10ID");
        //                 j.IndexerProperty<string>("StudentbasicStudentId")
        //                     .HasMaxLength(36)
        //                     .HasColumnName("studentbasic_studentID");
        //             });
        // });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
