using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private Repository<Product> products;

        public ProductController(ApplicationDbContext context)
        {
            products = new Repository<Product>(context);
        }

        public async Task<IActionResult> Index()
        {
            return View(await products.GetAllAsync());
        }
    }
}
