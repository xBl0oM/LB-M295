using Microsoft.AspNetCore.Mvc;

namespace Floorballer.Controllers
{
    public class FloorballController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
