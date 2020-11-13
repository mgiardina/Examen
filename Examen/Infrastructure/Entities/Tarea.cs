using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Infrastructure.Entities
{
    public class Tarea
    {
        [Key]
        public int TaskId { get; set; }
        public int ProcId { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }
        public int UserId { get; set; }
        public int TaskState { get; set; }
        public string TaskObs { get; set; }



        [ForeignKey(nameof(ProcId))]
        public Proceso Proceso { get; set; }

        [ForeignKey(nameof(UserId))]
        public Usuario Usuario { get; set; }

        public ICollection<Parametro> Parametros { get; set; }
    }
}
