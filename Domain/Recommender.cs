using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("RecomId", "StudentbasicStudentId")]
[Table("recommenders")]
[Index("StudentbasicStudentId", Name = "fk_recommenders_studentbasic1")]
public partial class Recommender
{
    [Key]
    [Column("recomID")]
    [StringLength(36)]
    public string RecomId { get; set; }

    [Required]
    [Column("recommender")]
    [StringLength(100)]
    public string RecommenderName { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Recommenders")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
