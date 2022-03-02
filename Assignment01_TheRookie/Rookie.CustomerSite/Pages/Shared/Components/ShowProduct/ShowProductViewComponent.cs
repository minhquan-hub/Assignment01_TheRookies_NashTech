using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Rookie.CustomerSite.ViewModel.Image;
using Rookie.CustomerSite.ViewModel.Product;

namespace Rookie.CustomerSite.Pages.Shared.Components.ShowProduct
{
    public class ShowProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<ProductVM<ImageVM>> productVM)
        {
            return View<List<ProductVM<ImageVM>>>(productVM);
        }
    }
}