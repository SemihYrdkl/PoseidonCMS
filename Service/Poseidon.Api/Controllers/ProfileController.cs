using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poseidon.Application.Dtos;
using Poseidon.Application.Services.Interface;

namespace Poseidon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet(template: "getall")]
        public IActionResult GetList()
        {
            var result = _profileService.ProfileList();

            return Ok(result);
        }

    }
}
