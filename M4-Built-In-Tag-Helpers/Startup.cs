using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppTagHelper
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
            services.AddTransient<ISessionsService, SessionsService>();

            services.AddTransient<ITimeSinceService, TimeSinceService>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\pkellner\Downloads\aspdotnet-core-tag-helpers (1)\04\demos\M3\WebAppTagHelper\cacheTagHelperDb.mdf";Integrated Security=True;Connect Timeout=30

            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='C:\USERS\PKELLNER\DOWNLOADS\ASPDOTNET-CORE-TAG-HELPERS (1)\04\DEMOS\M3\WEBAPPTAGHELPER\CACHETAGHELPERDB.MDF';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDistributedSqlServerCache(opt =>
            {
                opt.ConnectionString = cs;
//                    Configuration.GetConnectionString("DefaultConnection");
                opt.SchemaName = "dbo";
                opt.TableName = "SQLCache";
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

           

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
