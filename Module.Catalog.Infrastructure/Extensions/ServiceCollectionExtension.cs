using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Catalog.Core.Abstractions;
using Module.Catalog.Infrastructure.Persistence;
using Shared.Infrastructure.Extensions;

namespace Module.Catalog.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCatalogInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<CatalogDbContext>(config)
                .AddScoped<ICatalogDbContext, CatalogDbContext>();
            return services;
        }
    }
}
