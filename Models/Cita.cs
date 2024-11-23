using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediBook.Models
{
    internal class Cita
    {
        [Key]
        public int IdCita { get; set; }

        [Required]
        public int IdPaciente { get; set; }

        [Required]
        public int IdDoctor { get; set; }

        [Required]
        public DateTime FechaHoraCita { get; set; }

        [Required]
        [StringLength(500)]
        public string MotivoConsulta { get; set; } = string.Empty;

        // Propiedades de navegación
        [ForeignKey("IdPaciente")]
        public virtual Paciente? Paciente { get; set; }

        [ForeignKey("IdDoctor")]
        public virtual Doctor? Doctor { get; set; }
    }
}
