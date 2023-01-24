
using System.ComponentModel.DataAnnotations;

namespace CrudNet6.Shared
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="* Obligatorio")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "* Obligatorio")]
        public string Apellido { get; set; } = null!;

        [Required(ErrorMessage = "* Obligatorio")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "* Obligatorio")]
        public string Telefono { get; set; } = null!;

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }
    }
}
