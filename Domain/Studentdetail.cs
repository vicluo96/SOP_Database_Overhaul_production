﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("DetailId", "StudentbasicStudentId")]
[Table("studentdetail")]
[Index("DetailId", Name = "detailId_UNIQUE", IsUnique = true)]
[Index("StudentbasicStudentId", Name = "fk_studentdetail_studentbasic1")]
public partial class Studentdetail
{
    [Key]
    [Column("detailID")]
    [StringLength(36)]
    public string DetailId { get; set; }

    [Column("gradYear", TypeName = "year")]
    public short? GradYear { get; set; }

    [Column("serveExpMon")]
    [Precision(5, 2)]
    public decimal? ServeExpMon { get; set; }

    [Column("leadExpMon")]
    [Precision(5, 2)]
    public decimal? LeadExpMon { get; set; }

    [Column("usCitizen")]
    public bool? UsCitizen { get; set; }

    [Column("tranStu")]
    public bool? TranStu { get; set; }

    [Column("lowIncome")]
    public bool? LowIncome { get; set; }

    [Column("pbk")]
    public bool? Pbk { get; set; }

    [Column("chc")]
    public bool? Chc { get; set; }

    [Column("urop")]
    public bool? Urop { get; set; }

    [Column("ushp")]
    public bool? Ushp { get; set; }

    [Column("honorProg")]
    public bool? HonorProg { get; set; }

    [Column("sage")]
    public bool? Sage { get; set; }

    [Column("paa")]
    public bool? Paa { get; set; }

    [Column("larc")]
    public bool? Larc { get; set; }

    [Column("asuci")]
    public bool? Asuci { get; set; }

    [Column("veteran")]
    public bool? Veteran { get; set; }

    [Column("highDegree")]
    [StringLength(45)]
    public string HighDegree { get; set; }

    [Column("consentFormE11")]
    [StringLength(255)]
    public string ConsentFormE11 { get; set; }

    [Column("consentFormT10")]
    [StringLength(255)]
    public string ConsentFormT10 { get; set; }

    [Column("transcriptE11")]
    [StringLength(255)]
    public string TranscriptE11 { get; set; }

    [Column("transcriptT10")]
    [StringLength(255)]
    public string TranscriptT10 { get; set; }

    [Column("cvE11")]
    [StringLength(100)]
    public string CvE11 { get; set; }

    [Column("cvT10")]
    [StringLength(100)]
    public string CvT10 { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Studentdetails")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
