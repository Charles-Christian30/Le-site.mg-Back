using AutoMapper;
using Domaine.Dto;
using MediatR;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateur.Query
{
    public class GetAccueilHandler : IRequestHandler<GetAccueilQuery, List<AccueilModelDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeSiteRepository _repository;

        public GetAccueilHandler(ILeSiteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<AccueilModelDto>> Handle(GetAccueilQuery request, CancellationToken cancellationToken)
        {
            var response = _repository.GetAccueilInformations().Result;
            var responseDto = _mapper.Map<List<AccueilModelDto>>(response);
            return await Task.FromResult(responseDto);
        }
    }
}
