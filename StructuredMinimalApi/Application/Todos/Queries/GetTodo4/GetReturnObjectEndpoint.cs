using MinimalApi.Endpoint;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodo4
{
    public class GetReturnObjectEndpoint : IEndpoint<IResult>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo/4", () => HandleAsync())
                .Produces<Message>(StatusCodes.Status200OK);
        }

        public Task<IResult> HandleAsync()
        {
            var result = Results.Json(new Message { Text = "Hello World! 4" });
            return Task.FromResult(result);
        }
    }
}
