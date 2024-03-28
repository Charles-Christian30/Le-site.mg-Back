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
    public class GetAllShoppingHandler : IRequestHandler<GetAllShoppingQuery, List<CategoryModelDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeSiteRepository _repository;

        public GetAllShoppingHandler(IMapper mapper, ILeSiteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<CategoryModelDto>> Handle(GetAllShoppingQuery request, CancellationToken cancellationToken)
        {
            var response = _repository.GetAllShoppingCategories().Result;
            var responseDto = _mapper.Map<List<CategoryModelDto>>(response);
            return await Task.FromResult(responseDto);
        }
    }
}
