using HexaArchDemo.Domain.Models;


namespace HexaArchDemo.Application.Repository
{
    public interface IPersonaRepository
    {
        public List<DepartamentoModel> GetPersonaDepartamentoPar();
    }
}
