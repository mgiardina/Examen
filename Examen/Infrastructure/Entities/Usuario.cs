﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Examen.Infrastructure.Entities
{
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool UserState { get; set; }

        public ICollection<Tarea> Tareas { get; set; }

    }
}
