using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Entities
{
    public class Parametro
    {
        [Key]
        public int ParaId { get; set; }

        public string ParaName { get; set; }

        public string ParaValue { get; set; }

        public DateTime ParaWhen { get; set; }

        public int TaskId { get; set; }
    
    }
}
