using CongestionTaxCalculator.Application.Persistence.Contracts;
using CongestionTaxCalculator.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CongestionTaxCalculator.Persistence;

public static class PersistenceServicesRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CongestionTaxDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("TaxCongestionConnectionString"));
        });

        services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));

        services.AddScoped<IRuleRepository,RuleRepository>();
        return services;
    }
}
