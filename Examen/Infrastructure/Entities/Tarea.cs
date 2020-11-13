using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Entities
{
    public class Tarea
    {
        [Key]
        public int TaskId { get; set; }
        public int TaskProcId { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }
        public int TaskUserId { get; set; }
        public string TaskState { get; set; }
        public string TaskObs { get; set; }
    }
}
