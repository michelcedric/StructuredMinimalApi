using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MinimalApi;
using StructuredMinimalApi.Configurations;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodo3
{
    public class GetWithQueryEndpoint : IEndpoint<string, HttpRequest,int>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly SampleOptions _options;

        public GetWithQueryEndpoint(IHttpContextAccessor httpContextAccessor,IOptions<SampleOptions> options)
        {
            _httpContextAccessor = httpContextAccessor;
            _options = options.Value;
        }

        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo/3", (HttpRequest request, int page) => Handle(request, page));
        }

        public Task<string> Handle(HttpRequest request,int page)
        {

            //int.TryParse(request.Query["page"], out var page);

            int.TryParse(_httpContextAccessor.HttpContext.Request.Query["page"], out var page2);

            return Task.FromResult($"Hello World! 3 page {page} or {page2} and value from options {_options.SampleProperty}");
        }
    }
}
