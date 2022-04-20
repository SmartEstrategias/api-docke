using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using src.newDockeNet.Configurations;

var builder = WebApplication.CreateBuilder(args);

//Controllers
builder.Services.AddControllers();
builder.Services.AddFluentValidationConfig();

//AutoMapper
builder.Services.AddAutoMapperConfiguration();

//DB
builder.Services.AddDatabaseConfiguration(builder.Configuration);

//Scoped
builder.Services.AddDependencyInjectionConfiguration();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Docke API", Version = "v1" });
});

builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAnyOrigin", builder =>
        {
            // Allow "Access-Control-Allow-Origin: *" header
            builder.AllowAnyOrigin();
        });
    });

var app = builder.Build();

app.UseCors("AllowAnyOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
