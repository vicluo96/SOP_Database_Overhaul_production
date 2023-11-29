using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[PrimaryKey("QuestionsQuestionId", "StudentbasicStudentId")]
[Table("questionResponse")]
[Index("StudentbasicStudentId", Name = "fk_questionResponse_studentbasic1")]
public partial class QuestionResponse
{
    [Key]
    [Column("questions_questionID")]
    public int QuestionsQuestionId { get; set; }

    [Key]
    [Column("studentbasic_studentID")]
    [StringLength(36)]
    public string StudentbasicStudentId { get; set; }

    [Column("responseText", TypeName = "mediumtext")]
    public string ResponseText { get; set; }

    [ForeignKey("QuestionsQuestionId")]
    [InverseProperty("QuestionResponses")]
    public virtual Question QuestionsQuestion { get; set; }

    [ForeignKey("StudentbasicStudentId")]
    [InverseProperty("QuestionResponses")]
    public virtual Studentbasic StudentbasicStudent { get; set; }
}
