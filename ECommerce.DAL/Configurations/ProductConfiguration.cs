using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Bogus;
namespace ECommerce.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            //Properties
            builder.Property(x => x.ProductName).IsRequired(true);
            builder.Property(x => x.ProductName).HasMaxLength(255);
            builder.Property(x => x.ImagePath).IsRequired(false);

            //HasData
            builder.HasData(SeedProductData());

        }

        //HasData
        public List<Product> SeedProductData()
        {
          
            var fakeData = new Faker();
            List<Product> products = new List<Product>();

            for (int i = 1; i < 3; i++)
            {
                for (int z = 1; z < 11; z++)
                {
                    Product product = new Product
                    {
                        ID = i*10+z,
                        ProductName = fakeData.Commerce.Product(),
                        CategoryId = i,
                        UnitPrice = decimal.Parse(fakeData.Commerce.Price(min: 100, max: 10000, 2)),
                        ImagePath = fakeData.Image.Fashion(),
                        UnitsInStock = fakeData.Random.Short(min: 1, max: 100)

                    };
                    products.Add(product);
                }

                
            }

            return products;
        }
    }
}
