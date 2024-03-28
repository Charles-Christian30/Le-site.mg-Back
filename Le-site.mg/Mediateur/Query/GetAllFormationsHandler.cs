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
    public class GetAllFormationsHandler : IRequestHandler<GetAllFormationsQuery, List<CategoryModelDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeSiteRepository _repository;

        public GetAllFormationsHandler(IMapper mapper, ILeSiteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<List<CategoryModelDto>> Handle(GetAllFormationsQuery request, CancellationToken cancellationToken)
        {
            var response= _repository.GetAllFormationsCategories().Result;
            var responseDto = _mapper.Map<List<CategoryModelDto>>(response);
            return await Task.FromResult(responseDto);
        }
    }
}
