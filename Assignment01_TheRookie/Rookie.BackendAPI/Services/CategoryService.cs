using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.BackendAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateCategory(CategoryCreateRequest categoryCreateRequest)
        {
            var categoryLast = _context.Categories.OrderBy(c => c.CategoryId).Last();

             if(categoryLast == null)
            {
                throw new Exception("CreateCategory of CategoryService");
            }

            var category = new Category {
                    CategoryId = CreateCategoryId(categoryLast.CategoryId),
                    CategoryName = categoryCreateRequest.CategoryName,
                    Description = categoryCreateRequest.Description
                    };

            _context.Categories.Add (category);
            await _context.SaveChangesAsync();
        }

        public List<Category> GetAllCategory()
        {
            var category = (from c in _context.Categories where !c.IsDelete select c).ToList();

            if(category == null)
            {
                throw new Exception("GetAllCategory of CategoryService");
            }

            return category;
        }

        public async Task UpdateCategory(string categoryId, CategoryCreateRequest categoryCreateRequest)
        {
            var category =_context
                            .Categories
                            .Where(c => c.CategoryId.Equals(categoryId))
                            .FirstOrDefault();

            if(category == null)
            {
                throw new Exception("UpdateCategory of CategoryService");
            }

            if (!string.IsNullOrEmpty(categoryCreateRequest.CategoryName))
            {
                category.CategoryName = categoryCreateRequest.CategoryName;
                category.Description = categoryCreateRequest.Description;
            }

            _context.Categories.Update (category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(string categoryId)
        {
            var category = _context
                            .Categories
                            .Where(c => c.CategoryId.Equals(categoryId))
                            .FirstOrDefault();
            
            if(category == null)
            {
                throw new Exception("DeleteCategory of CategoryService");
            }

            category.IsDelete = true;
            _context.Categories.Update (category);
            await _context.SaveChangesAsync();
        }

        public string CreateCategoryId(string categoryIdOld)
        {
            var separateIdString = categoryIdOld.Substring(1);
            var categoryIdParse = int.Parse(separateIdString) + 1;
            return "C" + categoryIdParse.ToString();
        }
    }
}
