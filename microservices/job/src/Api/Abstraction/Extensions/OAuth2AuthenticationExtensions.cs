using Api.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Api.Abstraction.Extensions
{
    public static class OAuth2AuthenticationExtensions
    {
        public static void AddOAuth2JwtBearerAuthentication(this IServiceCollection services, IdentityServerOptions identityServerOptions)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.Authority = identityServerOptions.Host.ToString();
                    options.Audience = identityServerOptions.ResourceName;

                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = ctx => Task.CompletedTask,
                        OnAuthenticationFailed = ctx =>
                        {
                            Console.WriteLine("Exception:{0}", ctx.Exception.Message);
                            return Task.CompletedTask;
                        }
                    };
                });
        }
    }
}
