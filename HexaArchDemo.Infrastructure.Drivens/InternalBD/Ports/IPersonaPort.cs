
using HexaArchDemo.Domain.Models;

namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports
{
    public interface IPersonaPort : IEntityPort<PersonaModel>
    {
        IEnumerable<DepartamentoModel> GetAllDepartamentosAsync();

    }
}
