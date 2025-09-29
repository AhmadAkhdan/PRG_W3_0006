using Microsoft.AspNetCore.Mvc;

namespace PRG_W3_0006.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
