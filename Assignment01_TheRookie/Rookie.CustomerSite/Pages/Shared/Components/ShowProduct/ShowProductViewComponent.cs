using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Rookie.CustomerSite.ViewModel.Product;

namespace Rookie.CustomerSite.Pages.Shared.Components.ShowProductDetails
{
    public class ShowProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<ProductVM> productVM)
        {
            return View<List<ProductVM>>(productVM);
        }
    }
}