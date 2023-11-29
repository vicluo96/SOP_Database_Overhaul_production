using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("ResultId", "StudentbasicStudentId")]
[Table("results")]
[Index("StudentbasicStudentId", Name = "fk_results_studentbasic1")]
[Index("ResultId", Name = "resultID_UNIQUE", IsUnique = true)]
public partial class Result
{
    [Key]
    [Column("resultID")]
    [StringLength(36)]
    public string ResultId { get; set; }

    [Column("curStatus")]
    [StringLength(36)]
    public string CurStatus { get; set; }

    [Column("sopProfile")]
    public bool? SopProfile { get; set; }

    [Column("sopSurvey")]
    public bool? SopSurvey { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Results")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
