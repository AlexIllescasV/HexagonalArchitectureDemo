using HexaArchDemo.Domain.IRepository;
using HexaArchDemo.Domain.Models;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports;


namespace HexaArchDemo.Application.Repository
{
    public class PersonaRepository: IPersonaRepository
    {
        private readonly IPersonaPort _personaRepository;

        public PersonaRepository(IPersonaPort personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public async Task<List<DepartamentoModel>> GetPersonaDepartamentoPar()
        {
            var result = await _personaRepository.GetAllDepartamentosAsync();
            List<DepartamentoModel> resultData = result.Where(x => x.Id % 2 == 0).Select(x => new DepartamentoModel
            {
                Id = x.Id,
                Nombre = x.Nombre,
                ApellidoPersona = x.ApellidoPersona,
                NombrePersona = x.NombrePersona,
                IdJefe = x.IdJefe,
            }).ToList();
            return resultData;
        }
    }
}
