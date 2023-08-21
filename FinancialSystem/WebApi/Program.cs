using Domain.Interfaces.Generics;
using Domain.Interfaces.ICategory;
using Domain.Interfaces.IExpense;
using Domain.Interfaces.IFinancialSystem;
using Domain.Interfaces.IUserFinancialSystem;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BaseContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
       .AddEntityFrameworkStores<BaseContext>();

// Interface and repository
builder.Services.AddSingleton(typeof(InterfaceGeneric<>), typeof(RepositoryGeneric<>));
builder.Services.AddSingleton<InterfaceCategory, RepositoryCategory>();
builder.Services.AddSingleton<InterfaceExpense, RepositoryExpense>();
builder.Services.AddSingleton<InterfaceFinancialSystem, RepositoryFinancialSystem>();
builder.Services.AddSingleton<InterfaceUserFinancialSystem, RepositoryUserFinancialSystem>();

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
