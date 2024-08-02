using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.BaseAbstract;
using ECommerce.BLL.Repositories.Concretes;
using ECommerce.BLL.Repositories.Concretes.BaseConcrete;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.IOC.DependencyResolvers
{
    public static class RepositoryService
    {
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IShipperService, ShipperService>();
            return services;
        }
    }
}

