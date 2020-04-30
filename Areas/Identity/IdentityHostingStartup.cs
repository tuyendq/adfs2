// using System;
// using adfs2.Areas.Identity.Data;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Identity.UI;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;

// [assembly: HostingStartup(typeof(adfs2.Areas.Identity.IdentityHostingStartup))]
// namespace adfs2.Areas.Identity
// {
//     public class IdentityHostingStartup : IHostingStartup
//     {
//         public void Configure(IWebHostBuilder builder)
//         {
//             builder.ConfigureServices((context, services) => {
//                 // services.AddDbContext<adfs2IdentityDbContext>(options =>
//                 //     // SqlServer
//                 //     // options.UseSqlServer(
//                 //         // context.Configuration.GetConnectionString("adfs2IdentityDbContextConnection")));
//                 //     // Sqlite
//                 //     options.UseSqlite(
//                 //         context.Configuration.GetConnectionString("adfs2IdentityDbContextConnectionDev")));


//                 // services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                 //     .AddEntityFrameworkStores<adfs2IdentityDbContext>();
//             });
//         }
//     }
// }