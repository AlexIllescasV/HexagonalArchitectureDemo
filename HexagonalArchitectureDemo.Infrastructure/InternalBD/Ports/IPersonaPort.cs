using HexagonalArchitectureDemo.Domain.Models;


namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports
{
    public interface IPersonaPort : IEntityPort<PersonaModel>
    {
        Task<IEnumerable<DepartamentoPersonaModel>> GetAllDepartamentosAsync();

    }
}
