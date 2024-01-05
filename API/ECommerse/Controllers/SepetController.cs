using ECommerse.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerse.Controllers
{
    public class SepetController : Controller
    {

        private readonly ApiGateway _apiGateway;

        public SepetController(ApiGateway apiGateway)
        {
            _apiGateway = apiGateway;
        }
        public IActionResult Index()
        {
            List<Product> basket;
            basket = _apiGateway.ListBasket();
            return View(basket);
        }
        
    }
}
