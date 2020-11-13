using System;

namespace Examen.Domain.Models
{
    public class Proceso
    {
        public int ProcId { get; set; }

        public string ProcName { get; set; }

        public string ProcStart { get; set; }

        public string ProcEnd { get; set; }

        public int ProcState { get; set; }

        public string ProcObs { get; set; }
    }
}
