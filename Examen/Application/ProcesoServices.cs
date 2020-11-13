using AutoMapper;
using Examen.Domain.Models;
using Examen.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Application.UseCases
{
    public class ProcesoServices : IProcesoServices
    {

        private readonly IMapper _mapper;
        private readonly IDataRepository _dataRepository;

        public ProcesoServices(IMapper mapper, IDataRepository dataRepository)
        {
            _mapper = mapper;
            _dataRepository = dataRepository;
        }

        IEnumerable<Proceso> IProcesoServices.GetAll()
        {
            return _mapper.Map<IEnumerable<Proceso>>(_dataRepository.GetAll());
        }
    }
}
