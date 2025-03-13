using ImproveAbilityInSqlAndC_.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImproveAbilityInSqlAndC_.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AdoNetContext>(provider =>
            {
                var connectioString = configuration.GetConnectionString("DefaultConnection") ?? "";
                return new AdoNetContext(connectioString);
            });

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
