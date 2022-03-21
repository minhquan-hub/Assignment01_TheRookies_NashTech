using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel;
using Rookie.CustomerSite.ViewModel.Category;
using Rookie.CustomerSite.ViewModel.Image;
using Rookie.CustomerSite.ViewModel.Product;
using Rookie.ShareClass.Constants;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Category;
using Rookie.ShareClass.Dto.Product;
using Rookie.ShareClass.Enum;

namespace Rookie.CustomerSite.Pages.Product
{
    public class ProductPageModel : PageModel
    {
        private readonly IProductService _productService;

        private readonly ICategoryService _categoryService;

        private readonly IConfiguration _config;

        private readonly IMapper _mapper;

        private static string prevProductName;

        public ProductPageModel(
            IProductService productService,
            ICategoryService categoryService,
            IConfiguration config,
            IMapper mapper
        )
        {
            _productService = productService;
            _categoryService = categoryService;
            _config = config;
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

        public async Task OnGetAsync(int? pageIndex)
        {
            if(ProductName == null){
                ProductName = prevProductName;
            }
            var productCriteriaDto =
                new ProductCriteriaDto {
                    Search = ProductName,
                    SortOrder = SortOrderEnum.Accsending,
                    Page = pageIndex ?? 1,
                    Limit = int.Parse(_config[ConfigurationConstants.PAGING_LIMIT])
                };
            prevProductName = ProductName;
            var pageResponseDto = await _productService.GetAllProductAndPageAsync(productCriteriaDto);
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
