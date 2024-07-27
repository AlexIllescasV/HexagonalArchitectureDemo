using HexaArchDemo.Domain.Models;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Models;
using HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports;


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
        public IEnumerable<DepartamentoModel> GetAllDepartamentosAsync()
        {
            IEnumerable<DepartamentoModel> list = (from d in _context.Personas
                                                   join e in _context.Departamentos
                                                   on d.Id equals e.IdJefe
                                                   group new { d, e } by new
                                                   {
                                                       nombrePersona=d.Nombre,
                                                       apellidoPersona=d.Apellido,
                                                       idPersona=d.Id,
                                                       nombreDepartamento=e.Nombre,
                                                       idDepartamento=e.Id
                                                   }
                                                   into de
                                                   //from depar in de.DefaultIfEmpty()
                                                   select new DepartamentoModel
                                                   {
                                                       ApellidoPersona = de.Key.apellidoPersona,
                                                       Id =de.Key.idDepartamento,
                                                       IdJefe=de.Key.idPersona,
                                                       Nombre=de.Key.nombreDepartamento,
                                                       NombrePersona=de.Key.nombrePersona,
                                                   }).ToList();

            // Envuelve la lista en un Task usando Task.FromResult
            return list;
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
