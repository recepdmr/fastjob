using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Abstraction.Extensions
{
    public static class ConfigurationExtensions
    {
        public static TOptions GetAndConfigure<TOptions>(this IServiceCollection services, IConfiguration configuration) where TOptions : class
        {
            var options = configuration.GetSection(typeof(TOptions).Name);
            services.Configure<TOptions>(options);

            return options.Get<TOptions>();
        }
    }
}
