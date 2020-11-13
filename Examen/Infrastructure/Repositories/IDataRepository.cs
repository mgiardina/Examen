using Examen.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Repositories
{
    public interface IDataRepository
    {
        IEnumerable<Proceso> GetAll();
    }
}
