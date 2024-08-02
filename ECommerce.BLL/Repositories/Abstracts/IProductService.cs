using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Abstracts
{
    public interface IProductService
    {
        Task<string> CreateProductAsync(Product product);
        List<Product> GetProductByCategoryId(int categoryId);

        List<Product> GetAllProducts();

        IEnumerable<Product> GetActiveProducts();

        Product GetProductById(int productId);
    }
}
