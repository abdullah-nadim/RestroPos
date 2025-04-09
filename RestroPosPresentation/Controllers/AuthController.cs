using Microsoft.AspNetCore.Mvc;
using PosService;

namespace RestroPosPresentation.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
