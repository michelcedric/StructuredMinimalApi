using MinimalApi.Endpoint;
using StructuredMinimalApi.Application.Todos.Queries.GetTodo4;

namespace StructuredMinimalApi.Application.Todos.Commands.CreateTodo
{
    /// <summary>
    /// Endpoint to create a todo
    /// </summary>
    public class CreateTodoEndpoint : IEndpoint<IResult, CreateTodoCommand, CancellationToken>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapPost("/Todo", (CreateTodoCommand command, CancellationToken cancellationToken)
                => HandleAsync(command, cancellationToken))
                .Produces<Message>(StatusCodes.Status201Created);
        }

        /// <summary>
        /// Endpoint to create a todo
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<IResult> HandleAsync(CreateTodoCommand command, CancellationToken cancellationToken)
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
