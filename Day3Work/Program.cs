using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Day3Work.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Day3WorkContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Day3WorkContext") ?? throw new InvalidOperationException("Connection string 'Day3WorkContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
