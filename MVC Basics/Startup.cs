using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVC_Basics
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(); // add MVC so we can use it
            services.AddDistributedMemoryCache();
            
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // app.UseDefaultFiles();  // looks for index.html or default.html in wwwroot folder

            app.UseSession(); // Ska den vara här???

            app.UseStaticFiles();  // default opens up the wwwroot folder to be accessed

            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {

                // special routes before default
                endpoints.MapControllerRoute("GuessingGame", "{controller=GuessNumber}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("FeverCheck", "{controller=Health}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                // endpoints.MapGet("/", async context =>         Hur vi routar med version 3.0 - Det utkommenterade är färdig default-text
                // {
                //    await context.Response.WriteAsync("Hello World!");
                // });
            });
        }
    }
}
