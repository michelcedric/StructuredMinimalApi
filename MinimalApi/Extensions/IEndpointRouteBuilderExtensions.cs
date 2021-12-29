using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace MinimalApi.Extensions
{
    public static class IEndpointRouteBuilderExtensions
    {
        public static void MapEndpoints(this IEndpointRouteBuilder builder)
        {
            var endpoints = builder.ServiceProvider.GetServices<IEndpoint>();

            foreach (var endpoint in endpoints)
            {
                endpoint.AddRoute(builder);
            }
        }
    }
}
