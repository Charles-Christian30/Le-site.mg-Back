using Domaine.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateur.Query
{
    public class GetAccueilQuery : IRequest<List<AccueilModelDto>>
    {
        public AccueilModelDto accueilModelDto { get; set; }
    }
}
