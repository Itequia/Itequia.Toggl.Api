using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Itequia.Toggl.Api.Data;
using Microsoft.EntityFrameworkCore;
using Itequia.Toggl.Api.Services.Interfaces;
using Itequia.Toggl.Api.Services;
using AutoMapper;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.DTO;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;
using Itequia.Toggl.Api.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Itequia.Toggl.Api.Data.Models;
using AspNet.Security.OpenIdConnect.Primitives;

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

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IProjectsService, ProjectsService>();
            services.AddScoped<IRecordsService, RecordsService>();

            services.AddMvc();

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.ClaimsIdentity.UserNameClaimType = OpenIdConnectConstants.Claims.Name;
                options.ClaimsIdentity.UserIdClaimType = OpenIdConnectConstants.Claims.Subject;
                options.ClaimsIdentity.RoleClaimType = OpenIdConnectConstants.Claims.Role;
            });

            services.AddOpenIddict(options =>
            {
                options.AddEntityFrameworkCoreStores<ApplicationDbContext>();
                options.AddMvcBinders();
                options.EnableTokenEndpoint("/connect/token");
                options.AllowPasswordFlow();
                options.DisableHttpsRequirement();
            });

            services.AddAuthentication()
                    .AddOAuthValidation();
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

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            app.UseWelcomePage();   
        }
    }
}
