using ECommerce.DAL.Context;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.IOC.DependencyResolvers
{
    public static class IdentityService
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppUserRole>()
    .AddEntityFrameworkStores<EcommerceContext>()
    .AddDefaultTokenProviders();//todo: Token oluşturmak için bu sağlayıcıya ihtiyaıcımız bulunmaktadır.


            services.Configure<IdentityOptions>(x => {
                x.Password.RequireDigit = true; //en az 1 rakam zorunluluğu
                x.Password.RequireNonAlphanumeric = true;//en az 1 sayı ve numara hariç karakter zorunluluğu
                x.Password.RequireUppercase = true;//en az 1 büyük harf zorunluluğu  
                x.Password.RequireLowercase = true;//en az 1 küçük harf zorunluluğu 
                x.Password.RequiredLength = 8; //Minimum şifre uzunluğu


            });


            services.ConfigureApplicationCookie(cookie =>
            {
                cookie.LoginPath = new PathString("/Home/Login");
                cookie.AccessDeniedPath = new PathString("/Home/Denied");
                cookie.Cookie = new CookieBuilder { Name = "ECommerceCookie" };
                cookie.SlidingExpiration = true;
                cookie.ExpireTimeSpan = TimeSpan.FromMinutes(5);
            });


            return services;
        }
    }
}
