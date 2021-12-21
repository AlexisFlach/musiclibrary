using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Repositories;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddDbContext<ApiDbContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("Default"), new MySqlServerVersion(new Version(8, 0, 27))));
// Add services to the container.
builder.Services.AddScoped<IArtistsRepository, ArtistRepository>();
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

app.Run();