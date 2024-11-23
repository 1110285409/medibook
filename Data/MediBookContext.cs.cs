using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediBook.Models;

namespace MediBook.Data
{
    public class MediBookContext : DBContext
    {
        public MediBookContext(DbContextOptions<MediBookContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Horario> Horarios { get; set; }
    }
}
