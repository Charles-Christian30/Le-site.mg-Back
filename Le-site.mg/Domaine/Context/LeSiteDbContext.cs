using Domaine.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Context
{
    public class LeSiteDbContext : DbContext
    {
        public LeSiteDbContext(DbContextOptions<LeSiteDbContext> options): base(options)
        {
        }

        public DbSet<AccueilModel> Accueil { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
    }
}
