using GeorgeShop.Data;
using GeorgeShop.Models;
using GeorgeShop.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace GeorgeShop.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProductsController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var products = context.Products.Include(p=>p.Category).ToList();
            var productsVm = new List<ProductsViewModel>();

            foreach(var item in products)
            {
                var Vm = new ProductsViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Image = $"/Images/{item.Image}"
                };
                productsVm.Add(Vm);
            }
            return View(products);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(new Product() { } );
        }
        public async Task<IActionResult> Store(Product request , IFormFile Image)
        {
            if(Image!=null && Image.Length>0)
            {
                var fileName = Guid.NewGuid().ToString();
                fileName = Path.GetExtension(Image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images" , fileName);
                using (var stream = System.IO.File.Create(filePath))
                {
                    Image.CopyTo(stream);
                }
                request.Image = fileName;
                context.Products.Add(request);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return Content("OK");
        }
        
    }
}
