using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazaApp.Data.Abstract;
using MagazaApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagazaApp.Controllers
{
    public class HomeController:Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;


        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List()
        {
            var viewModel = new ProductListViewModel
            {
                Products = await _productRepository.Products.ToListAsync()
                , Categories = await _categoryRepository.Categories.ToListAsync()
            };
            return View(viewModel);
        } 
    }
}