using Microsoft.EntityFrameworkCore;
using RYTUserManagementService.Core.ServiceImplementations;
using RYTUserManagementService.Core.ServiceInterfaces;
using RYTUserManagementService.Domain;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Domain.RepoInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<UserManagementDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Path"));
});
    
builder.Services.AddScoped<ISchoolServices, SchoolServices>();
builder.Services.AddScoped<IStudentServices, StudentServices>();
builder.Services.AddScoped<ITeacherServices, TeacherServices>();


builder.Services.AddTransient< IUnitOfWork, UnitOfWork > ();

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
