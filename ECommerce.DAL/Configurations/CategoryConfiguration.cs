using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Properties
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.CategoryName).HasMaxLength(255);


            builder.HasData(SeedCategoryData());

        }

        //Category Data
        private List<Category> SeedCategoryData()
        {
            List<Category> categories = new List<Category>();

            categories.Add(new Category { ID = 1, CategoryName = "Test Category 1", Description = "Test Category 1 Description" });
            categories.Add(new Category { ID = 2, CategoryName = "Test Category 2", Description = "Test Category 2 Description" });
            categories.Add(new Category { ID = 3, CategoryName = "Test Category 3", Description = "Test Category 3 Description" });

            return categories;
        }
    }
}
