using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallet.Core.Interfaces;
using Wallet.Core.Repository;
using Wallet.Core.Services;
using Wallet.Data;
using Wallet.Utilties;
using AutoMapper;
using Wallet.Core.Interfaces;
using Wallet.Core.Repository;
using Wallet.API.Mappings;
using Wallet.API.Services;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;

namespace Wallet.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter() =>
                new ServiceCollection().AddLogging().AddMvc().AddNewtonsoftJson()
                    .Services.BuildServiceProvider()
                    .GetRequiredService<IOptions<MvcOptions>>().Value.InputFormatters
                    .OfType<NewtonsoftJsonPatchInputFormatter>().First();



            // Register the Swagger generator, defining 1 or more Swagger document
            services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("sqlconnection"));
            });


            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<IWalletServices, WalletServices>();
            services.AddTransient<IResponseFactory, ResponseFactory>();
            services.AddTransient<IHttpGenericFactory, HttpGenericFactory>();
            services.AddTransient<ITestServices, TestServices>();
            services.AddHttpClient();
            //services.Configure<UrlConfiguration>(Configuration.GetSection(UrlConfiguration.WalletApi));
            services.AddOptions<UrlConfiguration>()
                .Bind(Configuration.GetSection(UrlConfiguration.WalletApi))
                .ValidateDataAnnotations();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            services.AddControllers(config => config.InputFormatters.Insert(0, GetJsonPatchInputFormatter()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
