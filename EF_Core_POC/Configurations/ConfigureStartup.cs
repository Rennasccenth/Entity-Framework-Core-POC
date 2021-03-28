using EF_Core_POC.AppService;
using EF_Core_POC.AppService.Interfaces;
using EF_Core_POC.Data;
using EF_Core_POC.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EF_Core_POC.Configurations
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