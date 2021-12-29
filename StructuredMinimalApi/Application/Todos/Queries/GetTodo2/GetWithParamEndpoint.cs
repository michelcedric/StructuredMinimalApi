using MinimalApi;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodo2
{
    public class GetWithParamEndpoint : IEndpoint<string, string>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo/2/{param1}", (string param1) => Handle(param1));       
        }

        public Task<string> Handle(string request)
        {
            return Task.FromResult($"Hello World! 2 {request}");
        }
    }
}
