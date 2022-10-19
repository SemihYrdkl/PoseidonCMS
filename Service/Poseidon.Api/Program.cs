using Poseidon.Application.Services.Concrete;
using Poseidon.Domain.Repositories;
using Poseidon.Domain.Services.Interface;
using Poseidon.Infrastructure.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IProfileService, ProfileService>();
//builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(RepositoryBase<>));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
