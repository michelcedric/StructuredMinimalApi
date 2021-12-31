using MinimalApi.Endpoint;
using StructuredMinimalApi.Application.Todos.Queries.GetTodo4;

namespace StructuredMinimalApi.Application.Todos.Commands.CreateTodo
{
    /// <summary>
    /// Endpoint to create a todo
    /// </summary>
    public class CreateTodoEndpoint : IEndpoint<IResult, CreateTodoCommand>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPost("/Todo", (CreateTodoCommand command) => Handle(command))
                .Produces<Message>(StatusCodes.Status201Created);
        }

        public Task<IResult> Handle(CreateTodoCommand command)
        {
            var message = new Message
            {
                Text = command.Text,
                Id = Guid.NewGuid()
            };
            return Task.FromResult(Results.Created($"/todo/{message.Id}", message));
        }
    }
}
