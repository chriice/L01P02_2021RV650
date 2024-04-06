using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021RV650.Models;

public partial class Departamento
{
    [Key]
    public int Id { get; set; }

    [Display (Name ="nombre del departamento")]

    public string? Departamento1 { get; set; }
}
