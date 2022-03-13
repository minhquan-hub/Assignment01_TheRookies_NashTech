using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rookie.CustomerSite.Models;

namespace CustomerSite.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;

        public ShopController(ILogger<ShopController> logger)
        {
            _logger = logger;
        }

        [Route("wishlist")]
        public IActionResult Wishlist()
        {
            return View("/Views/Shop/WishList.cshtml");
        }

        [Route("cart")]
        public IActionResult Cart(){
            return View("/Views/Shop/Cart.cshtml");
        }

        [Route("checkout")]
        public IActionResult CheckOut(){
            return View("/Views/Shop/CheckOut.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
