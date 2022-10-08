using Microsoft.AspNetCore.Mvc;

namespace Poseidon.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
