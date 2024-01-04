using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[Table("studentbasic")]
[Index("StudentId", Name = "studentID_UNIQUE", IsUnique = true)]
public partial class Studentbasic
{
    [Key]
    [Column("studentID")]
    [StringLength(36)]
    public string StudentId { get; set; }

    [Required]
    [Column("legalFirstName")]
    [StringLength(100)]
    public string LegalFirstName { get; set; }

    [Required]
    [Column("legalLastName")]
    [StringLength(100)]
    public string LegalLastName { get; set; }

    [Column("preferredFirstName")]
    [StringLength(100)]
    public string PreferredFirstName { get; set; }

    [Column("pronouns")]
    [StringLength(50)]
    public string Pronouns { get; set; }

    [Required]
    [Column("email")]
    [StringLength(100)]
    public string Email { get; set; }

    [Column("personalEmail")]
    [StringLength(100)]
    public string PersonalEmail { get; set; }

    [Required]
    [Column("phoneNumber")]
    [StringLength(21)]
    public string PhoneNumber { get; set; }

    [Column("uciGPA")]
    [Precision(3, 2)]
    public decimal? UciGpa { get; set; }

    [Column("age")]
    public byte? Age { get; set; }

    [Column("submitTime", TypeName = "datetime")]
    public DateTime SubmitTime { get; set; }

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Advising> Advisings { get; set; } = new List<Advising>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<College> Colleges { get; set; } = new List<College>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Major> Majors { get; set; } = new List<Major>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Minor> Minors { get; set; } = new List<Minor>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<QuestionResponse> QuestionResponses { get; set; } = new List<QuestionResponse>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Recommender> Recommenders { get; set; } = new List<Recommender>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Studentdetail> Studentdetails { get; set; } = new List<Studentdetail>();

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("StudentbasicStudents")]
    public virtual ICollection<Scholarship> ScholarshipsSchols { get; set; } = new List<Scholarship>();
}
