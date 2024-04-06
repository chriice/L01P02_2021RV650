using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021RV650.Models;

public partial class Materia
{
    [Key]
    public int Id { get; set; }
    [Display (Name = "nombre materia")]
    public string? Materia1 { get; set; }
    [Display(Name = "unidades valorativa de la materia")]
    public int? UnidadesValorativas { get; set; }
    [Display(Name = "estado de la materia")]
    public string? Estado { get; set; }
}
