using System;
using System.Collections.Generic;

namespace ProgramaABCC.Models;

public partial class Familia
{
    public int Id { get; set; }

    public decimal NumeroFamilia { get; set; }

    public string NombreFamilia { get; set; } = null!;

    public decimal NumeroClase { get; set; }

    public string? NombreClase { get; set; }
}
