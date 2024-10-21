using System.ComponentModel.DataAnnotations;

namespace Evaluacion1.Models
{
    public class Pasajero
    {
        [Required, MaxLength(15)]
        public required string Nombre { get; set; }

        [Required, MaxLength(15)]
        public required string Apellido { get; set; }

        [Required, Range(100000, 999999999)]
        public required int Identificacion { get; set; }

        [Required]
        public required string PaisOrigen { get; set; }

        [Required, RegularExpression(@"[A-Z]{3}\d{3}")]
        public required string CodigoReserva { get; set; }
    }

}
