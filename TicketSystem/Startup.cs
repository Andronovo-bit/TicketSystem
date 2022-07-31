using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TicketSystem.Data.Context;
using TicketSystem.Data.Repository;
using TicketSystem.Data.UnitOfWork;
using TicketSystem.Manager;
using TicketSystem.Models;
using TicketSystem.Services;

namespace TicketSystem
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
            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services
                .AddSpaStaticFiles(configuration =>
                {
                    configuration.RootPath = "ClientApp/build";
                });

            services
                .AddSwaggerGen(c =>
                {
                    c
                        .SwaggerDoc("v1",
                        new OpenApiInfo { Title = "My API", Version = "v1" });
                });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();;
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<ITicketManager, TicketManager>();
            
            services
                .AddSingleton(Configuration
                    .GetSection("AppSettings")
                    .Get<AppSettingsViewModel>());
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services
                .AddDbContext<TicketSystemDataContext>(options =>
                {
                    options
                        .UseSqlServer(Configuration
                            .GetConnectionString("TicketSystemConnection"),
                        b =>
                        {
                            b.MigrationsAssembly("TicketSystem");
                            b
                                .MigrationsHistoryTable(HistoryRepository
                                    .DefaultTableName,
                                "dbo");
                            b
                                .UseQuerySplittingBehavior(QuerySplittingBehavior
                                    .SplitQuery);
                        });
                });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();

            app
                .UseEndpoints(endpoints =>
                {
                    endpoints
                        .MapControllerRoute(name: "default",
                        pattern: "{controller}/{action=Index}/{id?}");
                });

            app.UseSwagger();

            app
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TicketAPI");
                });

            app
                .UseSpa(spa =>
                {
                    spa.Options.SourcePath = "ClientApp";

                    if (env.IsDevelopment())
                    {
                        spa.UseReactDevelopmentServer(npmScript: "start");
                    }
                });
        }
    }
}
