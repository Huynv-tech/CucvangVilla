using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CucvangVilla.Models
{
    public class ProductRepository:IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> GetAllProduct()
        {
            return _appDbContext.Products;
        }
        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
