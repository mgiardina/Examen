using AutoMapper;

namespace CapacFeria.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Examen.Domain.Models.Proceso, Examen.Infrastructure.Entities.Proceso>();
            CreateMap<Examen.Infrastructure.Entities.Proceso, Examen.Domain.Models.Proceso>()
                .ForMember(p => p.ProcState, opt => opt.MapFrom(x => (Examen.Domain.Enums.States)x.ProcState));

            CreateMap<Examen.Domain.Models.Parametro, Examen.Infrastructure.Entities.Parametro>();
            CreateMap<Examen.Infrastructure.Entities.Parametro, Examen.Domain.Models.Parametro>();

            CreateMap<Examen.Domain.Models.Tarea, Examen.Infrastructure.Entities.Tarea>();
            CreateMap<Examen.Infrastructure.Entities.Tarea, Examen.Domain.Models.Tarea>()
                .ForMember(p => p.TaskState, opt => opt.MapFrom(x => (Examen.Domain.Enums.States)x.TaskState));

            CreateMap<Examen.Domain.Models.Usuario, Examen.Infrastructure.Entities.Usuario>();
            CreateMap<Examen.Infrastructure.Entities.Usuario, Examen.Domain.Models.Usuario>();

        }
    }
}
