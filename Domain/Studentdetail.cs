using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Domain;

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
    public sbyte? UsCitizen { get; set; }

    [Column("tranStu")]
    public bool? TranStu { get; set; }

    [Column("lowIncome")]
    public sbyte? LowIncome { get; set; }

    [Column("pbk")]
    public sbyte? Pbk { get; set; }

    [Column("chc")]
    public sbyte? Chc { get; set; }

    [Column("urop")]
    public sbyte? Urop { get; set; }

    [Column("ushp")]
    public sbyte? Ushp { get; set; }

    [Column("honorProg")]
    public sbyte? HonorProg { get; set; }

    [Column("sage")]
    public sbyte? Sage { get; set; }

    [Column("paa")]
    public sbyte? Paa { get; set; }

    [Column("larc")]
    public sbyte? Larc { get; set; }

    [Column("asuci")]
    public sbyte? Asuci { get; set; }

    [Column("veteran")]
    public sbyte? Veteran { get; set; }

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
