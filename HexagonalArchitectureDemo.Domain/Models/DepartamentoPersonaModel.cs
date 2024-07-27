
namespace HexaArchDemo.Domain.Models
{
    public class DepartamentoPersonaModel
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdDepartamento { get; set; }
        public string NombrePersona { get; set; }
        public string NombreDepartamento { get; set; }
        public string ApellidoPersona { get; set; }

        public DepartamentoPersonaModel() { }

        public DepartamentoPersonaModel(int id, int idPersona, int idDepartamento, string nombrePersona, string apellidoPersona, string nombreDepartamento)
        {
            Id = id;
            IdPersona = idPersona;
            IdDepartamento = idDepartamento;
            NombrePersona = nombrePersona;
            NombreDepartamento = nombreDepartamento;
            ApellidoPersona = apellidoPersona;
        }

    }
}
