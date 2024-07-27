using System;
using System.Collections.Generic;

namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;

public partial class DepartamentoPersona
{
    public int Id { get; set; }

    public int IdPersona { get; set; }

    public int IdDepartamento { get; set; }

    public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;

    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
