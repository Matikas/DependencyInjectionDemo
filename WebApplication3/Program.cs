using Microsoft.EntityFrameworkCore;
using WebApplication3.DataAccess;
using WebApplication3.ShoppingListDataAccess;
using WebApplication3.TimeService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShoppingListDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddScoped<IWeatherRepository, WeatherRepository>();
builder.Services.AddTransient<IDateTimeService, DateTimeService>();
builder.Services.AddScoped<IShoppingListRepository, ShoppingListDbRepository>();

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
