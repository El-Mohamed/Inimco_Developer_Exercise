using DeveloperExercise.Api.IOC;
using DeveloperExercise.Application.IOC;
using DeveloperExercise.Domain.IOC;
using DeveloperExercise.Infrastructure.IOC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiLayerServices(builder.Configuration);
builder.Services.AddDomainLayerServices(builder.Configuration);
builder.Services.AddApplicationLayerServices(builder.Configuration);
builder.Services.AddInfrastructureLayerServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("AllowAll");

app.Run();
