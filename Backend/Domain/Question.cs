using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[Table("questions")]
[Index("QuestionId", Name = "questionID_UNIQUE", IsUnique = true)]
public partial class Question
{
    [Key]
    [Column("questionID")]
    public int QuestionId { get; set; }

    [Column("questionText")]
    [StringLength(1500)]
    public string QuestionText { get; set; }

    [Column("t10ORe11")]
    [StringLength(20)]
    public string T10Ore11 { get; set; }

    [InverseProperty("QuestionsQuestion")]
    public virtual ICollection<QuestionResponse> QuestionResponses { get; set; } = new List<QuestionResponse>();

    [ForeignKey("QuestionsQuestionId")]
    [InverseProperty("QuestionsQuestions")]
    public virtual ICollection<Scholarship> ScholarshipsSchols { get; set; } = new List<Scholarship>();
}
