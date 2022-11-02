using API.Context;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

/// Exemplo de API do Rider
// var builder = MyAPI.CreateBuilder(args);
// var app = builder.Build();
// app.MapGet("/", () => "Hello World!");
// app.Run();

// https://stackoverflow.com/questions/68564532/connecting-to-sql-database-in-docker-instance-from-c-sharp-fails

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
//options => options.UseMySql(builder.Configuration.GetConnectionString("ConexaoMySQL"), ServerVersion.Parse("5.7.40"))
// https://medium.com/@RobertKhou/asp-net-core-mvc-identity-using-postgresql-database-bc52255f67c4
builder.Services.AddDbContext<AgendaContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoPostGre")));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI
// At https://aka.ms/aspnetcore/swashbuckle
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
