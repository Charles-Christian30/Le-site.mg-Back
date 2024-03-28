using Domaine.Context;
using Domaine.Data;
using Microsoft.EntityFrameworkCore;
using Repository.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LeSiteRepository : ILeSiteRepository
    {
        private readonly LeSiteDbContext _context;
        public LeSiteRepository(LeSiteDbContext context)
        {
            _context = context;
        }
        public async Task<List<AccueilModel>> GetAccueilInformations()
        {
            return  await _context.Accueil.ToListAsync();
        }

        public async Task<List<CategoryModel>> GetAllBienEtreCategories()
        {
            return await _context.Categories.Where(x => x.CategoryName.ToUpper().Trim() == CategorieConstante.BIENETRE.ToUpper().Trim()).ToListAsync();
        }

        public async Task<List<CategoryModel>> GetAllFormationsCategories()
        {
            return await _context.Categories.Where(x => x.CategoryName.ToUpper().Trim() == CategorieConstante.FORMATIONS.ToUpper().Trim()).ToListAsync();
        }

        public async Task<List<CategoryModel>> GetAllHotelRestaurantEspaceCategories()
        {
            return await _context.Categories.Where(x => x.CategoryName.ToUpper().Trim() == CategorieConstante.HOTELRESTAURANTESPACE.ToUpper().Trim()).ToListAsync();
        }

        public async Task<List<CategoryModel>> GetAllShoppingCategories()
        {
            return await _context.Categories.Where(x => x.CategoryName.ToUpper().Trim() == CategorieConstante.SHOPPING.ToUpper().Trim()).ToListAsync();
        }
    }
}
