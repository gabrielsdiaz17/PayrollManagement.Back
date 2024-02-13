

using Microsoft.EntityFrameworkCore;
using PayrollManagement.Back.Api;
using PayrollManagement.Back.Infraestructure;
using PayrollManagement.Back.Infraestructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCustomaizedDataStore(configuration);
builder.Services.AddCustomizedRepository();
builder.Services.AddCustomizedServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var dbContext = services.GetRequiredService<AppDbContext>();

        // Apply any pending migrations
        dbContext.Database.Migrate();
    }

}
app.UseCustomizedCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
