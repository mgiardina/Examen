using Examen.Infrastructure.Entities;
using System.Collections.Generic;

namespace Examen.Infrastructure.Repositories
{
    public interface IDataRepository
    {
        IEnumerable<Tarea> GetTareasPendientes();

    }
}
