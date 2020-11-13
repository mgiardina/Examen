using System.Collections.Generic;

namespace Examen.Domain.Models
{
    public class Proceso
    {
        public int ProcId { get; set; }
        public string ProcName { get; set; }
        public string ProcStart { get; set; }
        public string ProcEnd { get; set; }
        public string ProcState { get; set; }
        public string ProcObs { get; set; }

        public ICollection<Tarea> Tareas { get; set; }
        public ICollection<Parametro> Parametros { get; set; }
    }
}
