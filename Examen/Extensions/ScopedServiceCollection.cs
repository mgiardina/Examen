using Examen.Application.UseCases;
using Examen.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Examen.Extensions
{
    public static class ScopedServiceCollection
    {
        public static IServiceCollection AddCoreScopedServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationServices, ApplicacionServices>();
            services.AddScoped<IDataRepository, DataRepository>();

            return services;
        }
    }
}
