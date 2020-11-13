using AutoMapper;
using Examen.Domain.Models;
using Examen.Infrastructure.Repositories;
using System.Collections.Generic;

namespace Examen.Application.UseCases
{
    public class ApplicacionServices : IApplicationServices
    {

        private readonly IMapper _mapper;
        private readonly IDataRepository _dataRepository;

        public ApplicacionServices(IMapper mapper, IDataRepository dataRepository)
        {
            _mapper = mapper;
            _dataRepository = dataRepository;
        }

        IEnumerable<Tarea> IApplicationServices.GetAll()
        {
            return _mapper.Map<IEnumerable<Tarea>>(_dataRepository.GetTareasPendientes());
        }
    }
}
