using System;
using System.Collections.Generic;

namespace ProgramaABCC.Models;

public partial class Articulo
{
    public decimal Sku { get; set; }

    public string Articulo1 { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public decimal Departamento { get; set; }

    public decimal Clase { get; set; }

    public decimal Familia { get; set; }

    public DateTime FechaAlta { get; set; }

    public decimal Stock { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Descontinuado { get; set; }

    public DateTime FechaBaja { get; set; }
}
