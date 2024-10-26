using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.ProductAttributes.Services;
using OnlineStore.Core.Products.Services;
using OnlineStore.MVC.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OnlineStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IProductAttributeService _productAttributeService;

        public HomeController(
            ILogger<HomeController> logger,
            IProductService productService,
            IProductAttributeService productAttributeService)
        {
            _logger = logger;
            _productService = productService;
            _productAttributeService = productAttributeService;
        }

        public async Task<IActionResult> Index()
        {
            var attribute = await _productAttributeService.GetAsync(1);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
