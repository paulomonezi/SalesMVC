using Microsoft.AspNetCore.Mvc;

namespace SalesMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
