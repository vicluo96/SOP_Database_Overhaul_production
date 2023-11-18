using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain;

[Table("advising")]
[Index("PrepId", Name = "prepID_UNIQUE", IsUnique = true)]
public partial class Advising
{
    [Key]
    [Column("prepID")]
    [StringLength(45)]
    public string PrepId { get; set; }

    [Required]
    [Column("prepStatus")]
    [StringLength(10)]
    public string PrepStatus { get; set; }

    [Required]
    [Column("orienT10")]
    [StringLength(10)]
    public string OrienT10 { get; set; }

    [Required]
    [Column("orienE11")]
    [StringLength(10)]
    public string OrienE11 { get; set; }

    [Column("paAppNo")]
    public int? PaAppNo { get; set; }

    //[InverseProperty("AdvisingPrep")]
    public virtual ICollection<Studentbasic> Studentbasics { get; set; } = new List<Studentbasic>();
}