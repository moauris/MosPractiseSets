using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MosPracWebApp.Models;
using System.Diagnostics;

namespace MosPracWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration configuration { get; set; }
        public Startup(IConfiguration config)
        {
            configuration = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(opts =>
            {
                
                opts.UseSqlServer(
                    configuration["ConnectionStrings:QuestionConnection"]);
            });
            services.AddScoped<IQuestionRepository, EFQuestionRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            app.UseDeveloperExceptionPage();

            app.UseStatusCodePages();
            app.UseStaticFiles();


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.InitQuestionData();
        }
    }
}
