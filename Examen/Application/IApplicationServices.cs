using Examen.Domain.Models;
using System.Collections.Generic;

namespace Examen.Application.UseCases
{

    public interface IApplicationServices
    {
        IEnumerable<Tarea> GetAll();
    }
}
