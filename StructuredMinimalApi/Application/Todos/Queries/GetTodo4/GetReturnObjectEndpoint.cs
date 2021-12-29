using MinimalApi;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodo4
{
    public class GetReturnObjectEndpoint : IEndpoint<IResult>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo/4", () => Handle())
                .Produces<Message>(StatusCodes.Status200OK);
        }

        public Task<IResult> Handle()
        {
            var result = Results.Json(new Message { Text = "Hello World! 4" });
            return Task.FromResult(result);
        }
    }
}
