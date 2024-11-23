using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediBook.Models
{
    internal class Doctor
    {
        [Key]
        public int IdDoctor { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        public int IdEspecialidad { get; set; }

        [Required]
        [Phone]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Propiedades de navegación
        [ForeignKey("IdEspecialidad")]
        public virtual Especialidad? Especialidad { get; set; }
        public virtual ICollection<Cita> Citas { get; set; } = new List<Cita>();
        public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();
    }
}
