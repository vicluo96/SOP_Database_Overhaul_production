using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[Table("studentdetail")]
[Index("DetailId", Name = "detailId_UNIQUE", IsUnique = true)]
[Index("StudentId", Name = "studentID_UNIQUE", IsUnique = true)]
public partial class Studentdetail
{
    [Key]
    [Column("detailId")]
    [StringLength(50)]
    public string DetailId { get; set; }

    [Required]
    [Column("studentID")]
    [StringLength(45)]
    public string StudentId { get; set; }

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

    [Column("consentForm")]
    [StringLength(45)]
    public string ConsentForm { get; set; }

    [Column("transcript")]
    [StringLength(100)]
    public string Transcript { get; set; }

    [Column("cv")]
    [StringLength(100)]
    public string Cv { get; set; }

    [InverseProperty("StudentdetailDetail")]
    public virtual ICollection<Studentbasic> Studentbasics { get; set; } = new List<Studentbasic>();
}
