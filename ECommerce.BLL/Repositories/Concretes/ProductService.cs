using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.BaseAbstract;
using ECommerce.DAL.Context;
using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Concretes
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
            
        }

        public async Task<string> CreateProductAsync(Product product)
        {
           return await _productRepository.Create(product);
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _productRepository.GetAll().Where(x => x.IsActive == true).ToList();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _productRepository.GetAll().Where(x => x.CategoryId == categoryId).ToList();
        }

        public Product GetProductById(int productId)
        {
            return  _productRepository.GetById(productId);
        }

        
    }
}
