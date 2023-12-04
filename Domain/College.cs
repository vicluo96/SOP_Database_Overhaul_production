using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("CollegeId", "StudentbasicStudentId")]
[Table("colleges")]
[Index("StudentbasicStudentId", Name = "fk_colleges_studentbasic1")]
public partial class College
{
    [Key]
    [Column("collegeID")]
    [StringLength(36)]
    public string CollegeId { get; set; }

    [Column("collegeName")]
    [StringLength(100)]
    public string CollegeName { get; set; }

    [Column("gpa")]
    [Precision(3, 2)]
    public decimal? Gpa { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Colleges")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
