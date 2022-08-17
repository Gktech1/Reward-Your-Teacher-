using EmailSenders.Services;
using EmailSenders.Settings;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Data;
using RYTNotificationService.API.Data.Repository.Implementation;
using RYTNotificationService.API.Data.Repository.Interfaces;
using RYTNotificationService.API.Extensions;
using RYTNotificationService.API.Helpers;
using RYTNotificationService.API.Services.Implementation;
using RYTNotificationService.API.Services.Interfaces;
using RYTNotificationService.API.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*builder.Services.AddApplicationServices(builder.Configuration);*/
builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddSignalR();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IGenericRepository<T>, GenericRepository<T>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddHttpClient<IHttpClientService, HttpClientService>();
builder.Services.AddTransient<IHttpClientService, HttpClientService>();
//builder.Services.AddAuthentication();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IGenericRepository<T>, GenericRepository<T>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddHttpClient<IHttpClientService, HttpClientService>();
builder.Services.AddTransient<IHttpClientService, HttpClientService>();
//builder.Services.AddAuthentication();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IMailService, MailService>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
        options =>
        {
            options.LoginPath = new PathString("/auth/login");
            options.AccessDeniedPath = new PathString("/auth/denied");
        });

builder.Services.AddAuthorization(x =>
{
    //if (Environment.IsDevelopment())
    {
        x.DefaultPolicy = new AuthorizationPolicyBuilder()
            .RequireAssertion(_ => true)
            .Build();
    }
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
/*app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials());*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<MessageHub>("/MessageHub", options =>
    {
        options.Transports =
            HttpTransportType.WebSockets |
            HttpTransportType.LongPolling;
    }
);


app.Run();
