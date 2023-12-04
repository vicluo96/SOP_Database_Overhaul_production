using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("PrepId", "StudentbasicStudentId")]
[Table("advising")]
[Index("StudentbasicStudentId", Name = "fk_advising_studentbasic1")]
[Index("PrepId", Name = "prepID_UNIQUE", IsUnique = true)]
public partial class Advising
{
    [Key]
    [Column("prepID")]
    [StringLength(36)]
    public string PrepId { get; set; }

    [Column("prepStatus")]
    [StringLength(10)]
    public string PrepStatus { get; set; }

    [Column("orienT10")]
    [StringLength(10)]
    public string OrienT10 { get; set; }

    [Column("orienE11")]
    [StringLength(10)]
    public string OrienE11 { get; set; }

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

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Advisings")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
