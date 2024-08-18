using data_store_system.Services;
using Microsoft.AspNetCore.Mvc;

namespace data_store_system.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
    }
}
