using AutoMapper;

namespace CapacFeria.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Examen.Domain.Models.Proceso, Examen.Infrastructure.Entities.Proceso>();
            CreateMap<Examen.Infrastructure.Entities.Proceso, Examen.Domain.Models.Proceso>();

        }
    }
}
