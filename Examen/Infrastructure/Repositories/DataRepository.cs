using Examen.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Examen.Infrastructure.Repositories
{
    public class DataRepository :  IDataRepository
    {
        private ExamenDBContext _context;
        public DataRepository(ExamenDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Tarea> GetTareasPendientes()
        {
            var tareas = _context.Tareas.Include(proc => proc.Proceso).
                                            Include(task => task.Usuario)
                                             .Include(task => task.Parametros).ToList();

            return tareas.Where(x => x.TaskState == 0 );
        }
    }
}
