

using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rookie.BackendAPI.Data;

namespace Rookie.BackendAPI.Controllers{
    public class ProductController : Controller {
        
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        // private readonly IFileStorageService _fileStorageService;
        
        public ProductController(
            ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(){

            return View();
        }


    }
}