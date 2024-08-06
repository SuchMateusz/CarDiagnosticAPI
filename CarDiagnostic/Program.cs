using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors( options =>
options.AddPolicy(name: "MyAllowSpecificOrigins",
builder => { builder.WithOrigins("https://localhost:7035/"); 
}));

builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "CarDiagnostic",
        Version = "v1",
        Description = "Description",
        TermsOfService = new Uri("http://example.com/terms")
    }); 

    var filePath = Path.Combine(AppContext.BaseDirectory, "CarDiagnostic.xml");
    c.IncludeXmlComments(filePath); });

builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHealthChecks("/hc");

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();