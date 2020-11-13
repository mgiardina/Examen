using Examen.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenDBContext : DbContext
    {
        public ExamenDBContext(DbContextOptions<ExamenDBContext> options)
            : base(options) { }

        public DbSet<Proceso> Procesos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
    }
}
