using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using SmartMirror.WebAPI.Models;

namespace SmartMirror.WebAPI
{
    public class Startup
    {
        private string _connectionString = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _connectionString = Configuration["secretConnectionString"];

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddEntityFrameworkNpgsql().AddDbContext<ApiContext>(opt => opt.UseNpgsql(_connectionString)); 

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    app.UseHsts();
            //}

            //app.Use( async (context, next) => {
            //    await next();

            //    if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
            //    {
            //        context.Request.Path = "/index.html";
            //        await next();
            //    }
            //});

            //app.UseDefaultFiles();
            //app.UseStaticFiles();
            app.UseMvc();

        }
    }
}
