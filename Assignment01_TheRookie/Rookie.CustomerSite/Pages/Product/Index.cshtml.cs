using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.Extensions.Configuration;
using Rookie.CustomerSite.Services.InterfaceServices;
using Rookie.CustomerSite.ViewModel;
using Rookie.CustomerSite.ViewModel.Category;
using Rookie.CustomerSite.ViewModel.Image;
using Rookie.CustomerSite.ViewModel.Product;
using Rookie.ShareClass.Constants;
using Rookie.ShareClass.Dto;
using Rookie.ShareClass.Dto.Category;
using Rookie.ShareClass.Dto.Image;
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
        public string ProductNameBinding { get; set; }

        [BindProperty(SupportsGet = true)]
        public PagedResponseVM<ProductVM<ImageVM>> PagedResponseVM { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<CategoryVM> CategoryVM { get; set; }

        [BindProperty(SupportsGet = true)]
        public IList<ProductVM<ImageVM>> ProductVM { get; set; }

        public async Task OnGetAsync(string productName,int? pageIndex)
        {
            if(ProductNameBinding != null){
                productName = ProductNameBinding;
            }

            var productCriteriaDto =
                new ProductCriteriaDto {
                    Search = productName,
                    SortOrder = SortOrderEnum.Accsending,
                    Page = pageIndex ?? 1,
                    Limit = int.Parse(_config[ConfigurationConstants.PAGING_LIMIT])
                };
            
            var pageResponseDto = await _productService.GetAllProductAndPageAsync(productCriteriaDto);
            PagedResponseVM = _mapper.Map<PagedResponseVM<ProductVM<ImageVM>>>(pageResponseDto);

            var categoryDto = await _categoryService.GetAllCategoryAsync();
            CategoryVM = _mapper.Map<IList<CategoryVM>>(categoryDto);
        }
    }
}
