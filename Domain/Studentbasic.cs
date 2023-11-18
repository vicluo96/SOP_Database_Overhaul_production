using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Domain;

[PrimaryKey("StudentId", "StudentdetailDetailId", "AdvisingPrepId")]
[Table("studentbasic")]
[Index("PersonalEmail", Name = "EmailAddress", IsUnique = true)]
// [Index("AdvisingPrepId", Name = "fk_studentbasic_advising1")]
// [Index("StudentdetailDetailId", Name = "fk_studentbasic_studentdetail1")]
public partial class Studentbasic
{
    [Key]
    [Column("studentID")]
    [StringLength(50)]
    public string StudentId { get; set; }

    [Column("legalFirstName")]
    [StringLength(100)]
    public string LegalFirstName { get; set; }

    [Column("legalLastName")]
    [StringLength(100)]
    public string LegalLastName { get; set; }

    [Column("preferredFirstName")]
    [StringLength(100)]
    public string PreferredFirstName { get; set; }

    [Column("pronouns")]
    [StringLength(50)]
    public string Pronouns { get; set; }

    [Column("email")]
    [StringLength(100)]
    public string Email { get; set; }

    [StringLength(100)]
    public string PersonalEmail { get; set; }

    [Column("phoneNumber")]
    [StringLength(14)]
    public string PhoneNumber { get; set; }

    [Column("uciGPA")]
    [Precision(3, 2)]
    public decimal? UciGpa { get; set; }

    [Key]
    [Column("studentdetail_detailId")]
    [StringLength(50)]
    public string StudentdetailDetailId { get; set; }

    [Key]
    [Column("advising_prepID")]
    [StringLength(45)]
    public string AdvisingPrepId { get; set; }

    [ForeignKey("AdvisingPrepId")]
    [InverseProperty("Studentbasics")]
    // public virtual Advising AdvisingPrep { get; set; }

    // [ForeignKey("StudentdetailDetailId")]
    // [InverseProperty("Studentbasics")]
    public virtual Studentdetail StudentdetailDetail { get; set; }
}
