using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel.Product;

namespace Rookie.CustomerSite.Pages.Product
{
    public class DetailPageModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public DetailPageModel(IProductService productService, IMapper mapper) 
        {
            _productService = productService;
            _mapper = mapper;
        }
        
        // [BindProperty(SupportsGet = true)]
        // public string ProductName { get; set; }
        [BindProperty(SupportsGet = true)]
        public ProductVM ProductVM { get; set; }
        // public async Task OnPostProduct(){
        //    if(ProductName == null){
        //        ProductName = "Ginger";
        //    }
        //    var productDto = await  _productService.GetProductByNameAsync(ProductName);
        //     ProductVM = _mapper.Map<IList<ProductVM>>(productDto);
        // }

        public async Task OnGet(int id){
           if(id == 0){
               id = 3;
           }
           var productDto = await  _productService.GetProductById(id);
            ProductVM = _mapper.Map<ProductVM>(productDto);
        }
    }
}