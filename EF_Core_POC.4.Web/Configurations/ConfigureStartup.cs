using EF_Core_POC._2.Infra.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Nullnes.EF_Core_POC.Application;
using Nullnes.EF_Core_POC.Application.Service;
using Nullnes.EF_Core_POC.Application.Service.Interfaces;

namespace Nullnes.EF_Core_POC.Application.Configurations
{
    public static class ConfigureStartup
    {
        public static IServiceCollection ConfigureContextDatabase(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<RunAwayFromSerasaContext>();
            return serviceCollection;
        }

        public static IServiceCollection ConfigureSingletons(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return serviceCollection;
        }

        public static IServiceCollection ConfigureScoped(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAccountAppService, AccountAppService>();
            serviceCollection.AddScoped<ITransactionAppService, TransactionAppService>();

            return serviceCollection;
        }

        public static IServiceCollection ConfigureTransient(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}