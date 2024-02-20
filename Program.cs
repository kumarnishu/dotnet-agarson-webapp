using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PokemonApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => { });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Demo", Description = "it is documenting the demo apis" }));
builder.Services.AddDbContext<DataContext>(options=>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.UseCors("angular-app");

app.UseSwagger();
app.UseSwaggerUI();

app.Run();