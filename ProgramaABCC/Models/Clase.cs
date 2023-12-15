using System;
using System.Collections.Generic;

namespace ProgramaABCC.Models;

public partial class Clase
{
    public int Id { get; set; }

    public decimal NumeroClase { get; set; }

    public string NombreClase { get; set; } = null!;

    public decimal NumeroDepartamento { get; set; }
}
