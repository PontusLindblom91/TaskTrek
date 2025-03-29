using Microsoft.EntityFrameworkCore;
using TaskTrek.Data.Context;
using TaskTrek.Data.Repositories;
using TaskTrek.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ProjectTaskService>();
builder.Services.AddScoped<ProjectTaskRepo>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<UserRepo>();
builder.Services.AddScoped<SprintService>();
builder.Services.AddScoped<SprintRepo>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers();

app.Run();

