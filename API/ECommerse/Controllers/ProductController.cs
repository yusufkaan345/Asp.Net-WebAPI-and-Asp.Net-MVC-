using ECommerse.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerse.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApiGateway _apiGateway;

        public ProductController(ApiGateway apiGateway)
        {
            _apiGateway=apiGateway;
        }
        public IActionResult Index()
        {
            List<Product> products; 
            products= _apiGateway.ListProducts();
            return View(products);
        }

        [HttpGet]

      /*  public IActionResult Create()
        {
            Product product = new Product();
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return RedirectToAction("index");
        }
       */
        public IActionResult Display(int Id)
        {
            Product product = new Product();
            //Fetch products from api and show the display page
            return View(product);
        }
    }
}
