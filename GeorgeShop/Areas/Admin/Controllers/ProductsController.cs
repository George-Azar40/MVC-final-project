using GeorgeShop.Data;
using GeorgeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeorgeShop.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(new Product() { } );
        }
        public IActionResult Store(Product request , IFormFile Image)
        {
            return Content("OK");
        }
    }
}
