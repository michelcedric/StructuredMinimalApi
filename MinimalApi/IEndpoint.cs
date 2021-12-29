using Microsoft.AspNetCore.Routing;

namespace MinimalApi
{

    public interface IEndpoint
    {
        void AddRoute(IEndpointRouteBuilder app);     
    }

    public interface IEndpoint<TResult> : IEndpoint
    {
        Task<TResult> Handle();
    }

    public interface IEndpoint<TResult, TRequest> : IEndpoint
    {
        Task<TResult> Handle(TRequest request);
    }

    public interface IEndpoint<TResult, TRequest1, TRequest2> : IEndpoint
    {
        Task<TResult> Handle(TRequest1 request1, TRequest2 request2);
    }
}