using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CucvangVilla.Models;
using CucvangVilla.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CucvangVilla.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var product = _productRepository.GetAllProduct().OrderBy(p => p.Id);
            var productViewModel = new ProductViewModel()
            {
                Title = "Welcome to Cuc Vang Villa",
                Products = product.ToList()
            };
            return View(productViewModel);
        }
    }
}