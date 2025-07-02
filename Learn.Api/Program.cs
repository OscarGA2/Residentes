using Learn.Api.Endpoints;
using Learn.Api.Repository.EFCore;
using Learn.Api.IoC;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddLearnServices();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



app.UseHttpsRedirection();
app.MapUserEndpoints();
app.UseRouting();
app.InitializeLearnApiDb();
app.Run();


