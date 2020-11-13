using Examen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Application.UseCases
{

    public interface IProcesoServices
    {
        IEnumerable<Proceso> GetAll();
    }
}
