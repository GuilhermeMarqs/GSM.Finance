using GSM.Finance.Dal.Context;
using GSM.Finance.Dal.Repository;
using GSM.Finance.Domain.Interfaces;

namespace GSM.Finance.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            // Data
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IMovimentoRepository, MovimentoRepository>();

            // Business
            //services.AddScoped<IFornecedorService, FornecedorService>();
            

            return services;
        }
    }
}
