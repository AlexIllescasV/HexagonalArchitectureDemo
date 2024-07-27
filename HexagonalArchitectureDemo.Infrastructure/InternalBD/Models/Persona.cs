using System;
using System.Collections.Generic;

namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public virtual ICollection<DepartamentoPersona> DepartamentoPersonas { get; set; } = new List<DepartamentoPersona>();

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
