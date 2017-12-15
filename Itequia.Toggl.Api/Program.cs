using System;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Itequia.Toggl.Api.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;

namespace Itequia.Toggl.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IWebHost host = BuildWebHost(args);
            SeedUsers(host);
            host.Run();
        }

        private static void SeedUsers(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    if (!userManager.Users.Any())
                    {
                        userManager.CreateAsync(new ApplicationUser() { UserName = "adria.alvarez@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "adrian.cano@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "alejandro.delamo@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "blai.samitier@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "daniel.coll@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "david.canut@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "gaston.zitelli@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "jose.vioque@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "lucica.ibanescu@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "mcarme.capdevila@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "mario.mir@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "marlon.castillo@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "marta.garcia@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "miquel.marin@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "miquel.molla@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "omar.ghadban@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "oriol.quinquilla@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "pau.morato@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "pere.berge@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "ricard.cepero@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "sergi.forns@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "sergi.perucho@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "sergio.andres@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "susana.castela@itequia.com" }, "Itequia2018!");
                        userManager.CreateAsync(new ApplicationUser() { UserName = "teresa.sujar@itequia.com" }, "Itequia2018!");
                    }
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating users");
                }
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
