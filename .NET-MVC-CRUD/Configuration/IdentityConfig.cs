using CRUD.Data;
using Microsoft.AspNetCore.Identity;

namespace CRUD.Configuration
{
    public static class IdentityConfig
    {
        public static WebApplicationBuilder AddIdentityConfiguration(this WebApplicationBuilder builder)
        {
            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>();

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("PermanentDelete", policy =>
                    policy.RequireRole("Admin"));

                options.AddPolicy("ViewProduct", policy =>
                    policy.RequireClaim("Products", "VI"));
            });

            return builder;
        }
    }
}
