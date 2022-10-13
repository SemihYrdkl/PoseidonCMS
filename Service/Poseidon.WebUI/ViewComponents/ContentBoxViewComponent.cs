using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Poseidon.WebUI.ViewComponents
{
    public class ContentBoxViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            return View();
        }
    }
}
