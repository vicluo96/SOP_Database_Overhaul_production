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
    [Migration("20231118062123_InitialT")]
    partial class InitialT
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Advising", b =>
                {
                    b.Property<string>("PrepId")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("prepID");

                    b.Property<string>("OrienE11")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("orienE11");

                    b.Property<string>("OrienT10")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("orienT10");

                    b.Property<int?>("PaAppNo")
                        .HasColumnType("int")
                        .HasColumnName("paAppNo");

                    b.Property<string>("PrepStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("prepStatus");

                    b.HasKey("PrepId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "PrepId" }, "prepID_UNIQUE")
                        .IsUnique();

                    b.ToTable("advising");
                });

            modelBuilder.Entity("Domain.Studentbasic", b =>
                {
                    b.Property<string>("StudentId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("studentID");

                    b.Property<string>("StudentdetailDetailId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("studentdetail_detailId");

                    b.Property<string>("AdvisingPrepId")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("advising_prepID");

                    b.Property<string>("AdvisingPrepId1")
                        .IsRequired()
                        .HasColumnType("varchar(45)");

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
                        .HasColumnType("varchar(100)");

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

                    b.HasKey("StudentId", "StudentdetailDetailId", "AdvisingPrepId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                    b.HasIndex("AdvisingPrepId");

                    b.HasIndex("AdvisingPrepId1");

                    b.HasIndex(new[] { "PersonalEmail" }, "EmailAddress")
                        .IsUnique();

                    b.ToTable("studentbasic");
                });

            modelBuilder.Entity("Domain.Studentdetail", b =>
                {
                    b.Property<string>("DetailId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("detailId");

                    b.Property<sbyte?>("Asuci")
                        .HasColumnType("tinyint")
                        .HasColumnName("asuci");

                    b.Property<sbyte?>("Chc")
                        .HasColumnType("tinyint")
                        .HasColumnName("chc");

                    b.Property<string>("ConsentForm")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("consentForm");

                    b.Property<string>("Cv")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("cv");

                    b.Property<short?>("GradYear")
                        .HasColumnType("year")
                        .HasColumnName("gradYear");

                    b.Property<string>("HighDegree")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("highDegree");

                    b.Property<sbyte?>("HonorProg")
                        .HasColumnType("tinyint")
                        .HasColumnName("honorProg");

                    b.Property<sbyte?>("Larc")
                        .HasColumnType("tinyint")
                        .HasColumnName("larc");

                    b.Property<decimal?>("LeadExpMon")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("leadExpMon");

                    b.Property<sbyte?>("LowIncome")
                        .HasColumnType("tinyint")
                        .HasColumnName("lowIncome");

                    b.Property<sbyte?>("Paa")
                        .HasColumnType("tinyint")
                        .HasColumnName("paa");

                    b.Property<sbyte?>("Pbk")
                        .HasColumnType("tinyint")
                        .HasColumnName("pbk");

                    b.Property<sbyte?>("Sage")
                        .HasColumnType("tinyint")
                        .HasColumnName("sage");

                    b.Property<decimal?>("ServeExpMon")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("serveExpMon");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("studentID");

                    b.Property<bool?>("TranStu")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("tranStu");

                    b.Property<string>("Transcript")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("transcript");

                    b.Property<sbyte?>("Urop")
                        .HasColumnType("tinyint")
                        .HasColumnName("urop");

                    b.Property<sbyte?>("UsCitizen")
                        .HasColumnType("tinyint")
                        .HasColumnName("usCitizen");

                    b.Property<sbyte?>("Ushp")
                        .HasColumnType("tinyint")
                        .HasColumnName("ushp");

                    b.Property<sbyte?>("Veteran")
                        .HasColumnType("tinyint")
                        .HasColumnName("veteran");

                    b.HasKey("DetailId")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "DetailId" }, "detailId_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "StudentId" }, "studentID_UNIQUE")
                        .IsUnique();

                    b.ToTable("studentdetail");
                });

            modelBuilder.Entity("Domain.Studentbasic", b =>
                {
                    b.HasOne("Domain.Studentdetail", "StudentdetailDetail")
                        .WithMany("Studentbasics")
                        .HasForeignKey("AdvisingPrepId")
                        .IsRequired()
                        .HasConstraintName("fk_studentbasic_studentdetail1");

                    b.HasOne("Domain.Advising", null)
                        .WithMany("Studentbasics")
                        .HasForeignKey("AdvisingPrepId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentdetailDetail");
                });

            modelBuilder.Entity("Domain.Advising", b =>
                {
                    b.Navigation("Studentbasics");
                });

            modelBuilder.Entity("Domain.Studentdetail", b =>
                {
                    b.Navigation("Studentbasics");
                });
#pragma warning restore 612, 618
        }
    }
}
