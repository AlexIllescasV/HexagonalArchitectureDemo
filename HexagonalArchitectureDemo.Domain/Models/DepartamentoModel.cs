
namespace HexaArchDemo.Domain.Models
{
    public class DepartamentoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdJefe { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidoPersona { get; set; }


        public DepartamentoModel() { }

        public DepartamentoModel(int id, string nombre, int idJefe, string nombrePersona, string apellidoPersona)
        {
            Id = id;
            Nombre = nombre;
            IdJefe = idJefe;
            NombrePersona = nombrePersona;
            ApellidoPersona = apellidoPersona;
        }
    }
}
