using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediBook.Models
{
    internal class Horario
    {
        [Key]
        public int IdHorario { get; set; }

        [Required]
        public int IdDoctor { get; set; }

        [Required]
        [StringLength(10)]
        public string DiaSemana { get; set; } = string.Empty;

        [Required]
        public TimeSpan HoraInicio { get; set; }

        [Required]
        public TimeSpan HoraFin { get; set; }

        // Propiedades de navegación
        [ForeignKey("IdDoctor")]
        public virtual Doctor? Doctor { get; set; }
    }
}
