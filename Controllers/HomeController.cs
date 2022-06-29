using Microsoft.AspNetCore.Mvc;

namespace Ranaonline_store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
