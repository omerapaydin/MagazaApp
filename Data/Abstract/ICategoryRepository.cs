using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagazaApp.Entity;

namespace MagazaApp.Data.Abstract
{
    public interface ICategoryRepository
    {
         IQueryable<Category> Categories { get; }
        void AddCategory(Category category);
    }
}