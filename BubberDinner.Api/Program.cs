using BubberDinner.Application;
using BubberDinner.Application.Authentication;
using BubberDinner.Infrastructure;
using BuberDinner.Api.Filters;
using BuberDinner.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(opts => opts.Filters.Add<ErrorHandlingFilterAttribute>());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication().AddInfrastructure(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ErrorHandling>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
