using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Examen.Infrastructure.Entities
{
    public class Proceso
    {
        [Key]
        public int ProcId { get; set; }
        public string ProcName { get; set; }
        public DateTime ProcStart { get; set; }
        public DateTime ProcEnd { get; set; }
        public int ProcState { get; set; }
        public string ProcObs { get; set; }

        public ICollection<Tarea> Tareas { get; set; }
        public ICollection<Parametro> Parametros { get; set; }
    }
}
