using Domaine.Data;
using Domaine.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ILeSiteService
    {
        Task<List<AccueilModelDto>> GetAccueilInformations();

        Task<List<CategoryModelDto>> GetAllFormations();

        Task<List<CategoryModelDto>> GetAllShopping();
        Task<List<CategoryModelDto>> GetAllBienEtre();
        Task<List<CategoryModelDto>> GetAllHotelRestaurantEspace();

    }
}
