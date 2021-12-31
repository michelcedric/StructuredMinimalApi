using MinimalApi.Endpoint;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodos
{
    public class GetAllEndpoint : IEndpoint<string>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo", () => Handle());
        }

        public Task<string> Handle()
        {
            return Task.FromResult("Hello World!");
        }
    }
}
