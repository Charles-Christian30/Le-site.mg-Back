using Domaine.Data;
using Domaine.Dto;
using Mediateur.Query;
using MediatR;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LeSiteService : ILeSiteService
    {
        private readonly ILeSiteRepository _repository;
        private readonly IMediator _mediator;
        public LeSiteService(ILeSiteRepository repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }
        public async Task<List<AccueilModelDto>> GetAccueilInformations()
        {
            try
            {
                var response = await _mediator.Send(new GetAccueilQuery() { accueilModelDto =  new AccueilModelDto() });
                return response ;

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CategoryModelDto>> GetAllBienEtre()
        {
            try
            {
                var response = await _mediator.Send(new GetAllBienEtreQuery() { categoryModelDto = new CategoryModelDto() });
                return response;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public  async Task<List<CategoryModelDto>> GetAllFormations()
        {
            try
            {
                var response = await _mediator.Send(new GetAllFormationsQuery() { categoryModelDto = new CategoryModelDto() });
                return response;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CategoryModelDto>> GetAllHotelRestaurantEspace()
        {
            try
            {
                var response = await _mediator.Send(new GetAllHotelRestaurantEspaceQuery() { categoryModelDto = new CategoryModelDto() });
                return response;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CategoryModelDto>> GetAllShopping()
        {
            try
            {
                var response = await _mediator.Send(new GetAllShoppingQuery() { categoryModelDto = new CategoryModelDto() });
                return response;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
