using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MediBook.Models
{
    internal class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(10)]
        public string Genero { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Telefono { get; set; } = string.Empty;

        [StringLength(200)]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Propiedades de navegación
        public virtual ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
