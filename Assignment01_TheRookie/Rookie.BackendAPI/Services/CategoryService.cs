using System.Threading.Tasks;
using Rookie.BackendAPI.Services.InterfaceServices;
using System;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Models;
using System.Linq;
using System.Collections.Generic;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.BackendAPI.Services{

    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task CreateCategory(CategoryCreateRequest categoryCreateRequest)
        {
            try
            {
                var categoryLast =  _context.Categories.OrderBy(c => c.CategoryId).Last();

                var category = new Category {
                CategoryId = CreateCategoryId(categoryLast.CategoryId),
                CategoryName = categoryCreateRequest.CategoryName,
                Description = categoryCreateRequest.Description
                };

                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"At CreateCategory() of CategoryService: {ex.Message}");
            }
            
        }
        public List<Category> GetAllCategory()
        {
            try{
                var category =  (from c in _context.Categories 
                                where !c.IsDelete select c).ToList();
                return category;
            }
            catch(Exception ex)
            {
                throw new Exception($"At GetAllCategory() of CategoryService: {ex.Message}");
            }
            
        }

        public async Task UpdateCategory(string categoryId, CategoryCreateRequest categoryCreateRequest)
        {
            var category = _context.Categories.Where(c => c.CategoryId.Equals(categoryId)).FirstOrDefault();

            if(!string.IsNullOrEmpty(categoryCreateRequest.CategoryName))
            {
                category.CategoryName = categoryCreateRequest.CategoryName;
                category.Description = categoryCreateRequest.Description;
            }
            
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(string categoryId)
        {
            try
            {
                var category = _context.Categories.Where(c => c.CategoryId.Equals(categoryId)).FirstOrDefault();
                category.IsDelete = true;
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"At DeleteCategory() of CategoryService: {ex.Message}");
            }
            
        }

        public string CreateCategoryId(string categoryIdOld)
        {
            var separateIdString = categoryIdOld.Substring(1);
            var categoryIdParse = int.Parse(separateIdString)+1;
            return "C"+ categoryIdParse.ToString();
        }

    }
}