using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CucvangVilla.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int productId);
    }
}
