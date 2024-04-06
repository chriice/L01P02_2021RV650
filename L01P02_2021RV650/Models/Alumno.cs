using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021RV650.Models;

public partial class Alumno

{
    [Key]
    [Display(Name = "Id alumno")]
    public int Id { get; set; }

    [Display(Name = "codigo alumno")]
    public string? Codigo { get; set; }
    [Display(Name = "nombre alumno")]
    public string? Nombre { get; set; }
    [Display(Name = "apellido alumno")]
    public string? Apellidos { get; set; }
    [Display(Name = "dui alumno")]
    public int? Dui { get; set; }
    [Display(Name = "estado alumno")]
    public int? Estado { get; set; }
}
