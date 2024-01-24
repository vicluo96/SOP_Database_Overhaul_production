using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("DocumentId", "StudentbasicStudentId")]
[Table("documents")]
[Index("StudentbasicStudentId", Name = "fk_documents_studentbasic1")]
public partial class Document
{
    [Key]
    [Column("documentID")]
    [StringLength(36)]
    public string DocumentId { get; set; }

    [Column("transcript", TypeName = "mediumtext")]
    public string Transcript { get; set; }

    [Column("cv", TypeName = "mediumtext")]
    public string Cv { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("Documents")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
