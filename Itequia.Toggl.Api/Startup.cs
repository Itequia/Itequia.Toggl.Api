﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Itequia.Toggl.Api.Data;
using Microsoft.EntityFrameworkCore;
using Itequia.Toggl.Api.Services.Interfaces;
using Itequia.Toggl.Api.Services;

namespace Itequia.Toggl.Api
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
            services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                    options.UseOpenIddict();
                });

            services.AddScoped<IProjectsService, ProjectsService>();
            services.AddScoped<IRecordsService, RecordsService>();

            services.AddMvc();

            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();

            services.AddAuthentication()
                    .AddOAuthValidation();

            services.AddOpenIddict(options =>
            {
                options.AddEntityFrameworkCoreStores<ApplicationDbContext>();
                options.AddMvcBinders();
                options.EnableTokenEndpoint("/connect/token");
                options.AllowPasswordFlow();
                options.DisableHttpsRequirement();
            });
            //TO CONTINUE
            //https://github.com/openiddict/openiddict-core
            //https://github.com/openiddict/openiddict-samples/blob/dev/samples/CodeFlow/AuthorizationServer/Startup.cs
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
