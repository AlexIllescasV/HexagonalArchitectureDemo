using HexaArchDemo.Domain.Models;
using HexaArchDemo.Domain.UseCase;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;
using HexaArchDemo.Infrastructure.Drivers.Models;
using HexaArchDemo.Infrastructure.Drivers.Ports;

namespace HexaArchDemo.Infrastructure.Drivers.Adapters
{
    public class PersonaDriverAdapter : IPersonaDriverPort
    {
        private readonly TestContext _context;

        public PersonaDriverAdapter(TestContext context)
        {
            _context = context;
        }
        public List<DepartamentoDriverModel> GetPersonaDepartamentoPar()
        {
            PersonaUseCase personaUseCase = new PersonaUseCase(_context);
            List<DepartamentoModel> resultUseCase = personaUseCase.GetPersonaDepartamentoPar();
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
