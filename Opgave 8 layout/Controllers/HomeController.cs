using Microsoft.AspNetCore.Mvc;

namespace Opgave_8_layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Sale()
        {
            return View();
        }

        public IActionResult MoreSales()
        {
            return View();
        }

        public IActionResult Buy()
        {
            return View();
        }

        public IActionResult BuyAndSale()
        {
            return View();
        }
    }
}
