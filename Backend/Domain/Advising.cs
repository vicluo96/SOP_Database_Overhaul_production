using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("PrepId", "StudentbasicStudentId")]
[Table("advisings")]
[Index("StudentbasicStudentId", Name = "fk_advising_studentbasic1")]
[Index("PrepId", Name = "prepID_UNIQUE", IsUnique = true)]
public partial class Advising
{
    [Key]
    [Column("prepID")]
    [StringLength(36)]
    public string PrepId { get; set; }

    [Column("prepStatus")]
    [StringLength(45)]
    public string PrepStatus { get; set; }

    [Column("orientStatus")]
    [StringLength(45)]
    public string OrientStatus { get; set; }

    [Column("adviserName")]
    [StringLength(45)]
    public string AdviserName { get; set; }

    [Column("CEWCName")]
    [StringLength(45)]
    public string Cewcname { get; set; }

    [Column("paAppNo")]
    public byte? PaAppNo { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [Column("consentForm", TypeName = "mediumtext")]
    public string ConsentForm { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Advisings")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
