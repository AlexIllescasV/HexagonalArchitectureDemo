using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports;
using HexagonalArchitectureDemo.Domain.Models;


namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Adapters
{
    public class PersonaAdapter : IPersonaPort
    {
        private readonly TestContext _context;
        public PersonaAdapter(TestContext context)
        {
            _context = context;
        }

        public Task AddAsync(PersonaModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PersonaModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        /**
         * Consulta inclusiva un left join
         * 
         */
        public async Task<IEnumerable<DepartamentoPersonaModel>> GetAllDepartamentosAsync()
        {
            var list = (from d in _context.Personas
                        join e in _context.Departamentos
                        on d.Id equals e.IdJefe into emp
                        from persona in emp.DefaultIfEmpty()
                        select new DepartamentoPersonaModel
                        {
                            ApellidoPersona = d.Apellido,
                            NombreDepartamento = persona.Nombre,
                            NombrePersona = d.Nombre,
                            IdDepartamento = persona.Id,
                            Id = d.Id,
                            IdPersona = d.Id
                        }).ToList();

            // Envuelve la lista en un Task usando Task.FromResult
            return await Task.FromResult(list);
        }

        public Task<PersonaModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PersonaModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
