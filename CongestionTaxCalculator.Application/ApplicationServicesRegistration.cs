using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CongestionTaxCalculator.Application;

public static class ApplicationServicesRegistration
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
