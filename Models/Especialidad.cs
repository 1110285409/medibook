using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MediBook.Models
{
    internal class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreEspecialidad { get; set; } = string.Empty;

        // Propiedades de navegación
        public virtual ICollection<Doctor> Doctores { get; set; } = new List<Doctor>();
    }
}
