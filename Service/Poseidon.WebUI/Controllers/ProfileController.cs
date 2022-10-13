using Microsoft.AspNetCore.Mvc;
using Poseidon.Application.Services.Interface;

namespace Poseidon.WebUI.Controllers
{
    public class ProfileController : Controller
    {
        private IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
