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
using Rookie.CustomerSite.ViewModel.Image;

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
        public PagedResponseVM<ProductVM<ImageVM>> PagedResponseVM { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<CategoryVM> CategoryVM { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<ProductVM<ImageVM>> ProductVM { get; set; }

        public async Task OnGetProductCategoryName(string categorynameclient)
        {
            var pageResponseDto = await  _productService.GetProductByCategoryAndPageAsync(categorynameclient);
            PagedResponseVM = _mapper.Map<PagedResponseVM<ProductVM<ImageVM>>>(pageResponseDto);
            await ShowCategoryName();
        }

        public async Task OnPostProductByName()
        {
            var pageResponseDto = await  _productService.GetProductByNameAsync(ProductName);
            PagedResponseVM = _mapper.Map<PagedResponseVM<ProductVM<ImageVM>>>(pageResponseDto);
            await ShowCategoryName();
        }

        public async Task OnGet()
        {
           var pageResponseDto = await  _productService.GetAllProductAsync();
           PagedResponseVM = _mapper.Map<PagedResponseVM<ProductVM<ImageVM>>>(pageResponseDto);

           await ShowCategoryName();
        }

        public async Task ShowCategoryName()
        {
            var categoryDto = await _categoryService.GetAllCategoryAsync();
            CategoryVM = _mapper.Map<IList<CategoryVM>>(categoryDto);
        }
    }
}