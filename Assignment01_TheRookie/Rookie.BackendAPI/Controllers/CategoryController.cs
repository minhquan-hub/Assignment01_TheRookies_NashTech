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
        
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        // private readonly IFileStorageService _fileStorageService;
        
        public CategoryController(
            ApplicationDbContext context,
            IMapper mapper,
            ICategoryService categoryService)
        {
            _context = context;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        //Get: https://localhost:5001/api/Category
        [HttpGet]
        public ActionResult<CategoryDto> GetAllCategory(){
            var category =  _categoryService.GetAllCategory();
            var categoryDto = _mapper.Map<IEnumerable<CategoryDto>>(category);
            return Ok(categoryDto);
        }
    }
}