using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel.Product;
using Rookie.CustomerSite.ViewModel.Category;
using Rookie.CustomerSite.ViewModel;

namespace Rookie.CustomerSite.Pages.Product
{
    public class ProductPageModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public ProductPageModel(IProductService productService,ICategoryService categoryService, IMapper mapper) 
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }
        
        [BindProperty(SupportsGet = true)]
        public string ProductName { get; set; }

        [BindProperty(SupportsGet = true)]
        public PagedResponseVM<ProductVM> PagedResponseVM { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<CategoryVM> CategoryVM { get; set; }

        // public async Task OnPostProduct(){
        //    if(ProductName == null){
        //        ProductName = "Ginger";
        //    }
        //    var productDto = await  _productService.GetProductByNameAsync(ProductName);
        //     ProductVM = _mapper.Map<IList<ProductVM>>(productDto);
        // }

        public async Task OnGetProductCategoryName(string categorynameclient)
        {
            var productDto = await  _productService.GetProductByCategoryAndPageAsync(categorynameclient);
            PagedResponseVM = _mapper.Map<PagedResponseVM<ProductVM>>(productDto);
            await ShowCategoryName();
        }

        public async Task OnGet()
        {
           if(ProductName == null)
           {
               ProductName = "Ginger";
           }
           var productDto = await  _productService.GetProductAndPageAsync(ProductName);
           PagedResponseVM = _mapper.Map<PagedResponseVM<ProductVM>>(productDto);
           await ShowCategoryName();
        }

        public async Task ShowCategoryName()
        {
            var categoryDto = await _categoryService.GetAllCategoryAsync();
            CategoryVM = _mapper.Map<IList<CategoryVM>>(categoryDto);
        }
    }
}