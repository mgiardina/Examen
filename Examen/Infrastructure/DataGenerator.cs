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
                // Look for any board games.
                if (context.Procesos.Any())
                {
                    return;   // Data was already seeded
                }

                context.Procesos.AddRange(
                    new Proceso
                    {
                        ProcId = 1,
                        ProcName = "Candy Land"
                        //PublishingCompany = "Hasbro",
                        //MinPlayers = 2,
                        //MaxPlayers = 4
                    });

                context.SaveChanges();
            }
        }
    }
}
