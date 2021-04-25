using Infrastructure.DataAccess;
using Infrastructure.DataAccess.MongoDB;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class Extensions
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IRepository<>), typeof(MongoDbRepositoryBase<>));
            services.AddMediatR(typeof(Extensions));
        }
    }
}
