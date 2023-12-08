using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("DocumentId", "AdvisingPrepId", "AdvisingStudentbasicStudentId")]
[Table("documents")]
[Index("DocumentId", Name = "documentID_UNIQUE", IsUnique = true)]
[Index("AdvisingPrepId", "AdvisingStudentbasicStudentId", Name = "fk_documents_advising1")]
public partial class Document
{
    [Key]
    [Column("documentID")]
    [StringLength(36)]
    public string DocumentId { get; set; }

    [Required]
    [Column("consentForm", TypeName = "mediumtext")]
    public string ConsentForm { get; set; }

    [Required]
    [Column("transcript", TypeName = "mediumtext")]
    public string Transcript { get; set; }

    [Required]
    [Column("cv", TypeName = "mediumtext")]
    public string Cv { get; set; }

    [Key]
    [Column("advising_prepID")]
    [StringLength(36)]
    public string AdvisingPrepId { get; set; }

    [Key]
    [Column("advising_studentbasic_studentID")]
    [StringLength(36)]
    public string AdvisingStudentbasicStudentId { get; set; }

    [ForeignKey("AdvisingPrepId, AdvisingStudentbasicStudentId")]
    [InverseProperty("Documents")]
    public virtual Advising Advising { get; set; }
}
