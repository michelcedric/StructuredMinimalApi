using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MinimalApi.Endpoint.SwaggerGen.Extensions
{
    public static class SwaggerGenOptionsExtensions
    {
        public static void CustomEndpointOperationIds(this SwaggerGenOptions swaggerGenOptions)
        {
            swaggerGenOptions.CustomOperationIds(apiDesc =>
            {
                apiDesc.ActionDescriptor.RouteValues.TryGetValue("Controller", out var value);
                if (value == null)
                    throw new InvalidOperationException("The action descriptor does not contains a Controller value : Please valid if your endpoint implement IEndpoint");
                return value.Replace("Endpoint", "");
            });
        }
    }
}
