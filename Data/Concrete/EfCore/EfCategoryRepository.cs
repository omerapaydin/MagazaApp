using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazaApp.Data.Abstract;
using MagazaApp.Entity;

namespace MagazaApp.Data.Concrete.EfCore
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly IdentityContext _context;
        public EfCategoryRepository(IdentityContext context)
        {
            _context = context;
        }

        public IQueryable<Category> Categories => _context.Categories;

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}