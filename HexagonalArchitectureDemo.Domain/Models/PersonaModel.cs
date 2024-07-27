namespace HexaArchDemo.Domain.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public PersonaModel() { }

        public PersonaModel(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
