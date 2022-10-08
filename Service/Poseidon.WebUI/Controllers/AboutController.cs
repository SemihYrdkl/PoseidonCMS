using Microsoft.AspNetCore.Mvc;

namespace Poseidon.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
