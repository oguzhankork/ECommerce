using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DAL.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.ProductId, x.OrderId });

            //Mapping
            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);

            builder.HasOne(x=>x.Product)
                .WithMany(x=>x.OrderDetails)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
