using Microsoft.AspNetCore.Mvc;

namespace CORE.Controllers.Syntel
{
    public class SyntelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
