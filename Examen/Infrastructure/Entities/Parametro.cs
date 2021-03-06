﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        [ForeignKey(nameof(TaskId))]
        public Tarea Tarea { get; set; }

    }
}
