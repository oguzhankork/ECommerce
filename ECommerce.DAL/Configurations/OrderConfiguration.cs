using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DAL.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.OrderNumber).HasMaxLength(255);


            //AppUser Mapping
            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserId);

            //OrderDetails Mapping
            builder
                .HasMany(x => x.OrderDetails)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            //Shipper
            builder
                .HasOne(x => x.Shipper)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ShipperId);

        }
    }
}
