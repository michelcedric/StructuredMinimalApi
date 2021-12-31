using Microsoft.Extensions.PlatformAbstractions;
using MinimalApi.Endpoint.Extensions;
using MinimalApi.Endpoint.Configurations.Extensions;
using MinimalApi.Endpoint.SwaggerGen.Extensions;
using StructuredMinimalApi.Configurations;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpoints();
builder.Configuration.AddConfigurationFile();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var basePath = PlatformServices.Default.Application.ApplicationBasePath;
    var fileName = typeof(Program).GetTypeInfo().Assembly.GetName().Name;
    var xmlPath = Path.ChangeExtension(Path.Combine(basePath, fileName), "xml");

    options.IncludeXmlComments(xmlPath);
    options.SwaggerDoc("v1", new()
    {
        Title = builder.Environment.ApplicationName,
        Version = "v1"
    });

    options.CustomEndpointOperationIds();

});

builder.Services.Configure<SampleOptions>(options =>
{
    builder.Configuration.GetRequiredSection(SampleOptions.ConfigurationName).Bind(options);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json",
        $"{builder.Environment.ApplicationName} v1"));
}

app.MapEndpoints();

app.Run();

public partial class Program { }