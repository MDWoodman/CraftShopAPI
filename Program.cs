var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<FluentValidation.IValidator<CraftShopAPI.Domain.Entities.Lamp>, CraftShopAPI.Domain.Validators.LampValidator>();
builder.Services.AddScoped<FluentValidation.IValidator<CraftShopAPI.Domain.Entities.Chair>, CraftShopAPI.Domain.Validators.ChairValidator>();
builder.Services.AddScoped<FluentValidation.IValidator<CraftShopAPI.Domain.Entities.CrystalDecor>, CraftShopAPI.Domain.Validators.CrystalDecorValidator>();

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
