using Domain;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Persistence;


public partial class DataContext : DbContext
{
    private readonly IConfiguration? _configuration;

    public DataContext (DbContextOptions<DataContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    public virtual DbSet<Advising> Advisings { get; set; }

    public virtual DbSet<College> Colleges { get; set; }

    public virtual DbSet<Major> Majors { get; set; }

    public virtual DbSet<Minor> Minors { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionResponse> QuestionResponses { get; set; }

    public virtual DbSet<Recommender> Recommenders { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Scholarship> Scholarships { get; set; }

    public virtual DbSet<Studentbasic> Studentbasics { get; set; }

    public virtual DbSet<Studentdetail> Studentdetails { get; set; }



    // hide the password
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured && _configuration != null)
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

        modelBuilder.Entity<College>(entity =>
        {
            entity.HasKey(e => new { e.CollegeId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Colleges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_colleges_studentbasic1");
        });

        modelBuilder.Entity<Major>(entity =>
        {
            entity.HasKey(e => new { e.MajorId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Majors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_majors_studentbasic1");
        });

        modelBuilder.Entity<Minor>(entity =>
        {
            entity.HasKey(e => new { e.MinorId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Minors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_minors_studentbasic1");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PRIMARY");
        });

        modelBuilder.Entity<QuestionResponse>(entity =>
        {
            entity.HasKey(e => new { e.QuestionsQuestionId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.QuestionsQuestion).WithMany(p => p.QuestionResponses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_questionResponse_questions1");

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.QuestionResponses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_questionResponse_studentbasic1");
        });

        modelBuilder.Entity<Recommender>(entity =>
        {
            entity.HasKey(e => new { e.RecomId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Recommenders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_recommenders_studentbasic1");
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.HasKey(e => new { e.ResultId, e.StudentbasicStudentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.HasOne(d => d.StudentbasicStudent).WithMany(p => p.Results)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_results_studentbasic1");
        });

        modelBuilder.Entity<Scholarship>(entity =>
        {
            entity.HasKey(e => e.ScholId).HasName("PRIMARY");

            entity.HasMany(d => d.QuestionsQuestions).WithMany(p => p.ScholarshipsSchols)
                .UsingEntity<Dictionary<string, object>>(
                    "QuestionCorrespond",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionsQuestionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_questionCorrespond_questions1"),
                    l => l.HasOne<Scholarship>().WithMany()
                        .HasForeignKey("ScholarshipsScholId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_questionCorrespond_scholarships1"),
                    j =>
                    {
                        j.HasKey("ScholarshipsScholId", "QuestionsQuestionId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("questionCorrespond");
                        j.HasIndex(new[] { "QuestionsQuestionId" }, "fk_questionCorrespond_questions1");
                        j.IndexerProperty<int>("ScholarshipsScholId").HasColumnName("scholarships_scholID");
                        j.IndexerProperty<int>("QuestionsQuestionId").HasColumnName("questions_questionID");
                    });
        });

        modelBuilder.Entity<Studentbasic>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PRIMARY");

            entity.HasMany(d => d.ScholarshipsSchols).WithMany(p => p.StudentbasicStudents)
                .UsingEntity<Dictionary<string, object>>(
                    "ScholarSelection",
                    r => r.HasOne<Scholarship>().WithMany()
                        .HasForeignKey("ScholarshipsScholId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_questionSelection_scholarships1"),
                    l => l.HasOne<Studentbasic>().WithMany()
                        .HasForeignKey("StudentbasicStudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_e11_has_studentbasic_studentbasic1"),
                    j =>
                    {
                        j.HasKey("StudentbasicStudentId", "ScholarshipsScholId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("scholarSelection");
                        j.HasIndex(new[] { "ScholarshipsScholId" }, "fk_questionSelection_scholarships1");
                        j.IndexerProperty<string>("StudentbasicStudentId")
                            .HasMaxLength(36)
                            .HasColumnName("studentbasic_studentID");
                        j.IndexerProperty<int>("ScholarshipsScholId").HasColumnName("scholarships_scholID");
                    });
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
