using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CucvangVilla.Models
{
    public class MockProductRepository:IProductRepository
    {
        private List<Product> _product;

        public MockProductRepository()
        {
            if (_product == null)
            {
                InitializeProduct();
            }
        }

        private void InitializeProduct()
        {
            _product = new List<Product>
            {
                new Product {Id=1, Name = "huynv",LongDescription="hehehee",Price=2000,Image="https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg"},
                new Product {Id=2, Name = "Hoan",LongDescription="hehehee",Price=3000,Image="https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg"},
                new Product {Id=3, Name = "Nga",LongDescription="hehehee",Price=4000,Image="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg"},
                new Product {Id=4, Name = "Duc",LongDescription="hehehee",Price=5000,Image="https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg"},
                new Product {Id=5, Name = "Phuong",LongDescription="hehehee",Price=6000,Image="https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg"},
            };
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _product;
        }

        public Product GetProductById(int productId)
        {
            return _product.FirstOrDefault(p => p.Id == productId);
        }
    }
}
