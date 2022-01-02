# StructuredMinimalApi
The goal of this project it's to define one endpoint (minimal API .net 6) by one file (class)
## Program.cs
Use [AddEndpoints](https://github.com/michelcedric/StructuredMinimalApi/blob/master/MinimalApi.Endpoint/Extensions/IServiceCollectionExtensions.cs#L7) extenion method to create each endpoint.

And also [MapEndpoint](https://github.com/michelcedric/StructuredMinimalApi/blob/master/MinimalApi.Endpoint/Extensions/IEndpointRouteBuilderExtensions.cs#L8) extension method to use new routing APIs

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpoints();

var app = builder.Build();

app.MapEndpoints();

app.Run();
```

## Define an endpoint
To create and define one endpoint, it need to implement [IEndpoint](https://github.com/michelcedric/StructuredMinimalApi/blob/master/MinimalApi.Endpoint/IEndpoint.cs) interface

```csharp
public class GetWithParamEndpoint : IEndpoint<string, string>
    {
        public void AddRoute(IEndpointRouteBuilder app)
        {
            app.MapGet("/Todo/2/{param1}", (string param1) => HandleAsync(param1));
        }

        public Task<string> HandleAsync(string request)
        {
            return Task.FromResult($"Hello World! 2 {request}");
        }
    }
```

## Nuget Package
A nuget package it's available [here](https://www.nuget.org/packages/MinimalApi.Endpoint/). 