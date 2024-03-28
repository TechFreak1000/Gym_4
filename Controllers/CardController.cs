using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
