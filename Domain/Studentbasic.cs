using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Domain;

[Table("studentbasic")]
public partial class Studentbasic
{
    [Key]
    [Column("studentID")]
    [StringLength(36)]
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

    [Column("personalEmail")]
    [StringLength(100)]
    public string PersonalEmail { get; set; }

    [Column("phoneNumber")]
    [StringLength(14)]
    public string PhoneNumber { get; set; }

    [Column("uciGPA")]
    [Precision(3, 2)]
    public decimal? UciGpa { get; set; }

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Advising> Advisings { get; set; } = new List<Advising>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<College> Colleges { get; set; } = new List<College>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Major> Majors { get; set; } = new List<Major>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Minor> Minors { get; set; } = new List<Minor>();

    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<QuestionResponse> QuestionResponses { get; set; } = new List<QuestionResponse>();


    [InverseProperty("StudentbasicStudent")]
    public virtual ICollection<Studentdetail> Studentdetails { get; set; } = new List<Studentdetail>();

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("StudentbasicStudents")]

}
