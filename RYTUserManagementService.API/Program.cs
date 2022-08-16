using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using RYTUserManagementService.Common.Utilities.Services;
using RYTUserManagementService.Core.ServiceImplementations;
using RYTUserManagementService.Core.ServiceInterfaces;
using RYTUserManagementService.Domain;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Models;

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
builder.Services.AddTransient<IdentityUser, IdentityUser>();
builder.Services.AddTransient<IEmailSender, MailJetEmailSender>();

builder.Services.AddIdentityCore<IdentityUser> (opt =>
{
    opt.User.RequireUniqueEmail = true;
    opt.Password.RequiredUniqueChars = 2;
    opt.Password.RequireUppercase = true;
    opt.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<UserManagementDbContext>().AddDefaultTokenProviders();

builder.Services.AddAuthentication();


builder.Services.AddTransient< IUnitOfWork, UnitOfWork > ();

//AutoMapper for the DTO's
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(Mappings));

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
