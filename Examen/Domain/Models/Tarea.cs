using System;
using System.Collections.Generic;

namespace Examen.Domain.Models
{
    public class Tarea
    {

        public int TaskId { get; set; }
        public int ProcId { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }
        public int UserId { get; set; }
        public string TaskState { get; set; }
        public string TaskObs { get; set; }

        public Proceso Proceso { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<Parametro> Parametros { get; set; }
    }
}
