using Microsoft.EntityFrameworkCore;
using SalesService.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SalesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();
