using Domaine.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateur.Query
{
    public class GetAllFormationsQuery : IRequest<List<CategoryModelDto>>
    {
        public CategoryModelDto categoryModelDto { get; set; }
    }
}
