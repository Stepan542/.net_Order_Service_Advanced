using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddSwaggerGen(c =>
// {
//     c.SwaggerDoc("api", new OpenApiInfo{ Title = "Ocelot Gateway API", Version = "v1" });
// });
builder.Services.AddOcelot();
builder.Configuration.AddJsonFile("ocelot.json");

var app = builder.Build();

// app.UseSwagger();
// app.UseSwaggerUI(c => {
//     c.SwaggerEndpoint("/swagger/api/swagger.json", "Ocelot Gateway API");
// });

await app.UseOcelot();

app.Run();