using AppSemTemplate.Configuration;
using CRUD.Data;
using CRUD.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Configuration
{
    public static class MvcConfig
    {
        public static WebApplicationBuilder AddMvcConfiguration(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                MvcOptionsConfig.ConfigurarMensagensDeModelBinding(options.ModelBindingMessageProvider);
            }).AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

            builder.Services.AddRouting(options =>
                options.ConstraintMap["slugify"] = typeof(RouteSlugifyParameterTransformer));

            builder.Services.AddDbContext<AppDbContext>(o =>
                o.UseSqlServer(connectionString)
            );

            builder.Services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(60);
            });

            return builder;
        }

        public static WebApplication UseMvcConfiguration(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseGlobalizationConfig();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.MapRazorPages();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller:slugify=Home}/{action:slugify=Index}/{id?}");

            return app;
        }
    }
}
