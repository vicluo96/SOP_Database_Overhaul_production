﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231129062350_schl")]
    partial class schl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("Domain.Advising", b =>
                {
                    b.Property<string>("PrepId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("prepID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<string>("OrienE11")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("orienE11");

                    b.Property<string>("OrienT10")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("orienT10");

                    b.Property<int?>("PaAppNo")
                        .HasColumnType("int")
                        .HasColumnName("paAppNo");

                    b.Property<string>("PrepStatus")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("prepStatus");

                    b.HasKey("PrepId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_advising_studentbasic1");

                    b.HasIndex(new[] { "PrepId" }, "prepID_UNIQUE")
                        .IsUnique();

                    b.ToTable("advising");
                });

            modelBuilder.Entity("Domain.College", b =>
                {
                    b.Property<string>("CollegeId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("collegeID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<string>("CollegeName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("collegeName");

                    b.Property<decimal?>("Gpa")
                        .HasPrecision(3, 2)
                        .HasColumnType("decimal(3,2)")
                        .HasColumnName("gpa");

                    b.HasKey("CollegeId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "CollegeId" }, "e11ID_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_colleges_studentbasic1");

                    b.ToTable("colleges");
                });

            modelBuilder.Entity("Domain.Major", b =>
                {
                    b.Property<string>("MajorId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("majorID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("majorName");

                    b.HasKey("MajorId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_majors_studentbasic1");

                    b.HasIndex(new[] { "MajorId" }, "majorID_UNIQUE")
                        .IsUnique();

                    b.ToTable("majors");
                });

            modelBuilder.Entity("Domain.Minor", b =>
                {
                    b.Property<string>("MinorId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("minorID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<string>("MinorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("minorName");

                    b.HasKey("MinorId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_minors_studentbasic1");

                    b.HasIndex(new[] { "MinorId" }, "majorID_UNIQUE")
                        .IsUnique()
                        .HasDatabaseName("majorID_UNIQUE1");

                    b.ToTable("minors");
                });

            modelBuilder.Entity("Domain.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("questionID");

                    b.Property<string>("QuestionText")
                        .HasMaxLength(1500)
                        .HasColumnType("varchar(1500)")
                        .HasColumnName("questionText");

                    b.Property<string>("T10Ore11")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("t10ORe11");

                    b.HasKey("QuestionId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "QuestionId" }, "questionID_UNIQUE")
                        .IsUnique();

                    b.ToTable("questions");
                });

            modelBuilder.Entity("Domain.QuestionResponse", b =>
                {
                    b.Property<int>("QuestionsQuestionId")
                        .HasColumnType("int")
                        .HasColumnName("questions_questionID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<string>("ResponseText")
                        .HasColumnType("mediumtext")
                        .HasColumnName("responseText");

                    b.HasKey("QuestionsQuestionId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_questionResponse_studentbasic1");

                    b.ToTable("questionResponse");
                });

            modelBuilder.Entity("Domain.Recommender", b =>
                {
                    b.Property<string>("RecomId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("recomID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<string>("Cycle")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("cycle");

                    b.Property<string>("Recommender1")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("recommender");

                    b.HasKey("RecomId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_recommenders_studentbasic1");

                    b.HasIndex(new[] { "RecomId" }, "recomID_UNIQUE")
                        .IsUnique();

                    b.ToTable("recommenders");
                });

            modelBuilder.Entity("Domain.Result", b =>
                {
                    b.Property<string>("ResultId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("resultID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<string>("CurStatus")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("curStatus");

                    b.Property<bool?>("SopProfile")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("sopProfile");

                    b.Property<bool?>("SopSurvey")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("sopSurvey");

                    b.HasKey("ResultId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_results_studentbasic1");

                    b.HasIndex(new[] { "ResultId" }, "resultID_UNIQUE")
                        .IsUnique();

                    b.ToTable("results");
                });

            modelBuilder.Entity("Domain.Scholarship", b =>
                {
                    b.Property<int>("ScholId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("scholID");

                    b.Property<string>("ScholName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("scholName");

                    b.HasKey("ScholId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ScholId" }, "e11ID_UNIQUE")
                        .IsUnique()
                        .HasDatabaseName("e11ID_UNIQUE1");

                    b.ToTable("scholarships");
                });

            modelBuilder.Entity("Domain.Studentbasic", b =>
                {
                    b.Property<string>("StudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentID");

                    b.Property<byte?>("Age")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("age");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("LegalFirstName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("legalFirstName");

                    b.Property<string>("LegalLastName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("legalLastName");

                    b.Property<string>("PersonalEmail")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("personalEmail");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("PreferredFirstName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("preferredFirstName");

                    b.Property<string>("Pronouns")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pronouns");

                    b.Property<decimal?>("UciGpa")
                        .HasPrecision(3, 2)
                        .HasColumnType("decimal(3,2)")
                        .HasColumnName("uciGPA");

                    b.HasKey("StudentId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "StudentId" }, "studentID_UNIQUE")
                        .IsUnique();

                    b.ToTable("studentbasic");
                });

            modelBuilder.Entity("Domain.Studentdetail", b =>
                {
                    b.Property<string>("DetailId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("detailID");

                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<bool?>("Asuci")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("asuci");

                    b.Property<bool?>("Chc")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("chc");

                    b.Property<string>("ConsentFormE11")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("consentFormE11");

                    b.Property<string>("ConsentFormT10")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("consentFormT10");

                    b.Property<string>("CvE11")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cvE11");

                    b.Property<string>("CvT10")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cvT10");

                    b.Property<short?>("GradYear")
                        .HasColumnType("year")
                        .HasColumnName("gradYear");

                    b.Property<string>("HighDegree")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("highDegree");

                    b.Property<bool?>("HonorProg")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("honorProg");

                    b.Property<bool?>("Larc")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("larc");

                    b.Property<decimal?>("LeadExpMon")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("leadExpMon");

                    b.Property<bool?>("LowIncome")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("lowIncome");

                    b.Property<bool?>("Paa")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("paa");

                    b.Property<bool?>("Pbk")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("pbk");

                    b.Property<bool?>("Sage")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("sage");

                    b.Property<decimal?>("ServeExpMon")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("serveExpMon");

                    b.Property<bool?>("TranStu")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("tranStu");

                    b.Property<string>("TranscriptE11")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("transcriptE11");

                    b.Property<string>("TranscriptT10")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("transcriptT10");

                    b.Property<bool?>("Urop")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("urop");

                    b.Property<bool?>("UsCitizen")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("usCitizen");

                    b.Property<bool?>("Ushp")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ushp");

                    b.Property<bool?>("Veteran")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("veteran");

                    b.HasKey("DetailId", "StudentbasicStudentId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "DetailId" }, "detailId_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "StudentbasicStudentId" }, "fk_studentdetail_studentbasic1");

                    b.ToTable("studentdetail");
                });

            modelBuilder.Entity("QuestionCorrespond", b =>
                {
                    b.Property<int>("ScholarshipsScholId")
                        .HasColumnType("int")
                        .HasColumnName("scholarships_scholID");

                    b.Property<int>("QuestionsQuestionId")
                        .HasColumnType("int")
                        .HasColumnName("questions_questionID");

                    b.HasKey("ScholarshipsScholId", "QuestionsQuestionId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "QuestionsQuestionId" }, "fk_questionCorrespond_questions1");

                    b.ToTable("questionCorrespond", (string)null);
                });

            modelBuilder.Entity("QuestionScholarship", b =>
                {
                    b.Property<int>("QuestionsQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("ScholarshipsScholId")
                        .HasColumnType("int");

                    b.HasKey("QuestionsQuestionId", "ScholarshipsScholId");

                    b.ToTable("QuestionScholarship");
                });

            modelBuilder.Entity("ScholarSelection", b =>
                {
                    b.Property<string>("StudentbasicStudentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)")
                        .HasColumnName("studentbasic_studentID");

                    b.Property<int>("ScholarshipsScholId")
                        .HasColumnType("int")
                        .HasColumnName("scholarships_scholID");

                    b.HasKey("StudentbasicStudentId", "ScholarshipsScholId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "ScholarshipsScholId" }, "fk_questionSelection_scholarships1");

                    b.ToTable("scholarSelection", (string)null);
                });

            modelBuilder.Entity("ScholarshipStudentbasic", b =>
                {
                    b.Property<int>("ScholarshipsScholId")
                        .HasColumnType("int");

                    b.Property<string>("StudentbasicStudentId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("ScholarshipsScholId", "StudentbasicStudentId");

                    b.ToTable("ScholarshipStudentbasic");
                });

            modelBuilder.Entity("Domain.Advising", b =>
                {
                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("Advisings")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_advising_studentbasic1");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("Domain.College", b =>
                {
                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("Colleges")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_colleges_studentbasic1");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("Domain.Major", b =>
                {
                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("Majors")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_majors_studentbasic1");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("Domain.Minor", b =>
                {
                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("Minors")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_minors_studentbasic1");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("Domain.QuestionResponse", b =>
                {
                    b.HasOne("Domain.Question", "QuestionsQuestion")
                        .WithMany("QuestionResponses")
                        .HasForeignKey("QuestionsQuestionId")
                        .IsRequired()
                        .HasConstraintName("fk_questionResponse_questions1");

                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("QuestionResponses")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_questionResponse_studentbasic1");

                    b.Navigation("QuestionsQuestion");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("Domain.Recommender", b =>
                {
                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("Recommenders")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_recommenders_studentbasic1");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("Domain.Result", b =>
                {
                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("Results")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_results_studentbasic1");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("Domain.Studentdetail", b =>
                {
                    b.HasOne("Domain.Studentbasic", "StudentbasicStudent")
                        .WithMany("Studentdetails")
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_studentdetail_studentbasic1");

                    b.Navigation("StudentbasicStudent");
                });

            modelBuilder.Entity("QuestionCorrespond", b =>
                {
                    b.HasOne("Domain.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsQuestionId")
                        .IsRequired()
                        .HasConstraintName("fk_questionCorrespond_questions1");

                    b.HasOne("Domain.Scholarship", null)
                        .WithMany()
                        .HasForeignKey("ScholarshipsScholId")
                        .IsRequired()
                        .HasConstraintName("fk_questionCorrespond_scholarships1");
                });

            modelBuilder.Entity("ScholarSelection", b =>
                {
                    b.HasOne("Domain.Scholarship", null)
                        .WithMany()
                        .HasForeignKey("ScholarshipsScholId")
                        .IsRequired()
                        .HasConstraintName("fk_questionSelection_scholarships1");

                    b.HasOne("Domain.Studentbasic", null)
                        .WithMany()
                        .HasForeignKey("StudentbasicStudentId")
                        .IsRequired()
                        .HasConstraintName("fk_e11_has_studentbasic_studentbasic1");
                });

            modelBuilder.Entity("Domain.Question", b =>
                {
                    b.Navigation("QuestionResponses");
                });

            modelBuilder.Entity("Domain.Studentbasic", b =>
                {
                    b.Navigation("Advisings");

                    b.Navigation("Colleges");

                    b.Navigation("Majors");

                    b.Navigation("Minors");

                    b.Navigation("QuestionResponses");

                    b.Navigation("Recommenders");

                    b.Navigation("Results");

                    b.Navigation("Studentdetails");
                });
#pragma warning restore 612, 618
        }
    }
}
