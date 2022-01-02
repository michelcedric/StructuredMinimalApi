using MinimalApi.Endpoint;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodos
{
    public class GetAllEndpoint : IEndpoint<string>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo", () => HandleAsync());
        }

        public Task<string> HandleAsync()
        {
            return Task.FromResult("Hello World!");
        }
    }
}
