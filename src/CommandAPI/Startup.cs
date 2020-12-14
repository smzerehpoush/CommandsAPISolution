using CommandAPI.Context;
using CommandAPI.Services;
using CommandAPI.Services.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CommandAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CommandContext>(opt =>
                opt.UseNpgsql(Configuration.GetConnectionString("PostgreSQLConnection")));
            services.AddControllers();
            //AddTransient: A service is created each time it is requested from the Service Container
            //AddScoped: A service is created once per client request (connection)
            //AddSingleton: A service is created once and reused
            services.AddScoped<ICommandService, CommandServiceImpl>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}