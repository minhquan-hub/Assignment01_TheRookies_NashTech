using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel.Image;
using Rookie.CustomerSite.ViewModel.Product;
using Rookie.CustomerSite.ViewModel.Rating;
using Rookie.ShareClass.Dto.Rating;

namespace Rookie.CustomerSite.Pages.Product
{
    public class DetailPageModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IRatingService _ratingService;
        private readonly IMapper _mapper;
        public DetailPageModel(IProductService productService, IRatingService ratingService, IMapper mapper) 
        {
            _productService = productService;
            _ratingService = ratingService;
            _mapper = mapper;
        }
        
        // [BindProperty(SupportsGet = true)]
        // public string ProductName { get; set; }
        [BindProperty(SupportsGet = true)]
        public ProductVM<ImageVM> ProductVM { get; set; }
        
        // Insert data rating product
        public async Task OnGetRating(int number, string productid)
        {
            var ratingVM = new RatingVM{
                ProductId = productid,
                UserId = "",
                RateNumber = number
            };
            var ratingDto = _mapper.Map<RatingDto>(ratingVM);
            await _ratingService.InsertRatingAsync(ratingDto);
            await OnGet(productid);
        }

        // Take data product by id
        public async Task OnGet(string id)
        {
        //    if(id == 0)
        //    {
        //        id = 3;
        //    }
           var productDto = await  _productService.GetProductById(id);
            ProductVM = _mapper.Map<ProductVM<ImageVM>>(productDto);
        }
    }
}