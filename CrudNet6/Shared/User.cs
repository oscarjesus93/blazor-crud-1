
namespace CrudNet6.Shared
{
    public class User
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }
    }
}
