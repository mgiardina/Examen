using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
