using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[Table("scholarships")]
[Index("ScholId", Name = "e11ID_UNIQUE", IsUnique = true)]
public partial class Scholarship
{
    [Key]
    [Column("scholID")]
    public int ScholId { get; set; }

    [Required]
    [Column("scholName")]
    [StringLength(255)]
    public string ScholName { get; set; }

    [ForeignKey("ScholarshipsScholId")]
    [InverseProperty("ScholarshipsSchols")]
    public virtual ICollection<Question> QuestionsQuestions { get; set; } = new List<Question>();

    [ForeignKey("ScholarshipsScholId")]
    [InverseProperty("ScholarshipsSchols")]
    public virtual ICollection<Studentbasic> StudentbasicStudents { get; set; } = new List<Studentbasic>();
}
