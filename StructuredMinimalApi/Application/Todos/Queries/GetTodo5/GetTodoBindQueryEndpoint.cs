﻿using MinimalApi.Endpoint;

namespace StructuredMinimalApi.Application.Todos.Queries.GetTodo5
{
    public class GetTodoBindQueryEndpoint : IEndpoint<string, PagingData>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            //app.MapGet("/todo/5", (PagingData pagingData) => Handle(pagingData));

            app.MapGet("/todo/5", (int page, int pageSize) => HandleAsync(new PagingData(page, pageSize)));


            //app.MapGet("/todo/5", (int page, int pageSize, PagingData pagingData) => Handle(pagingData));
        }

        public Task<string> HandleAsync(PagingData pagingData)
        {
            return Task.FromResult($"Hello World! 5 page {pagingData.CurrentPage} : size {pagingData.PageSize}");
        }
    }
}
