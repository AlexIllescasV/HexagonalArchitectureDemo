using HexaArchDemo.Application.Repository;
using HexaArchDemo.Domain.Models;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Adapters;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;

namespace HexaArchDemo.Domain.UseCase
{
    public class PersonaUseCase : IPersonaRepository
    {
        private readonly TestContext _context;
        private readonly IPersonaRepository _personaRepository;
        
        public PersonaUseCase(TestContext context) {
            _context = context;
        }
        public List<DepartamentoModel> GetPersonaDepartamentoPar()
        {
            PersonaAdapter adapterPersona = new PersonaAdapter(_context);

            IEnumerable<DepartamentoModel> result = adapterPersona.GetAllDepartamentosAsync();
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
