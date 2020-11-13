using Examen.Infrastructure.Entities;
using System;
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

        public IEnumerable<Proceso> GetAll()
        {
            var procesos = _context.Procesos.ToList();
            return procesos;
        }
    }
}
