using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.Property(x => x.CompanyName).HasMaxLength(255);

            //Order Mapping
            builder
                .HasMany(x => x.Orders)
                .WithOne(x => x.Shipper)
                .HasForeignKey(x => x.ShipperId);

        }


    }
}
