using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021RV650.Models;

public partial class Facultade
{
    [Key]
    
    public int Id { get; set; }
    [Display(Name = "nombre facultad")]
    public string? Facultad { get; set; }
}
