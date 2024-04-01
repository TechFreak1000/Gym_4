using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class CustomerDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
