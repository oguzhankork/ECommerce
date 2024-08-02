using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.IOC.DependencyResolvers
{
    public static class ContextService
    {
        //metot parametresinde bulunan services parametresi ilgili metodu hangi katmanda kullanacaksak o katmanın servisi haline bürünmesi için tanımladık.
        public static IServiceCollection AddECommerceDb(this IServiceCollection services)
        {

           var provider= services.BuildServiceProvider(); //sağlayıcı oluşturduk. Bu sağlacının amacı ise IServiceCollection'da bulunan bir takım servisleri bu metot içerisinden ulaşılabilmesidir.

           var configuration= provider.GetService<IConfiguration>();//appsettings gibi sabirt değerlere ulaşabildiğimiz alanlara bu metot tarafından erişimi sağlamak için..

             services.AddDbContext<EcommerceContext>(options => options.UseSqlServer(configuration.GetConnectionString("OguzConnection"), b => b.MigrationsAssembly("Ecommerce.MVC")));

           
            return services;
        }
    }
}
