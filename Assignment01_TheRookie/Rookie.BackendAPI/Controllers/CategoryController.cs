using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;

namespace Rookie.BackendAPI.Controllers {

    public class CategoryController : ControllerBase 
    {
        
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        // private readonly IFileStorageService _fileStorageService;
        
        public CategoryController(
            ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public  IActionResult GetCategory(){

            return Ok();
        }
    }
}