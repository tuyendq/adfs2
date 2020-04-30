using adfs2.Areas.Identity.Data;
using adfs2.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace adfs2
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
            // Add authentication

            services.AddControllersWithViews();
            // Add database context
            // services.AddDbContext<adfs2Context>(options =>
            //     options.UseSqlServer(Configuration.GetConnectionString("adfs2Context")));
            services.AddDbContext<adfs2Context>(options =>
                options.UseSqlite(Configuration.GetConnectionString("adfs2Context")));
            services.AddDbContext<adfs2IdentityDbContext>(options =>
                // SqlServer
                // options.UseSqlServer(
                    // context.Configuration.GetConnectionString("adfs2IdentityDbContextConnection")));
                // Sqlite
                options.UseSqlite(
                    Configuration.GetConnectionString("adfs2IdentityDbContextConnectionDev")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<adfs2IdentityDbContext>();                                    
            
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",

                    // Try settings /Account/Welcome as default home page
                    // pattern: "{controller=Account}/{action=Welcome}/{id?}");
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                // Add after scaffolding Identity
                endpoints.MapRazorPages();
            });
        }
    }
}
