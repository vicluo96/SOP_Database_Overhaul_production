using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("RecomId", "StudentbasicStudentId")]
[Table("recommenders")]
[Index("StudentbasicStudentId", Name = "fk_recommenders_studentbasic1")]
[Index("RecomId", Name = "recomID_UNIQUE", IsUnique = true)]
public partial class Recommender
{
    [Key]
    [Column("recomID")]
    [StringLength(36)]
    public string RecomId { get; set; }

    [Column("recommender")]
    [StringLength(100)]
    public string Recommender1 { get; set; }

    [Column("cycle")]
    [StringLength(3)]
    public string Cycle { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Recommenders")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
