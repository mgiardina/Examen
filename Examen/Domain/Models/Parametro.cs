using System;

namespace Examen.Domain.Models
{
    public class Parametro
    {
        public int ParaId { get; set; }
        public string ParaName { get; set; }
        public string ParaValue { get; set; }
        public DateTime ParaWhen { get; set; }
        public int TaskId { get; set; }

        public Tarea Tarea { get; set; }

    }
}
