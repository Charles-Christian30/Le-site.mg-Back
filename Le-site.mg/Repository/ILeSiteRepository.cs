using Domaine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ILeSiteRepository
    {
        Task<List<AccueilModel>> GetAccueilInformations();
        Task<List<CategoryModel>> GetAllFormationsCategories();
        Task<List<CategoryModel>> GetAllBienEtreCategories();
        Task<List<CategoryModel>> GetAllHotelRestaurantEspaceCategories();
        Task<List<CategoryModel>> GetAllShoppingCategories();
    }
}
