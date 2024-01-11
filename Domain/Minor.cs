using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("MinorId", "StudentbasicStudentId")]
[Table("minors")]
[Index("StudentbasicStudentId", Name = "fk_minors_studentbasic1")]
public partial class Minor
{
    [Key]
    [Column("minorID")]
    [StringLength(36)]
    public string MinorId { get; set; }

    [Column("minorName")]
    [StringLength(100)]
    public string MinorName { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Minors")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
