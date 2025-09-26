using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.WebEncoders.Testing;
using System.Globalization;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<SalesWebMvcContext>(options =>
                options.UseMySQL(builder.Configuration.GetConnectionString("SalesWebMvcContext"), builder => builder.MigrationsAssembly("SalesWebMvc")));
            //Injeção de dependência

            builder.Services.AddScoped<SeedingService>();
            builder.Services.AddScoped<SellerService>();
            builder.Services.AddScoped<DepartmentService>();
            builder.Services.AddScoped<SalesRecordService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var enUs = new CultureInfo("en-US");
            var localizationOption = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = new List<CultureInfo> { enUs },
                SupportedUICultures = new List<CultureInfo> { enUs }
            };

          
            var app = builder.Build();

            app.UseRequestLocalization(localizationOption);

            // AlimentarBAncoDeDados the HTTP request pipeline.

            if (app.Environment.IsDevelopment())
            {
                AlimentarBancoDeDados(app.Services);
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }

        public static void AlimentarBancoDeDados(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var seeding = scope.ServiceProvider.GetRequiredService<SeedingService>();
            seeding.Seed();
            // scope.Dispose();
        }

       
    }
}
