using CucvangVilla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CucvangVilla.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LongDecription { get; set; }
        public string ShortDecription { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
