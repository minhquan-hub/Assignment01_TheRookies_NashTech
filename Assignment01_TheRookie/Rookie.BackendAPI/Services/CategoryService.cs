using System.Threading.Tasks;
using Rookie.BackendAPI.Services.InterfaceServices;
using System;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using System.Linq;
using System.Collections.Generic;

namespace Rookie.BackendAPI.Services{

    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<int> CreateCategory(Category createCategory)
        {
            var newCategory = new Category {
                CategoryId = createCategory.CategoryId,
                CategoryName = createCategory.CategoryName,
                Description = createCategory.Description
            };

            _context.Categories.Add(newCategory);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteCategory(int categoryId)
        {
             var category = _context.Categories.Where(c => c.CategoryId == categoryId).FirstOrDefault();
            if(category == null){
                Console.WriteLine("Can't find category you want to delete");
            }
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public List<Category> GetAllCategory()
        {
            var category =  (from c in _context.Categories select c).ToList();

            return category;
        }
        public async Task<int> UpdateCategory(int CategoryId, Category category)
        {
            return 1;
        }
    }
}