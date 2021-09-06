using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data.Context;
using Data.Repository;
using Manager.Interfaces;
using Manager.Implementation;
using FluentValidation.AspNetCore;
using Manager.Validator;
using System.Globalization;

namespace Dominio
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
            services.AddScoped<IColabRepository, ColabRepository>();
            services.AddScoped<IColabManager, ColabManager>();
            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
            services.AddScoped<IDepartamentoManager, DepartamentoManager>();
            services.AddScoped<IGrupoRepository, GrupoRepository>();
            services.AddScoped<IGrupoManager, GrupoManager>();
            services.AddDbContext<ColabDBContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DataContext")));
            services.AddControllers()
                .AddFluentValidation(p => 
                { 
                    p.RegisterValidatorsFromAssemblyContaining<ColabValidator>();
                    p.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ColabAPI", Version = "v1" });
            });
        }   




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ColabAPI v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
