
using HexaArchDemo.Domain.Models;

namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports
{
    public interface IPersonaPort : IEntityPort<PersonaModel>
    {
        Task<IEnumerable<DepartamentoModel>> GetAllDepartamentosAsync();

    }
}
