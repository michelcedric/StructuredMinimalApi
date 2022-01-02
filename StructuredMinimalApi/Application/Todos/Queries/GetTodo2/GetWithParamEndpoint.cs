using MinimalApi.Endpoint;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodo2
{
    public class GetWithParamEndpoint : IEndpoint<string, string>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo/2/{param1}", (string param1) => HandleAsync(param1));
        }

        public Task<string> HandleAsync(string request)
        {
            return Task.FromResult($"Hello World! 2 {request}");
        }
    }
}
