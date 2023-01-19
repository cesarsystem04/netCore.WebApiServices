using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using WebApiServices.Context;

namespace WebApiServices.Infraestructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IUoWKernelContext), typeof(UoWKernelContext));
        }
    }
}
