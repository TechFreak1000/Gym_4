using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class HomepageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
