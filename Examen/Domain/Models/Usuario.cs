using System.Collections.Generic;

namespace Examen.Domain.Models
{
    public class Usuario
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool UserState { get; set; }

        public ICollection<Tarea> Tareas { get; set; }

    }
}
