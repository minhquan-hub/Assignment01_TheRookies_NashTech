using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel;

namespace Rookie.CustomerSite.Pages.Product
{
    public class ProductPageModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductPageModel(IProductService productService, IMapper mapper) 
        {
            _productService = productService;
            _mapper = mapper;
        }
        
        [BindProperty(SupportsGet = true)]
        public string ProductName { get; set; }
        [BindProperty(SupportsGet = true)]
        public IList<ProductVM> ProductVM { get; set; }
        // public async Task OnPostProduct(){
        //    if(ProductName == null){
        //        ProductName = "Ginger";
        //    }
        //    var productDto = await  _productService.GetProductByNameAsync(ProductName);
        //     ProductVM = _mapper.Map<IList<ProductVM>>(productDto);
        // }

        public async Task OnGet(){
           if(ProductName == null){
               ProductName = "Ginger";
           }
           var productDto = await  _productService.GetProductByNameAsync(ProductName);
            ProductVM = _mapper.Map<IList<ProductVM>>(productDto);
        }
    }
}