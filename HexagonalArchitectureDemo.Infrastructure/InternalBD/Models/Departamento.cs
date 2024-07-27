using System;
using System.Collections.Generic;

namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdJefe { get; set; }

    public virtual ICollection<DepartamentoPersona> DepartamentoPersonas { get; set; } = new List<DepartamentoPersona>();

    public virtual Persona IdJefeNavigation { get; set; } = null!;
}
