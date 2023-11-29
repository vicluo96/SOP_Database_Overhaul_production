using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("MajorId", "StudentbasicStudentId")]
[Table("majors")]
[Index("StudentbasicStudentId", Name = "fk_majors_studentbasic1")]
[Index("MajorId", Name = "majorID_UNIQUE", IsUnique = true)]
public partial class Major
{
    [Key]
    [Column("majorID")]
    [StringLength(36)]
    public string MajorId { get; set; }

    [Required]
    [Column("majorName")]
    [StringLength(100)]
    public string MajorName { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Majors")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
