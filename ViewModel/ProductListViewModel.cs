using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazaApp.Entity;

namespace MagazaApp.ViewModel
{
    public class ProductListViewModel
    {
        public List<Product>? Products { get; set; }
        public List<Category>? Categories{ get; set; }
    }
}