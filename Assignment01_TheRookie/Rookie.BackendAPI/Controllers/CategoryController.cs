using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;
using Rookie.BackendAPI.Services.InterfaceServices;
using Rookie.ShareClass.Dto.Category;

namespace Rookie.BackendAPI.Controllers {

    [Route("api/[controller]")]
    [EnableCors("AllowOrigins")]
    [ApiController]
    public class CategoryController : ControllerBase 
    {
        
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        
        public CategoryController(
            IMapper mapper,
            ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpPost]
        public ActionResult PostCategory([FromForm] CategoryCreateRequest categoryCreateRequest)
        {
            if(!string.IsNullOrEmpty(categoryCreateRequest.CategoryName)){
                _categoryService.CreateCategory(categoryCreateRequest);
            }
            return Ok(true);
        }

        //Get: https://localhost:5001/api/Category
        [HttpGet]
        public ActionResult<CategoryDto> GetAllCategory()
        {
            var category =  _categoryService.GetAllCategory();
            var categoryDto = _mapper.Map<IEnumerable<CategoryDto>>(category);
            return Ok(categoryDto);
        }

        // PUT: https://localhost:5001/api/Category/C3001
        [HttpPut("{categoryId}")]
        public ActionResult PutCategory(string categoryId,[FromForm]CategoryCreateRequest categoryCreateRequest)
        {
            if(string.IsNullOrEmpty(categoryId))
            {
                return NotFound();
            }
            _categoryService.UpdateCategory(categoryId, categoryCreateRequest);
            return Ok(true);
        }

        // DELETE: https://localhost:5001/api/Category/C3001
        [HttpDelete("{categoryId}")]
        public ActionResult DeleteCategory(string categoryId)
        {
            if(string.IsNullOrEmpty(categoryId))
            {
                return NotFound();
            }
            _categoryService.DeleteCategory(categoryId);
            return Ok(true);
        }

    }
}