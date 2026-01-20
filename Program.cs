using AutoMapper;
using CraftShopAPI.Application.Prototypes;
using CraftShopAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<CraftShopAPI.Infrastructure.CraftShopDbContext>();
builder.Services.AddScoped<CraftShopAPI.Infrastructure.Repositories.IWriteLampRepositories, CraftShopAPI.Infrastructure.Repositories.WriteLampRepository>();
builder.Services.AddScoped<CraftShopAPI.Application.Factories.IProductFactory, CraftShopAPI.Application.Factories.ProductFactory>();
builder.Services.AddScoped<FluentValidation.IValidator<CraftShopAPI.Domain.Entities.Lamp>, CraftShopAPI.Domain.Validators.LampValidator>();
builder.Services.AddScoped<FluentValidation.IValidator<CraftShopAPI.Domain.Entities.Chair>, CraftShopAPI.Domain.Validators.ChairValidator>();
builder.Services.AddScoped<FluentValidation.IValidator<CraftShopAPI.Domain.Entities.CrystalDecor>, CraftShopAPI.Domain.Validators.CrystalDecorValidator>();
builder.Services.AddScoped<CraftShopAPI.Application.Services.Interface.IWriteLampService, CraftShopAPI.Application.Services.WriteLampService>();
builder.Services.AddScoped<CraftShopAPI.Application.Services.Interface.IReadLampService, CraftShopAPI.Application.Services.ReadLampService>();
builder.Services.AddScoped<IReadLampRepositories, ReadLampRepositories>();
builder.Services.AddScoped<ILampPrototypeService, LampPrototypeService>();
builder.Services.AddAutoMapper(typeof(CraftShopAPI.Application.Mappers.LampMappingProfile));
//builder.Services.AddScoped<CraftShopAPI.Infrastructure.Repositories.IWriteChair, CraftShopAPI.Infrastructure.Repositories.WriteChair>();
//builder.Services.AddScoped<CraftShopAPI.Infrastructure.Repositories.IWriteCrystalDecor, CraftShopAPI.Infrastructure.Repositories.WriteCrystalDecor>();

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
