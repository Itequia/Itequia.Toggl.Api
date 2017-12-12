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
using AutoMapper;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.DTO;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;
using Itequia.Toggl.Api.Data.Repositories;

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
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IProjectsService, ProjectsService>();
            services.AddScoped<IRecordsService, RecordsService>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            InitializeAutoMapper();
        }

        private void InitializeAutoMapper()
        {
            Mapper.Initialize(cfg => {
                                       cfg.CreateMap<Record, RecordDTO>().ReverseMap();
                                       cfg.CreateMap<Project, ProjectDTO>();
            }
                             );
        }
    }
}
