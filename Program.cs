using Microsoft.OpenApi.Models;
using newDockeNet.Configurations;

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
