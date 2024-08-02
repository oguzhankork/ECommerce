using ECommerce.DAL.Configurations;
using ECommerce.Model.Base;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Context
{
    public class EcommerceContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {

        public EcommerceContext(DbContextOptions<EcommerceContext> options):base(options) { }
        

        //DbSets

        //Category DbSet
        public DbSet<Category> Categories { get; set; }

        //Product DbSet
        public DbSet<Product> Products { get; set; }

        //SupplierDbSet
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }



        

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {


            try
            {
                var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);


                foreach (var item in modifiedEntries)
                {

                    var entityRepository = item.Entity as BaseEntity;

                    if (item.State == EntityState.Modified)
                    {
                        entityRepository.UpdatedDate = DateTime.Now;
                        entityRepository.UpdatedIpAddress = "";
                        entityRepository.UpdatedComputerName = System.Environment.MachineName;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            //CategoryConfiguration
            builder.ApplyConfiguration(new CategoryConfiguration());
            //ProductConfiguration
            builder.ApplyConfiguration(new ProductConfiguration());
            //SupplierConfiguration
            builder.ApplyConfiguration(new SupplierConfiguration());
            //Order
            builder.ApplyConfiguration(new OrderConfiguration());
            //OrderDetails
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            //Shipper
            builder.ApplyConfiguration(new ShipperConfiguration());


            base.OnModelCreating(builder);
        }
    }
}
