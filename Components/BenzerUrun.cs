using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazaApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagazaApp.Components
{
    public class BenzerUrun : ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public BenzerUrun(  IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> Invoke()
        {
            return View(await _productRepository.Products.OrderByDescending(p=>p.PublishedOn).Take(4).ToListAsync());
        }
    }
}