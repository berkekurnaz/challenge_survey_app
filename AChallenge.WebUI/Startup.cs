using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AChallenge.Business.Concrete;
using AChallenge.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;


namespace AChallenge.WebUI
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            IFileProvider physicalProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());

            string mongoConnectionString = this.Configuration.GetConnectionString("MongoConnectionString");
            services.AddTransient(s => new SurveyManager(new SurveyRepository(mongoConnectionString, "DbChallengeSurveyApp", "Surveys")));
            services.AddTransient(s => new CoordinatorManager(new CoordinatorRepository(mongoConnectionString, "DbChallengeSurveyApp", "Coordinators")));
            services.AddTransient(s => new RespondentManager(new RespondentRepository(mongoConnectionString, "DbChallengeSurveyApp", "Respondents")));
            services.AddTransient(s => new ResponseManager(new ResponseRepository(mongoConnectionString, "DbChallengeSurveyApp", "Responses")));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IFileProvider>(physicalProvider);
            services.AddSession();
            services.AddMvc();
            services.AddDistributedMemoryCache();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseStaticFiles();
            app.UseStatusCodePages();
        }
    }
}
