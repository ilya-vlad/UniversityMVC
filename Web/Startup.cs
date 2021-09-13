using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using MVC.DataAccess;
using System.Globalization;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Localization;
using SmartBreadcrumbs.Extensions;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;
using SmartBreadcrumbs;

namespace MVC.Web
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
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()                
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();
            
            services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = new List<CultureInfo>
                    {
                        new CultureInfo("ru"),
                        new CultureInfo("en"),                       
                        new CultureInfo("ar")
                    };
                    options.DefaultRequestCulture = new RequestCulture("ru");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                });
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<UniversityContext>(options => options.UseSqlServer(connection));          
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICoursesRepository, CoursesRepository>();
            services.AddScoped<IGroupsRepository, GroupsRepository>();
            services.AddScoped<IStudentsRepository, StudentsRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();           

            services.AddBreadcrumbs(
            GetType().Assembly,
            options =>
            {
                options.InferFromAction = false;
                options.FallbackTitleToMethodName = false;
                options.TagName = "nav";
                options.TagClasses = "";
                options.OlClasses = "breadcrumb";
                options.LiClasses = "breadcrumb-item";
                options.ActiveLiClasses = "breadcrumb-item active";
                // Disable default node:
                options.DontLookForDefaultNode = true;
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
                app.UseStatusCodePagesWithReExecute("/Error/{0}");                
            }
           

            app.UseRequestLocalization();


            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseRequestLocalization(
                app.ApplicationServices.
                GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",                    
                    pattern: "{controller=courses}/{action=courses}");
                endpoints.MapControllers();
            });
        }
    }
}
