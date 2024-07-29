using HexaArchDemo.Application.Repository;
using HexaArchDemo.Domain.IRepository;
using HexaArchDemo.Domain.Models;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;
using HexaArchDemo.Infrastructure.Drivers.Models;
using HexaArchDemo.Infrastructure.Drivers.Ports;

namespace HexaArchDemo.Infrastructure.Drivers.Adapters
{
    public class PersonaDriverAdapter : IPersonaDriverPort
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaDriverAdapter(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public async Task<List<DepartamentoDriverModel>> GetPersonaDepartamentoPar()
        {
            var resultUseCase = await _personaRepository.GetPersonaDepartamentoPar();
            List<DepartamentoDriverModel> result = new List<DepartamentoDriverModel>();
            foreach (DepartamentoModel p in resultUseCase)
            {
                DepartamentoDriverModel de = new DepartamentoDriverModel(p.Nombre, p.NombrePersona);
                result.Add(de);
            }

            return result;
        }
    }
}
