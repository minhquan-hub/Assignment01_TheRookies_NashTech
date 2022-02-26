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
    public class InformationController : Controller
    {
        private readonly ILogger<InformationController> _logger;

        public InformationController(ILogger<InformationController> logger)
        {
            _logger = logger;
        }

        [Route("about")]
        public IActionResult About(){
            return View("/Views/Information/About.cshtml");
        }

        [Route("contact")]
        public IActionResult Contact(){
            return View("/Views/Information/Contact.cshtml");
        }

        [Route("blog")]
        public IActionResult Blog(){
            return View("/Views/Information/Blog.cshtml");
        }
        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
