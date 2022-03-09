﻿using appmovies.Models;
using Microsoft.EntityFrameworkCore;

namespace appmovies
{
    public static class Startup
    {
        public static IConfiguration Configuration { get; set; }
        public static  WebApplication InitialApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureService(builder);
            var app = builder.Build();
            Configure(app);
            return app;

        }

        private static void ConfigureService(WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddDbContext<StartwarsDb>(options => options.UseSqlServer(Configuration.GetConnectionString("Startwars")));

            builder.Services.AddControllersWithViews();

        }

        private static void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
        

    }
}