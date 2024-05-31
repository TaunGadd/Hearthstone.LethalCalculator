using Hearthstone.LethalCalculator.Application;
using Hearthstone.LethalCalculator.Application.Interfaces;
using Hearthstone.LethalCalculator.Mappers;
using Hearthstone.LethalCalculator.Service;
using Hearthstone.LethalCalculator.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AddDependencies(builder.Services);

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

app.Run();

void AddDependencies(IServiceCollection services)
{
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    services.AddScoped<IEffectFactory, EffectFactory>();
    services.AddScoped<IGamestateApplication, GamestateApplication>();
    services.AddScoped<ILethalCalculatorService, LethalCalculatorService>();
}