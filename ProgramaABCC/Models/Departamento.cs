using System;
using System.Collections.Generic;

namespace ProgramaABCC.Models;

public partial class Departamento
{
    public int Id { get; set; }

    public decimal NumeroDepartamento { get; set; }

    public string NombreDepartamento { get; set; } = null!;
}
