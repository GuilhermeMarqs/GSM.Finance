using GSM.Finance.Dal.Context;
using GSM.Finance.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GSM.Finance.Dal.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            // Data
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IMovimentoRepository, IMovimentoRepository>();
            // Business
            //services.AddScoped<IFornecedorService, FornecedorService>();

            return services;
        }
    }
}
