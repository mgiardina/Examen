using Examen.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExamenDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<ExamenDBContext>>()))
            {

                context.Procesos.AddRange(
                    new Proceso
                    {
                        ProcId = 1,
                        ProcName = "Proceso 1",
                        ProcStart = DateTime.Now,
                        ProcEnd = DateTime.Now.AddDays(7),
                        ProcState = 0,
                        ProcObs = String.Empty
                    },
                     new Proceso
                     {
                         ProcId = 2,
                         ProcName = "Proceso 2",
                         ProcStart = DateTime.Now,
                         ProcEnd = DateTime.Now.AddDays(7),
                         ProcState = 1,
                         ProcObs = String.Empty
                     },
                     new Proceso
                     {
                         ProcId = 3,
                         ProcName = "Proceso 3",
                         ProcStart = DateTime.Now,
                         ProcEnd = DateTime.Now.AddDays(7),
                         ProcState = 1,
                         ProcObs = String.Empty
                     },
                     new Proceso
                     {
                         ProcId = 4,
                         ProcName = "Proceso 4",
                         ProcStart = DateTime.Now,
                         ProcEnd = DateTime.Now.AddDays(7),
                         ProcState = 1,
                         ProcObs = String.Empty
                     },
                     new Proceso
                     {
                         ProcId = 5,
                         ProcName = "Proceso 5",
                         ProcStart = DateTime.Now,
                         ProcEnd = DateTime.Now.AddDays(7),
                         ProcState = 1,
                         ProcObs = String.Empty
                     }
                    );

                context.Tareas.AddRange(
                       new Tarea
                       {
                           TaskId = 1,
                           ProcId = 1,
                           UserId = 1,
                           TaskName = "Tarea 1",
                           TaskState = 0,
                       },
                        new Tarea
                        {
                            TaskId = 2,
                            ProcId = 1,
                            UserId = 1,
                            TaskName = "Tarea 2",
                            TaskState = 1,
                        },
                        new Tarea
                        {
                            TaskId = 3,
                            ProcId = 1,
                            UserId = 1,
                            TaskName = "Tarea 3",
                            TaskState = 2,
                        },
                          new Tarea
                          {
                              TaskId = 4,
                              ProcId = 1,
                              UserId = 1,
                              TaskName = "Tarea 4",
                              TaskState = 3,
                          }
                       );

                context.Usuarios.AddRange(
                       new Usuario
                       {
                           UserId = 1,
                           UserName = "Mariano Giardina"
                       },
                        new Usuario
                        {
                            UserId = 2,
                            UserName = "Juan Perez"
                        },
                        new Usuario
                        {
                            UserId = 3,
                            UserName = "Pedro Gonzalez"
                        }
                       );

                context.Parametros.AddRange(
                       new Parametro
                       {
                           ParaId = 1,
                           TaskId = 1,
                           ParaName = "Parametro 1",
                           ParaValue = "Valor 1"
                       },
                        new Parametro
                        {
                            ParaId = 2,
                            TaskId = 1,
                            ParaName = "Parametro 2",
                            ParaValue = "Valor 2"
                        },
                        new Parametro
                        {
                            ParaId = 3,
                            TaskId = 1,
                            ParaName = "Parametro 3",
                            ParaValue = "Valor 3"
                        }
                       );

                context.SaveChanges();
            }
        }
    }
}
