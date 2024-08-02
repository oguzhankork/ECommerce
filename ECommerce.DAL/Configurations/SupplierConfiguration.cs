using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DAL.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            //Property Customize
            builder.Property(x => x.CompanyName).IsRequired(true);
            builder.Property(x => x.Address).IsRequired(true);
            builder.Property(x => x.ContactName).IsRequired(true);
            builder.Property(x => x.PhoneNumber).IsRequired(false);
            builder.Property(x => x.CompanyName).HasMaxLength(155);
            builder.Property(x => x.Address).HasMaxLength(155);
            builder.Property(x => x.PhoneNumber).HasMaxLength(13);
            builder.Property(x => x.ContactName).HasMaxLength(40);


            //HasData
            builder.HasData(SeedSupplierData());

        }

        //Supplier Data
        private List<Supplier> SeedSupplierData()
        {
            List<Supplier> suppliers = new List<Supplier>();

            suppliers.Add(new Supplier
            {
                ID = 1,
                CompanyName = "Test Supplier1",
                Address = "Test Supplier Adress1",
                ContactName = "Test Contact1"

            });
            suppliers.Add(new Supplier
            {
                ID = 2,
                CompanyName = "Test Supplier2",
                Address = "Test Supplier Adress2",
                ContactName = "Test Contact2"
            });
            suppliers.Add(new Supplier
            {
                ID = 3,
                CompanyName = "TestSupplier3",
                Address = "TestSupplierAdress3",
                ContactName = "Test Contact3"
            });
            return suppliers;
        }
    }
}
