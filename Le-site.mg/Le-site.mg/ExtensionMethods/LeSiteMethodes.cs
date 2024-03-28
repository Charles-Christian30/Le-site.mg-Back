using Domaine.Context;
using Mediateur.Query;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

namespace Le_site.mg.ExtensionMethods
{
    public static class LeSiteMethodes
    {

        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddScoped<ILeSiteRepository, LeSiteRepository>();
            services.AddScoped<ILeSiteService, LeSiteService>();

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies([typeof(Program).Assembly,
                    typeof(GetAccueilHandler).Assembly,
                ]);
            });
            return services;
        }
    }
}

